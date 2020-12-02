using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //All unity editor scripts need using UnityEditor, this means they CANNOT COMPILE. They must be placed in special Editor folder



//This script will be visible instead of the default editor script for the "target" MovementController
[CustomEditor(typeof(MovementController))] //Define this script as an "Editor" script, which targets Movement Controller
public class MovementControllerEditor : Editor
{ //Extends Editor required



    private MovementController targetMovementControl;
    private SerializedObject movementCntrl; //A serialized object
    private SerializedProperty movementSpeed; //A serialized variable



    public void OnEnable()
    {
        targetMovementControl = (MovementController)target;



        movementCntrl = new SerializedObject(target); //target is MovementController
        movementSpeed = movementCntrl.FindProperty("speed"); //Use reflection to find a variable (property) in the target project
    }



    public override void OnInspectorGUI() //Must be overwritten
    {
        //Debug.Log("called");
        DrawDefaultInspector(); //Draws the default inspector you would normally see
    }



}