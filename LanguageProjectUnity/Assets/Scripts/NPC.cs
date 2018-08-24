﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : Character {

    GameController controller;
    [SerializeField] protected String nameString;
    private IModel model;

	// Use this for initialization
	void Start () {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        if (nameString.Equals("Bob")) {
            model = Models.BobModel();
            RunToEvan();
        }

        if (nameString.Equals("Evan")) {
            model = Models.EvanModel();
        }

        Debug.Log(model.ToString());

        HashSet<Expression> h = new HashSet<Expression>();
        h.Add(new Phrase(Expression.ACTIVE, Expression.BOB));

        Debug.Log(h.Contains(new Phrase(Expression.ACTIVE, Expression.BOB)));
	}

    /**
     * if the game is in Speaking Mode (kept track of by a bool in GameController,
     * and this NPC is clicked, say the expression to the NPC.
     */
    private void OnMouseDown() {
        ExpressionPiece selectedExpr = controller.GetSelectedExpression();
        if (selectedExpr == null) {
            Debug.Log("No selected expression to say to this NPC");
        } else {
            ReceiveExpression(selectedExpr);
            Destroy(selectedExpr.gameObject);
            controller.HidePointer();
            controller.SetInSpeakingMode(false);
        }
    }

    void ReceiveExpression (ExpressionPiece exprPiece) {
        Expression utterance = exprPiece.expression;

        Debug.Log(this.nameString + " is seeing '" + utterance + "'");

        if (this.model == null) {
            Debug.Log("No associated model.");
            ShowSpeechBubble("questionMark");
            return;
        }

        if (!utterance.type.Equals(SemanticType.TRUTH_VALUE)) {
            Debug.Log("Semantic Type of utterance is not sentence/truth value.");
            ShowSpeechBubble("questionMark");
            this.controller.placeExpression.Play(); // TODO make a unique sound for this
            return;
        }

        if (this.model.Contains(utterance)) {
            Debug.Log("That's TRUE in their model.");
            ShowSpeechBubble("true");
            this.controller.combineSuccess.Play(); // TODO make a unique sound effect for this
        } else {
            Debug.Log("That's FALSE in their model.");
            ShowSpeechBubble("false");
            this.controller.failure.Play(); // TODO make a unique sound effect for this
        }
    }

    /**
     * imageName is the image to display in the speechbubble
     */
    public void ShowSpeechBubble (string imageName) {
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
}


