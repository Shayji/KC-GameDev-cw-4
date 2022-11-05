using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class classwork4 : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreTx;

    public void PressMe()
    {
        score++;
        scoreTx.text = "Score :" + score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
   
    
    void Update()
    {
        
    }
}
