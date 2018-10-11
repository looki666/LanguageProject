﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NPC : Character {

    GameController controller;
    [SerializeField] protected String nameString;
    private Model model;

    private EnvironmentManager envManager;

    // Use this for initialization
    void Start() {
        envManager = GameObject.Find("EnvironmentManager").GetComponent<EnvironmentManager>();
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        if (nameString.Equals("Bob")) {
            model = CustomModels.BobModel();
            GoTo("Evan");
        }

        if (nameString.Equals("Evan")) {
            model = CustomModels.EvanModel();
        }
    }

    /**
     * if the game is in Speaking Mode (kept track of by a bool in GameController,
     * and this NPC is clicked, say the expression to the NPC.
     */
    private void OnMouseDown() {
        if (!EventSystem.current.IsPointerOverGameObject()) { // make sure not clicking canvas
            ExpressionPiece selectedExpr = controller.GetSelectedExpression(); 
            if (selectedExpr == null) {
                // Debug.Log("No selected expression to say to this NPC");
            } else {
                ReceiveExpression(selectedExpr);
                Destroy(selectedExpr.gameObject);
                controller.HidePointer();
                controller.SetInSpeakingMode(false);
            }
        }
    }

    public void ReceivePerceptualReport(params Expression[] report) {
        if (this.model == null) {
            return;
        }

        foreach (Expression p in report) {
            this.model.Add(p);
        }
    }

    void ReceiveExpression(ExpressionPiece exprPiece) {
        Expression utterance = exprPiece.expression;

        // Debug.Log(this.nameString + " is seeing '" + utterance + "'");

        if (this.model == null) {
            // Debug.Log("No associated model.");
            ShowSpeechBubble("questionMark");
            this.controller.placeExpression.Play();
            return;
        }

        if (!utterance.type.Equals(SemanticType.TRUTH_VALUE)) {
            // Debug.Log("Semantic Type of utterance is not sentence/truth value.");
            ShowSpeechBubble("questionMark");
            this.controller.placeExpression.Play(); // TODO make a unique sound for this
            return;
        }

        if (this.model.Proves(utterance)) {
            ShowSpeechBubble("yes");
            this.controller.combineSuccess.Play(); // TODO make a unique sound effect for this
        } else if (this.model.Proves(new Phrase(Expression.NOT, utterance))) {
            ShowSpeechBubble("nope");
            this.controller.failure.Play();
        } else {
            ShowSpeechBubble("idk");
            this.controller.lowClick.Play();
        }
    }

    /**
     * imageName is the image to display in the speechbubble
     */
    public void ShowSpeechBubble(string imageName) {
        GameObject screenCanvas = GameObject.Find("ScreenCanvas");
        GameObject response = new GameObject();
        response.name = "Response";
        response.transform.SetParent(screenCanvas.transform);
        response.transform.position = new Vector3(Camera.main.WorldToScreenPoint(this.transform.position).x, Camera.main.WorldToScreenPoint(this.transform.position).y + 35);
        response.layer = 5;
        Image responseImage = response.AddComponent<Image>();
        Sprite headSprite = Resources.Load<Sprite>("PlaceholderSprites/" + imageName);
        responseImage.sprite = headSprite;
        responseImage.transform.localScale *= .25f;
        Destroy(response, 2.0f);

    }

    // method for testing that Bob will move to 
    public void RunToEvan() {
        GameObject evan = GameObject.Find("Evan");

        target = evan.transform;
        speed = 2;
        GoToTarget();
    }

    public void GoTo(String targetID) {
        GameObject targetObject = GameObject.Find(targetID);
        target = targetObject.transform;
        speed = 2;
        GoToTarget();
    }

    // called when Character enters the trigger collider of an object 
    public void OnTriggerEnter2D(Collider2D other) {
        Perceivable po = other.GetComponent<Perceivable>();
        if (po != null) {
            po.SendPerceptualReport(this);
        }
    }

    // NOTE: objects are perceived both when NPC enters and exits their range of perceptability
    // public void OnTriggerExit2D(Collider2D other) {
    //     if (other.GetComponent<Perceivable>() != null) {
    //         envManager.ComputePerceptionalReport(this);
    //     }
    // }
}
