using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    public Scoring scoring;
    public static bool gameOver = false;
    public TMP_Text[] letters;
    private int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.name.Equals("Ball") && Throw.thrown)
        {
            Debug.Log("Basket is scored : " + Scoring.scored);
            if (Scoring.scored == false)
            {
                Debug.Log("Missed Basket");
                scoring.resetDifficulty();
                if (counter < 6)
                {
                    if (counter == 5)
                    {
                        gameOver = true;
                    }
                    showText(counter, letters);
                    counter = counter + 1;
                }
                Shooter.shootInterval = 1f;
  
                Throw.thrown = false;
                Scoring.scored = false;
            }
        }
    }


    public void showText(int num, TMP_Text[] arr)
    {
        TMP_Text letter = arr[num];
        //Debug.Log(letter.alpha);
        letter.alpha = 255;
    }
}

