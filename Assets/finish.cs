using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    
    [SerializeField] private AudioSource finishSFX;
    private bool levelCompleted = false; 
    // Start is called before the first frame update
    private void Start()
    {
        finishSFX = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "Player"){
            finishSFX.Play();
            levelCompleted = true;
            Invoke("completeLevel", 2f);            
        }
    }

    private void completeLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

