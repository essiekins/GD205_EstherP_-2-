using UnityEngine;
using UnityEngine.InputSystem; //we add this directive to add on the new input system

public class MoveEgg : MonoBehaviour //this incorporates the name we gave the file
{
    InputAction moveAction; //create a new InputAction object called moveAction
    //InputAction jumpAction;
    //int EggPos; //basic variable example

    //wasd controls
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        Debug.Log("this is a message from start");
        //EggPos = 0;
        //Transform specialPos; 

        //"plug in" our local InputAction object into the default move input
        //we have to make sure this FindAction() is used inside of setup
        //because it will be very slow and inefficient if we run it constantly (unnecessarily)
        moveAction = InputSystem.actions.FindAction("move");
        //moveAction = InputSystem.actions.FindAction("jump");
    }

    // Update is called once per frame, like the draw function in Processing
    void Update(){
        //We create a new Vector2 (variable to store 2 dimensional positions)
        //we then assign it to take the axis values from the "move" InputAction
        Vector2 rawMove = moveAction.ReadValue<Vector2>();
        //Vector2 rawMove = jumpAction.ReadValue<Vector2>();

        //Debug.Log operates like println() in Processing
        //so we will send these values to our console so we can compare
        Debug.Log(rawMove);

        //We can use InputAction.WasPressedThisFrame() to check if this input was newly input
        //because we only want it to move based on a new press and not from holding it down
        
        //if (moveAction.WasPressedThisFrame()){ //it returns true if newly pressed
        // (ofset x, offset y, offset z) the y is checking if it's below it 
            //if (transform.position + new Vector3(0f,-1f,0f)) == specialPos.position {
                //Debug.log('Boom');
            //}
                

            //We offset the position by using +=
            //and mapping the x input to x position
            //and the y input to z position 
            //(because we want it to move forward rather than up)

            //transform.position will access the position of the transform component of the GameObject
            //that this script is attached to
             transform.position += new Vector3(rawMove.x, 0f, rawMove.y);
        }

    }
//}
