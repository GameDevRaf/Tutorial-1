using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody Movement;

    // Start is called before the first frame update
    void Start() {


        
    }

    // Update is called once per frame
    void Update() {

            
        if (Input.GetKey("right")) {

            Vector3 Movement_Direction = Vector3.right;

            Movement.velocity = Movement_Direction;

        }

        if (Input.GetKey("left")) {

           Movement.velocity = Vector3.left; 
        
        }        if (Input.GetKey("up")) {

            Vector3 Movement_Direction = Vector3.up;

            Movement.velocity = Movement_Direction;

        }

    }

}
