using UnityEngine;
using UnityEngine.InputSystem;
public class SkeleWalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private InputAction moveAction;
    void Start()
    {
        moveAction= InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(moveAction.ReadValue<Vector2>());
        GetComponent<Animator>().SetFloat("WalParameter",moveAction.ReadValue<Vector2>().y);
    }
}
