using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //inci toplama.
    private int pearlPieces = 0;
    private int maxPearl = 5;
    public Text pearlText;
    public bool pearlEsitlik = false;

    private int starPieces = 0;
    private int maxStar =4;
    public Text starText;
    public bool starEsitlik = false;

    public bool pearlCollect = false;
    public bool starCollect = false;
    //yok ettimi

    //couldown slider.
    public Slider couldawnSliderPeal;
    public Slider couldawnSliderStar;

    //toplama süresi.
    public float pearlCollects;
    public float starCollects;

    playerMovement PlayerMovement;
    [SerializeField] GameObject player;
    [SerializeField] GameObject pearl;


    //destroyer olacaklar
    GameObject[] cupes;
    GameObject[] Pearl;

    void Start()
    {
        PlayerMovement = player.GetComponent<playerMovement>();

        //slider
        pearlCollects = 5f;
        starCollects = 3f;
        couldawnSliderPeal.value =pearlCollects;
        couldawnSliderPeal.maxValue= pearlCollects;
        couldawnSliderStar.value = starCollects;
        couldawnSliderStar.maxValue = starCollects;

        //destroyer olacakları bul
        cupes = GameObject.FindGameObjectsWithTag("cupe");
        Pearl = GameObject.FindGameObjectsWithTag("pearl");

    }


    void Update()
    {
        //ekrana yazdır
        pearlText.text = pearlPieces.ToString("0") + " / " + maxPearl.ToString("0");
        starText.text = starPieces.ToString("0") + " / " + maxStar.ToString("0");

        //slider.
        couldawnSliderPeal.value = pearlCollects;
        couldawnSliderStar.value = starCollects;


    }
    //inci toplama
    public void collectPearls()
    {
        if (pearlCollects <= 0)
        {
            pearlCollects = 0;
            if(pearlEsitlik == true)
            {
                pearlCollect = true;
            }
            
            
        }
        if(pearlCollects > 0)
        { 
            if (pearlCollects == 0)
            {
                pearlMath();
            }
        }
    }
    public void pearlMath()
    {
        if (pearlPieces == maxPearl)
        {
            pearlPieces = maxPearl;
           
               pearlEsitlik = true;  

        }
        if (pearlPieces < maxPearl) 
        {
            pearlPieces = pearlPieces + 1;  
        }
    }

    //star toplama
    public void collectStar()
    {
        if (starCollects <= 0)
        {
            starCollects = 0;

            if (starEsitlik == true) 
            { 
                starCollect = false;
                
            }
        }
        if (starCollects > 0)
        {
            if (starCollects == 0)
            {
                starMath();
                
            }
        }
    }

    public void starMath()
    {

        if (starPieces == maxStar)
        {
            starPieces = maxStar;
            starEsitlik = true;

        }
        if (starPieces <= maxStar)
        {
            starPieces = starPieces + 1;

        }
    }   
    //player movemente yollandı...
    public void a()
    {
        if (pearlCollects <= 0)
        {
            pearlCollects = 0;
            if (pearlPieces == maxPearl)
            {
                pearlPieces = maxPearl;
                pearlEsitlik = true;
                pearlCollect = false;
            }
            if (pearlPieces < maxPearl)
            {
                pearlCollect = true;

            }

        }
        if (pearlCollects > 0)
        {
            pearlCollects -= Time.deltaTime;
            
        }
    }
    public void b()
    {
        if (starCollects <= 0)
        {
            starCollects = 0;

            if (starPieces == maxStar)
            {
                starPieces = maxStar;
                starEsitlik = true;
                starCollect = false;
            }
            if (starPieces < maxStar)
            {
                starCollect = true;
                
            }

        }
        if (starCollects > 0)
        {
            starCollects -= Time.deltaTime;
        }

    }
    //
    public void inciSells()
    {
        
        starPieces = 0;
    }

}
    




