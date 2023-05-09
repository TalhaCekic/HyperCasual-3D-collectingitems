using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoyerCupe : MonoBehaviour
{
    GameManager gameManager;
    GameObject manager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        

    }
    private void OnTriggerEnter(Collider cube)
    {
        if (cube.gameObject.tag == "Player")
        {
            gameManager.couldawnSliderStar.gameObject.SetActive(true);

        }

    }
    private void OnTriggerStay(Collider cupe)
    {
        if (cupe.gameObject.tag == "Player")
        {
            if (gameManager.starCollect == true)
            {
                gameManager.starCollect = false;
                gameManager.collectStar();
                gameManager.starMath();
               
                    Destroy(gameObject);
                gameManager.starCollects = 3;
                gameManager.starCollect = false;
                
            }
        }
    }
    private void OnTriggerExit(Collider cupe)
    {
        if(cupe.gameObject.tag == "Player")
        {
            gameManager.starCollects = 3;
            gameManager.starCollect = false;
        }
     }
        
    
}
