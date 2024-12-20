using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Scoring : MonoBehaviour
{
    public TMP_Text score;
    public ParticleSystem confetti1;
    public TMP_Text[] letters;
    public GameObject gameOver;

    public static bool scored = false;
    public Shooter cubes;
    public Shooter cubes1;
    private Vector3 orims = new Vector3();
    private int indexer = 1;


    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        gameOver.SetActive(false);
        ParticleSystem.EmissionModule emission1;
        emission1 = confetti1.emission;
        if (emission1.enabled)
        {
            emission1.enabled = false;

        }
        if (audioSource.enabled)
        {
            audioSource.enabled = false;
        }
        Transform rim = transform.Find("Cylinder.016");
      //  Transform net = transform.Find("Cylineder.0.03");
       // orimp = rim.localPosition;
        orims = rim.localScale;
       // onetp = net.localPosition;
       // onets = net.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Reset.gameOver == true)
        {

            for (int i = 0; i < 6; i++)
            {
                TMP_Text letter = letters[i];
                letter.alpha = 0;
            }
            StartCoroutine(celebration());
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Ball"))
        {
            Debug.Log("triggered by: " + other.gameObject.tag + " : and name " + other.gameObject.name);
        
 
            scored = true;
            int curScore = int.Parse(score.text) + 1;
            score.text = curScore.ToString();
            //showText(curScore - 1, letters);
            enableDifficulty();

        }
  


    }

    IEnumerator celebration()
    {
        ParticleSystem.EmissionModule emission1;
        emission1 = confetti1.emission;

        if (!emission1.enabled && !audioSource.enabled)
        {

            emission1.enabled = true;
            audioSource.enabled = true;

        }

        yield return new WaitForSeconds(5);
        gameOver.SetActive(true);
        emission1.enabled = false;
    }

    /*
    public void showText(int num, TMP_Text[] arr)
    {
        TMP_Text letter = arr[num];
        //Debug.Log(letter.alpha);
        letter.alpha = 255;
    } */

    private void enableDifficulty()
    {
        
        if (indexer == 1)
        {
            indexer = 2;
            multballs();
        } else
        {
            indexer = 1;
            rimSize();
        }

    }

    public void resetDifficulty()
    {
        Debug.Log(" This function is now called ");
        Transform rim = transform.Find("Cylinder.016");
        rim.localScale = orims;
        cubes.stopShooting();
        cubes1.stopShooting();
    }

    private void multballs()
    {
        Debug.Log(" Started Shooting ");
        Shooter.shootInterval = Shooter.shootInterval - 0.05f;
        cubes.startShooting();
        cubes1.startShooting();

    }



    private void rimSize()
    {
        Transform t = transform.Find("Cylinder.016");
        Vector3 currentScale = t.localScale;
        float scaleFactor = 0.9f;
        t.localScale = new Vector3(scaleFactor * currentScale.x, currentScale.y, scaleFactor * currentScale.z);
  //      Debug.Log(t.localScale);
    }

}

