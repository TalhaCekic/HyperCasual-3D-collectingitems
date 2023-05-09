using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destroyerPearl : MonoBehaviour
{
     GameManager gameManager;
     GameObject manager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider pearl)
    {
        if (pearl.gameObject.tag == "Player")
        {
            gameManager.couldawnSliderPeal.gameObject.SetActive(true);

        }


    }

    private void OnTriggerStay(Collider pearl)
    {
        if (pearl.gameObject.tag == "Player")
        {
            if (gameManager.pearlCollect == true)
            {
                gameManager.pearlCollect = false;
                gameManager.collectPearls();
                gameManager.pearlMath();

                Destroy(gameObject);
                gameManager.pearlCollects = 5;
                gameManager.pearlCollect = false;
                gameManager.couldawnSliderPeal.gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider pearl)
    {
        if (pearl.gameObject.tag == "Player")
        {
            gameManager.pearlCollects = 5;
            gameManager.pearlCollect = false;


        }
    }
}
