using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlatform : MonoBehaviour
{
    //when player leaves platfrom, delete platform
    void OnCollisionExit(Collision other){
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
}
