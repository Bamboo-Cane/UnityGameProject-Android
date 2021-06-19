using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed;
    public TouchPositionExample hello;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
            transform.Rotate(Vector3.up, hello.leftRightState * rotateSpeed * Time.deltaTime);
        //if(hello.upDownState !=0 )
        //transform.Rotate(Vector3.left, hello.upDownState * rotateSpeed * Time.deltaTime);
    }
}
