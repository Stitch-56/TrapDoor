using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriggerController : MonoBehaviour {
    public LevelManager levelManager;
    // Use this for initialization
    void Start ()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    // JH - Initially you had this function within the Update function so you were getting errors.
    public void OnTriggerEnter2D(Collider2D collision)
    //this function allows us to set the checkpoints we have to the transform we made and send a debug log to the console to show activation.
    //it activates the checkpoint through collisions
    {
        // levelManager.currentCheckpoint = gameObject;

        // JH - Call the OpenTrapDoor() function on the LevelManager
        levelManager.OpenTrapDoor();
        Debug.Log("Trap has been opened");
    }
}
