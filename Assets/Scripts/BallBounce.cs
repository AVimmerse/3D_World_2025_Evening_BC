using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float ballBounce;
    public 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        Collider cd = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
