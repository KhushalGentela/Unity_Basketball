using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    private bool shooting = false;
    public static float shootInterval = 1f;
    public Transform basket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startShooting()
    {
        if (!shooting)
        {
            shooting = true;
            StartCoroutine(ShootContinuously());
        }
    }
    public void stopShooting()
    {
        Debug.Log("STOP SHOOTING NOW!!!");
        shooting = false;
    }
    private IEnumerator ShootContinuously()
    {
        while (shooting)
        {
            Shoot();
            yield return new WaitForSeconds(shootInterval);
        }
    }
    void Shoot()
    {
        GameObject ballClone = Instantiate(ball, transform.position, Quaternion.identity);
        Destroy(ballClone, 3f);
        ballClone.transform.LookAt(basket.position + new Vector3(1, 0, 0));
        Vector3 direction = (basket.position - transform.position).normalized;
        Rigidbody rb = ballClone.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(direction * 7f, ForceMode.Impulse);
        }
        
    }
}

