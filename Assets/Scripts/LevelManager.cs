using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public HingeJoint2D pivotTrapDoor;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckForKeyboardInputs();
	}

    private void CheckForKeyboardInputs()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            OpenTrapDoor();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CloseTrapDoor();
        }
    }

    public void OpenTrapDoor()
    {
        JointMotor2D theMotor = pivotTrapDoor.motor;
        theMotor.motorSpeed = 100f;
        pivotTrapDoor.motor = theMotor;
    }

    public void CloseTrapDoor()
    {
        JointMotor2D theMotor = pivotTrapDoor.motor;
        theMotor.motorSpeed = -100f;
        pivotTrapDoor.motor = theMotor;
    }
}
