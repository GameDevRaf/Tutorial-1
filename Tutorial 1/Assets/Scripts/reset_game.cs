using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class reset_game : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider) {

        Scene Current_Scene = SceneManager.GetActiveScene ();

        SceneManager.LoadScene (Current_Scene.name);
        
    }

}
