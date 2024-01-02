using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidCubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed = 5;
    public float turnSpeed = 50;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * moveSpeed * Time.deltaTime, 0, -1 * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}