using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody; 
    [SerializeField] int timeToFall = 3;


    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Seconds have passed since start of game
        if(Time.time > timeToFall) {
            renderer.enabled = true;
            rigidbody.useGravity = true;   
        }
    } 

}
