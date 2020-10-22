using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLD_playermove : MonoBehaviour {

    public float Move_Speed = 5f;
    public Rigidbody2D Player_Rigidbody;

    void FixedUpdate() {

        if (Input.GetKey (KeyCode.RightArrow)) {

            Vector2 Move = Vector2.right * Move_Speed * Time.deltaTime;

            Player_Rigidbody.velocity = Move;

        }

        if (Input.GetKey (KeyCode.LeftArrow)) {
            
              Vector2 movespeed = Vector2.left * Move_Speed * Time.deltaTime;

            Player_Rigidbody.velocity = movespeed;

        }



        if (Input.GetKey (KeyCode.D)) {
            
              Vector2 MoveSpeed = Vector2.right * Move_Speed * Time.deltaTime;

            Player_Rigidbody.velocity = MoveSpeed;
        }

        if (Input.GetKey (KeyCode.A)) {

              Vector2 movespeed = Vector2.left * Move_Speed * Time.deltaTime;

            Player_Rigidbody.velocity = movespeed;

        }

    }

}