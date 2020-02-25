using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTime = -0.3f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time-lastTime>0.3)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastTime = Time.time; 
        }
    }
}
