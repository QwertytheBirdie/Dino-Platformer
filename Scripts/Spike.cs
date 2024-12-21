using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float speed = 7f;
    public Rigidbody2D RGB;
    // Start is called before the first frame update
    void Start()
    {
       RGB = GetComponent<Rigidbody2D>();
        RGB.velocity = new Vector3(speed,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
