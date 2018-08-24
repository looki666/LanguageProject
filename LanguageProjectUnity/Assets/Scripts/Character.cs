﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * NPC and Player will both extend Character (those will likely be the only two types of Characters)
 */
public abstract class Character : MonoBehaviour {

    public const int NORTH = 0;
    public const int EAST = 1;
    public const int SOUTH = 2;
    public const int WEST = 3;

    [SerializeField] protected float speed;
    protected Vector2 velocity;
    protected int directionFacing;
    [SerializeField] Sprite[] sprites;

    public Transform target;
    Vector3[] path;
    int targetIndex;

    protected virtual void Update() {
        Move();
    }

    /**
     * Updates the transform (position) of this Character based on the velocity field of
     * the character. 
     */
    public void Move() {
        transform.Translate(velocity * speed * Time.deltaTime);
    }

    public void GoToTarget() {
        PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
    }

    private void OnPathFound(Vector3[] newPath, bool pathSuccessful) {
        if (pathSuccessful) {
            path = newPath;
            StopCoroutine("FollowPath");
            StartCoroutine("FollowPath");
        }
    }

    public void OnDrawGizmos() { // draws path
        if (path != null) {
            for (int i = targetIndex; i < path.Length; i++) {
                Gizmos.color = Color.black;
                Gizmos.DrawCube(path[i], new Vector3(.5f,.5f,.5f));

                if (i == targetIndex) {
                    Gizmos.DrawLine(transform.position, path[i]);
                } else {
                    Gizmos.DrawLine(path[i - 1], path[i]);
                }
            }
        }
    }

    IEnumerator FollowPath() {
        Vector3 currentWaypoint = path[0];
        while (true) {
            if (transform.position == currentWaypoint) {
                targetIndex++;
                if (targetIndex >= path.Length) {
                    yield break; //exit coroutine when finished following path
                }
                currentWaypoint = path[targetIndex];
            }

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * Time.deltaTime);
            yield return null;

        }
    }
}
