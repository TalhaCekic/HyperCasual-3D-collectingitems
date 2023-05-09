using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public Animator anims;
    public Rigidbody rb;

    [SerializeField] Joystick joystick;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject manager;

    //spawm
    [SerializeField] pearlSpawner PearlSpawner;
    [SerializeField] GameObject Spawmner;
    public GameObject pearl;
    [SerializeField] starSpawner StarSpawner;
    [SerializeField] GameObject spawmer;
    public GameObject star;

    private int deðer = 4;
    void Start()
    {
        gameManager = manager.GetComponent<GameManager>();
        PearlSpawner = Spawmner.GetComponent<pearlSpawner>();
        StarSpawner = spawmer.GetComponent<starSpawner>();

        int pearlCount = 25;
        for (int i = pearlCount; i > 0; i--)
        {
           PearlSpawner.oneTH();
            PearlSpawner.twoTH();
            PearlSpawner.threeTH();
            PearlSpawner.fourTH();
    
        }
        int starCount = 25;
        for (int i = starCount; i > 0; i--)
        {
            StarSpawner.oneTH();
            StarSpawner.twoTH();
            StarSpawner.threeTH();
            StarSpawner.fourTH();

        }
    }
    void Update()
    {  

        //hareket.
        move();
        
           
    }
    public void move(){
            rb.velocity = new Vector3(joystick.Horizontal* speed, rb.velocity.y, joystick.Vertical* speed);
         if(joystick.Horizontal != 0 || joystick.Vertical != 0){
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            anims.SetBool("speed", true);
            anims.SetBool("swim",true);
         }
        else
        anims.SetBool("speed",false);  
        anims.SetBool("swim",false);
    }


    private void OnTriggerEnter(Collider Player){
        if(Player.tag == "jump"){
        anims.SetBool("jump",true);
        anims.SetBool("speed",false);
        }
        if (Player.tag == "pearl")
        {
            gameManager.couldawnSliderPeal.gameObject.SetActive(true);
        }
        if(Player.tag == "cupe")
        {
            gameManager.couldawnSliderStar.gameObject.SetActive(true);
        }
        if(Player.tag == "inciSell")
        {

        }
        if(Player.tag == "yýldýzSell")
        {

        }
    }
    public void OnTriggerStay(Collider Player){
        if(Player.tag == "jump"){
        anims.SetBool("jump",true);
        anims.SetBool("speed",false);
        anims.SetBool("swim",false);
        
        }
    if(Player.tag == "pearl"){

            gameManager.a();
            if (gameManager.pearlCollect == true) 
            {
            
            if (gameManager.pearlEsitlik == false)
            {
                switch (deðer)
                {
                    case 1:
                        PearlSpawner.oneTH();
                        break;
                    case 2:
                        PearlSpawner.twoTH();
                        break;
                    case 3:
                        PearlSpawner.threeTH();
                        break;
                    case 4:
                        PearlSpawner.fourTH();
                        break;
                }
                    gameManager.couldawnSliderPeal.gameObject.SetActive(false);
            }

            }
        }
    if(Player.tag == "cupe")
        {
            gameManager.b();
            
            if (gameManager.starCollect == true)
            {
                
                if (gameManager.pearlEsitlik == false)
                {
                    switch (deðer)
                    {
                        case 1:
                            StarSpawner.oneTH();
                            break;
                        case 2:
                            StarSpawner.twoTH();
                            break;
                        case 3:
                            StarSpawner.threeTH();
                            break;
                        case 4:
                            StarSpawner.fourTH();
                            break;
                    }
                    gameManager.couldawnSliderStar.gameObject.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        if (Player.tag == "jump")
        {
            anims.SetBool("jump", false);
            anims.SetBool("speed", true);
        }
        if (Player.tag == "pearl")
        {
            gameManager.couldawnSliderPeal.gameObject.SetActive(false);
            


        }
        if (Player.tag == "cupe")
        {
                gameManager.couldawnSliderStar.gameObject.SetActive(false);

        }
    }
}



