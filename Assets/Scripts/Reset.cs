using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject player;
    public GameObject endScreen;
    public ParticleSystem stars;
    
    // Start is called before the first frame update
    void Start()
    {
        endScreen.SetActive(false);
        stars.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //if fall off platform, game over
        if(player.transform.position.y < 0.05f){
            GameOver();
        }
    }
    
    //when reach finish, activate end screen & particles and deactivate player
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("end")){
            stars.Play();
            player.SetActive(false);
            Invoke("EndScreen", 0.25f);
        }
    }

    void EndScreen(){
        endScreen.SetActive(true);
    }

    void GameOver(){
        //reset game
        SceneManager.LoadScene(0);
    }
}
