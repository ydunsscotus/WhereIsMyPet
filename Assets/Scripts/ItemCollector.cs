using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int apples = 0; 
    private Text applesText; 
    [SerializeField] AudioSource collectSFX;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Apple")){
            collectSFX.Play();
            Destroy(collision.gameObject);
        }
    }

}
