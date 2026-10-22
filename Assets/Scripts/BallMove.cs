using UnityEngine;
using UnityEngine.InputSystem;

public class BallMove : MonoBehaviour{
    InputAction moveAction;
    InputAction lookAction;

    //used for wasd on ship [fingers crossed]
    Vector2 _moveDirection;

    public InputActionReference move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){ 
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");

        Physics.gravity = new Vector3(5, -2.0F, 2*2);
    }

    // Update is called once per frame
    void Update(){
        // Get movement input
        Vector2 rawMove = moveAction.ReadValue<Vector2>();
        Debug.Log("Raw move input =" + rawMove);

        Vector3 directionMove = new Vector3 (rawMove.x,0f, rawMove.y);
        
        //access rigid component
        GetComponent<Rigidbody>().AddRelativeForce(directionMove*3f);
        //move the ball
        
        //if (rawMove == Vector2.zero){
            //GetComponent<Rigidbody>().(Sleep);
        //}
    
        Vector2 rawLook = lookAction.ReadValue<Vector2>();
        //Debug.Log("Raw look input=" + rawLook);

        //convert to 3d and modify look
        Vector3 look = new Vector3(rawLook.y,rawLook.x,0f);
        transform.Rotate(look);
        
        //wasd ship
        _moveDirection = move.action.ReadValue<Vector2>();
    }

    void OnCollisionEnter(Collision colReport)
    {
        //destroy this game object, the one attached to script
        Debug.Log("Bang!");
        Destroy(colReport.gameObject);
    
    }
}
