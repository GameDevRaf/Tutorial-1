using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLD_playerjump : MonoBehaviour {
    public float Jump_Height;
    public Rigidbody2D Player_Rigidbody;


    private bool isGrounded;
    public Transform GroundCheck;
    public float Checkradius;
    public LayerMask whatisground;
    void FixedUpdate() {

        isGrounded = Physics2D.OverlapCircle (GroundCheck.position, Checkradius, whatisground);

        if (Input.GetKeyDown (KeyCode.UpArrow) && isGrounded == true) {

            Player_Rigidbody.AddForce (Vector2.up * Jump_Height * Time.fixedDeltaTime, ForceMode2D.Impulse);

        }



        if (Input.GetKeyDown (KeyCode.W) && isGrounded == true) {

            Player_Rigidbody.AddForce (Vector2.up * Jump_Height * Time.fixedDeltaTime, ForceMode2D.Impulse);

        }

    }

}
