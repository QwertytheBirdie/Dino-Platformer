using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float Timer = 0;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Debug.Log("M<");


        Timer += Time.deltaTime;

        if (Timer > 2)
        {
            Timer = 0f;
            Instantiate(objectToSpawn, new Vector3(100, 0, 0), Quaternion.identity);
        }
    }
}

//spawn object
//wait 3 seconds
//reset timer
//Instantiate is Spawner