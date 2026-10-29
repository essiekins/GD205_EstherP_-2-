using UnityEngine;
using UnityEngine.InputSystem;

public class Cyclops : MonoBehaviour {
    InputAction cursorAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float explosionForce = 5f;
    public float explosionRadius = 5f;
    void Start() {
        //we find thse by going to projects settings > input system package > inputactions > player or UI etc.
        //use them as a reference to call/find action
        cursorAction = InputSystem.actions.FindAction("Point");
        cursorAction = InputSystem.actions.FindAction("Attack");
        
    }

    // Update is called once per frame
    void Update() {
        Ray beam = Camera.main.ScreenPointToRay(cursorAction.ReadValue<Vector2>());
        RaycastHit beamHit =  new RaycastHit();

        //here we use the actions, let's try left click under "attack"
        //if (if clickAction.IsPressed.)
        
        //cast ray
        if (Physics.Raycast(beam, out beamHit)){
        Debug.Log("Cyclops hit" + beamHit.collider.name);
        //
        beamHit.rigidbody.AddExplosionForce(explosionForce, beamHit.point, explosionRadius);


        }
    }
}
