using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float cooldownTime = 2;
    private float nextFireTime = 0;


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextFireTime = Time.time + cooldownTime;
            }
        }


    }
}
