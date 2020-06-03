using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {
    [Header("Set in Inspector")]
    public float moveRatio = 1f;

    [Header("Set in Dynamically")]
    private string moveDirection = "up";
    
    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("Move", moveRatio, moveRatio);
    }

    private void Update() {
        if (Input.GetKeyDown("left")) {
            moveDirection = "left";
        } else if (Input.GetKeyDown("up")) {
            moveDirection = "up";
        }
        else if (Input.GetKeyDown("down")) {
            moveDirection = "down";
        } else if (Input.GetKeyDown("right")) {
            moveDirection = "right";
        }
    }

    void Move() {
        Vector3 pos = transform.position;

        switch (moveDirection) {
            case "left":
                pos.x -= 1;
                break;
            
            case "right":
                pos.x += 1;
                break;
            
            case "up":
                pos.y += 1;
                break;
            
            case "down":
                pos.y -= 1;
                break;
        }
        
        transform.position = pos;
    }
}