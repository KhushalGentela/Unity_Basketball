using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Throw : MonoBehaviour
{
    // Start is called before the first frame update
    public float vmultiplier = 1.5f;
    public float amultiplier = 1.0f;

    public GameObject obj;
    private GameObject clone;
    public static bool thrown = false;
    public static bool initial = true;
    public XRGrabInteractable interactable;

    void Start()
    {

        interactable.selectEntered.AddListener(OnGrab);
        interactable.selectExited.AddListener(OnRelease);
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.position.y < 0)
        {
            obj.transform.position = new Vector3(0, 1, 1);
        }
    }


    private void OnRelease(SelectExitEventArgs arg)
    {
        thrown = true;
        //Debug.Log("Thrown the baaa");
    }
    private void OnGrab(SelectEnterEventArgs arg)
    {
        thrown = false;
        Scoring.scored = false;
        //Debug.Log("Held The Ball");
    }
 
    private void onDestroy()
    {
        if (interactable != null)
        {
           // Debug.Log("Grabbed Object and released gah damn");
            interactable.selectEntered.RemoveListener(OnGrab);
            interactable.selectExited.RemoveListener(OnRelease);
        }

    }
}

