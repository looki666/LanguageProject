﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * The main Controller class. Sets up the Scene, creates ExpressionPieces, etc.
 */
public class GameController : MonoBehaviour {

    public GameObject keyboardInstance;
    public GameObject canvasInstance;

	void Start () {
        SetUpCanvas();
        SetUpKeyboard();
    }

    /**
     * Creates the Canvas which holds the keyboard and workspace
     */
    public void SetUpCanvas() {
        GameObject canvas = Resources.Load("Canvas") as GameObject;
        canvasInstance = Instantiate(canvas, new Vector2(100, 100), Quaternion.identity) as GameObject;
        keyboardInstance = canvasInstance.transform.Find("Keyboard").gameObject as GameObject;
    }

    private void SetUpSpawner(Word w) {
        GameObject spawner = Resources.Load("PieceSpawner") as GameObject;
        GameObject spawnerInstance = Instantiate(spawner, new Vector2(0, 0), Quaternion.identity) as GameObject;
        spawnerInstance.transform.SetParent(keyboardInstance.transform);
        ExpressionPieceSpawner spawnerScript = spawnerInstance.GetComponent<ExpressionPieceSpawner>();
        spawnerScript.SetUpSpawner(w);
    }

    // Creates the keyboard from which the user can click on ExpressionPieceSpawners,
    // which will create ExpressionPieces in the workspace.
    public void SetUpKeyboard() {
        // LOGIC/FUNCTION WORDS
        // truth value constants
        SetUpSpawner(new Word(SemanticType.TRUTH_VALUE, "verum"));

        // truth function contstants
        SetUpSpawner(new Word(SemanticType.TRUTH_FUNCTION_1, "not"));
        SetUpSpawner(new Word(SemanticType.TRUTH_FUNCTION_2, "or"));

        // determiners
        SetUpSpawner(new Word(SemanticType.DETERMINER, "the"));

        // quantifiers
        SetUpSpawner(new Word(SemanticType.QUANTIFIER, "some"));

        // 2-place relation reducers
        SetUpSpawner(new Word(SemanticType.RELATION_2_REDUCER, "itself"));
        
        // CONTENT WORDS   
        // proper names
        SetUpSpawner(new Word(SemanticType.INDIVIDUAL, "alice"));
        SetUpSpawner(new Word(SemanticType.INDIVIDUAL, "bob"));

        // predicates
        SetUpSpawner(new Word(SemanticType.PREDICATE, "run"));
        SetUpSpawner(new Word(SemanticType.PREDICATE, "key"));
        SetUpSpawner(new Word(SemanticType.PREDICATE, "apple"));

        // 2-place relations
        SetUpSpawner(new Word(SemanticType.RELATION_2, "help"));

        // 3-place relations
        SetUpSpawner(new Word(SemanticType.RELATION_3, "give"));
    }
}
