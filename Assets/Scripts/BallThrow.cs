using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class BallThrow : MonoBehaviour{
    //float Speed = 3f;
    //float gravity =-4f;
    //private BallController ballController; 
    private new Camera camera;
    private ThrowAction throwAction;

    void Awake()
    {
        throwAction = new ThrowAction();
    }

    //engage ball throwing
    void OnEnable(){
        //gets called when click/throw ball is first triggered
        throwAction.Player.Throw.performed += Throw;
        throwAction.Player.Enable();
    }
    //disable throw after throwing
    void OnDisable(){ 
        throwAction.Player.Throw.performed -= Throw;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        this.Camera = Camera.main;
        Cursor.visible = false;
    }

    //Throw
    void Throw(InputAction.CallbackContext obj){
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        //If the ball hits our bottles, destroy them
        if(Physics.Raycast (ray, out RaycastHit hit, 100f)){
            if (hit.transform.TryGetComponent<Target>(out Target ts))
                ts.GetThrow(ray.direction);
        }
    }
}
