﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * The main Controller class. Sets up the Scene, creates ExpressionPieces, etc.
 */
public class GameController : MonoBehaviour {

    private GameObject currentKeyboard; // the subsection of the keyboard we're currently showing (e.g. Determiners)
    public GameObject canvasInstance;
    [SerializeField] private GameObject pointer; // arrow pointing to selected expression
    [SerializeField] private GameObject individualKeyboard;
    [SerializeField] private GameObject determinerKeyboard;
    [SerializeField] private GameObject predicateKeyboard;
    [SerializeField] private GameObject helpScreen;
    private bool keyboardOnBeforeHelpShown = true;

    public AudioSource highClick;
    public AudioSource lowClick;
    public AudioSource combineSuccess;
    public AudioSource placeExpression;
    public AudioSource failure;

    public const int PIECES_PER_ROW = 8;

    private bool inSpeakingMode = false; // true only right after user has submitted an expression (pressed checkmark button) and before user has selected an NPC to speak to

    public ExpressionPiece selectedExpression;

	void Start() {
        // Debug.Log(Screen.height/20.0f + " is the screen height");
        SetUpCanvas();
        SetUpKeyboard();
        SetUpPlayer();
        currentKeyboard = individualKeyboard;
        canvasInstance.SetActive(false);
        currentKeyboard.SetActive(true);
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && !helpScreen.activeInHierarchy) {
            canvasInstance.SetActive(!canvasInstance.activeInHierarchy);
            helpScreen.SetActive(helpScreen.activeInHierarchy);
            if (canvasInstance.activeInHierarchy) {
                highClick.Play();
            } else {
                lowClick.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.H)) {
            ShowOrHideHelpScreen();
        }
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    private void ShowOrHideHelpScreen() {
        bool helpScreenShowing = helpScreen.activeInHierarchy;
        if (helpScreenShowing) {
            helpScreen.SetActive(false);
            canvasInstance.SetActive(keyboardOnBeforeHelpShown);
            lowClick.Play();
        } else {
            keyboardOnBeforeHelpShown = canvasInstance.activeInHierarchy;
            canvasInstance.SetActive(false);
            helpScreen.SetActive(true);
            highClick.Play();
        }
    }

    /**
     * Creates the Canvas which holds the keyboard and workspace
     */
    public void SetUpCanvas() {
        canvasInstance.SetActive(true);
    }

    private void SetUpPlayer() {
        GameObject player = Resources.Load("Player") as GameObject;
        GameObject playerInstance = Instantiate(player, new Vector2(0, 0), Quaternion.identity) as GameObject;
    }

    private void SetUpSpawner(Expression e) {
        SemanticType type = e.type;
        GameObject spawner = Resources.Load("PieceSpawner") as GameObject;
        GameObject spawnerInstance = Instantiate(spawner, new Vector2(0, 0), Quaternion.identity) as GameObject;
        if (type.Equals(SemanticType.INDIVIDUAL)) {
            GameObject firstRow = individualKeyboard.transform.GetChild(0).gameObject;
            if (firstRow.transform.childCount < PIECES_PER_ROW) {
                spawnerInstance.transform.SetParent(firstRow.transform);
            } else {
                GameObject secondRow = individualKeyboard.transform.GetChild(1).gameObject;
                spawnerInstance.transform.SetParent(secondRow.transform);
            }
        } else if (type.Equals(SemanticType.DETERMINER)) {
            GameObject firstRow = determinerKeyboard.transform.GetChild(0).gameObject;
            if (firstRow.transform.childCount < PIECES_PER_ROW) {
                spawnerInstance.transform.SetParent(firstRow.transform);
            } else {
                GameObject secondRow = determinerKeyboard.transform.GetChild(1).gameObject;
                spawnerInstance.transform.SetParent(secondRow.transform);
            }
        } else if (type.Equals(SemanticType.PREDICATE)) {
            GameObject firstRow = predicateKeyboard.transform.GetChild(0).gameObject;
            if (firstRow.transform.childCount < PIECES_PER_ROW) {
                // Debug.Log("1st row's name is " + firstRow.name);
                spawnerInstance.transform.SetParent(firstRow.transform);
            } else {
                GameObject secondRow = predicateKeyboard.transform.GetChild(1).gameObject;
                // Debug.Log("second row's name is " + secondRow.name);
                spawnerInstance.transform.SetParent(secondRow.transform);
            }
        } else {
            // Debug.Log("invalid type");
        }
        ExpressionPieceSpawner spawnerScript = spawnerInstance.GetComponent<ExpressionPieceSpawner>();
        spawnerScript.SetUpSpawner(e, this);
    }

