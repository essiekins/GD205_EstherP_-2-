
using UnityEngine;
using UnityEngine.InputSystem;

public class Seeker : MonoBehaviour
{
    public Transform target;
    public float speed= 3f;
    public InputActionReference move;
    
    //used for wasd on ship [fingers crossed]
    public Rigidbody2D rb;
    public float moveSpeed;
    Vector2 _moveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update(){
        //wasd ship
        //_moveDirection = move.action.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //find out where one object is coming from another
        Vector3 targetOffset = target.position - transform.position;
        Vector3 targetDirection = Vector3.Normalize(targetOffset);

        GetComponent<Rigidbody>().AddForce(targetDirection*speed); 

        //wasd ship
       // rb.linearVelocity = new Vector2(x:_moveDirection.x * moveSpeed, y:_moveDicretion.y * moveSpeed);
    }
    
}
