using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boo : MonoBehaviour
{
    public Rigidbody2D mRigidBody;
    public float flapstrength;
    public Logic logic;
    public bool BooIsActive = true;



    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "HUFS BIRD";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BooIsActive)
        {
            mRigidBody.velocity = Vector2.up * flapstrength;
        }

        if (transform.position.y < -10)
        {
            logic.gameOver();
            BooIsActive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        logic.gameOver();
        BooIsActive = false;
    }

}
