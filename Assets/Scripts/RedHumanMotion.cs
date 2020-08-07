﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHumanMotion : MonoBehaviour
{
    float speed;
    float angularSpeed;
    float hMove, vMove;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        angularSpeed = 100f;
        
    }

    // Update is called once per frame
    void Update()
    {
        // if a key was pressed
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            hMove = Input.GetAxis("Horizontal") * angularSpeed * Time.deltaTime;
            vMove = Input.GetAxis("Vertical")* speed * Time.deltaTime;
            GetComponent<Animation>().Play("ShieldWarrior@Walk01");
            transform.Rotate(0, hMove, 0);
            transform.Translate(Vector3.forward * vMove);
        }
        else
        {
            GetComponent<Animation>().Play("ShieldWarrior@Idle01");

        }
    }
}
