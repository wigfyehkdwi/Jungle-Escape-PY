using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    float speed = 2;

    bool canRotateR;
    bool canRotateL;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //check for rotate inputs
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            canRotateR = true;
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            canRotateL = true;
        }
    }

    void FixedUpdate()
    {
        //forward movement
        var z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, z);

        //rotate 90 degrees
        if(canRotateR){
            transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y + 90, 0);
            canRotateR = false;
        }
        if(canRotateL){
            transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y - 90, 0);
            canRotateL = false;
        } 
    }
}
