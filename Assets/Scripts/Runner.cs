using UnityEngine;

public class Runner : MonoBehaviour
{
    public Transform target;
    public float speed= 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdateUpdate()
    {
        //find out where one object is coming from another
        Vector3 targetOffset = target.position - transform.position;
        Vector3 targetDirection = Vector3.Normalize(targetOffset);

        GetComponent<Rigidbody>().AddForce(targetDirection*speed); 
    }
}
