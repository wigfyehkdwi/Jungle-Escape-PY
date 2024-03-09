using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollisionColorChange : MonoBehaviour
{
    public Material red;
  
    //when land on platform, change material to red
    void OnTriggerEnter(Collider other){
        gameObject.GetComponent<Renderer>().material = red;
    }
}