    /** Creates the keyboard (and sub-keyboards) from which the user can highClick on ExpressionPieceSpawners,
    * which will create ExpressionPieces in the workspace.
    */
    public void SetUpKeyboard() {
        // LOGIC/FUNCTION WORDS
        // determiners
        SetUpSpawner(Expression.NO);
        SetUpSpawner(Expression.A);
        SetUpSpawner(Expression.TWO);
        SetUpSpawner(Expression.THREE);
        SetUpSpawner(Expression.EVERY);

        // CONTENT WORDS   
        // proper names
        SetUpSpawner(Expression.BOB);
        SetUpSpawner(Expression.EVAN);

        // predicates
        SetUpSpawner(Expression.YELLOW);
        SetUpSpawner(Expression.GREEN);
        SetUpSpawner(Expression.BLUE);
        SetUpSpawner(Expression.RED);

        SetUpSpawner(Expression.IN_YELLOW_AREA);
        SetUpSpawner(Expression.IN_GREEN_AREA);
        SetUpSpawner(Expression.IN_BLUE_AREA);
        SetUpSpawner(Expression.IN_RED_AREA);
        SetUpSpawner(Expression.IN_YOUR_AREA);

        SetUpSpawner(Expression.FOUNTAIN);
        SetUpSpawner(Expression.LAMP);
        SetUpSpawner(Expression.ACTIVE);
        SetUpSpawner(Expression.INACTIVE);
        SetUpSpawner(Expression.KING);

        //HELP for testing ExpressionPiece object placements, delete later:
        // SetUpSpawner(new Word(SemanticType.RELATION_2, "help"));


        /** BELOW ARE PIECES TO BE USED LATER, NOT IN DEMO:
          // truth value constants
              SetUpSpawner(Expression.VERUM);

          // truth function contstants
              SetUpSpawner(Expression.NOT);
              SetUpSpawner(Expression.OR);

          // quantifiers
              SetUpSpawner(Expression.SOME);

          // 2-place relation reducers
              SetUpSpawner(Expression.ITSELF);

          // 2-place relations
          SetUpSpawner(Expression.HELP);

          // 3-place relations
              SetUpSpawner(Expression.GIVE);

          */
    }

    // updates the keyboard so that the tabToDisplayIndex-th tab is active,
    // and all other tabs become inactive
    public void SwitchKeyboardTab(int tabToDisplayIndex) {
        currentKeyboard.SetActive(false);
        if (tabToDisplayIndex == 0) { //Individual
            currentKeyboard = individualKeyboard;
            highClick.Play();
        } else if (tabToDisplayIndex == 1) { // Determiner
            currentKeyboard = determinerKeyboard;
            highClick.Play();
        } else if (tabToDisplayIndex == 2) { // Predicate
            currentKeyboard = predicateKeyboard;
            highClick.Play();
        }
        currentKeyboard.SetActive(true);
    }

    // Called when user presses button to submit the selected expression.
    // This method takes the selected expression and unparents it from the canvas,
    // then hides canvas (keyboard + workspace)
    public void SubmitSelectedExpression() {
        if(selectedExpression != null) {
            GameObject screenCanvas = GameObject.Find("ScreenCanvas");// a Canvas always on screen; never hidden
            selectedExpression.gameObject.transform.SetParent(screenCanvas.transform);
            canvasInstance.SetActive(!canvasInstance.activeInHierarchy);

            inSpeakingMode = true;

            combineSuccess.Play();
        } else {
            // Debug.Log("no selected expression to submit!");
            failure.Play();
        }
    }

    // getter
    public bool InSpeakingMode() {
        return inSpeakingMode;
    }

    public void SetInSpeakingMode(bool speakMode) {
        inSpeakingMode = speakMode;
    }

    public ExpressionPiece GetSelectedExpression() {
        return selectedExpression;
    }

    public void HidePointer() {
        pointer.SetActive(false);
    }

    public void ShowPointer() {
        pointer.SetActive(true);
        float selectedPieceHeight = selectedExpression.GetHeightInUnits() * ExpressionPiece.PIXELS_PER_UNIT;
        pointer.transform.position = new Vector3(selectedExpression.transform.position.x,
                                                 selectedExpression.transform.position.y + selectedPieceHeight / 2 + 15);
    }
}
