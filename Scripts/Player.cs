using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool Jump;
    public float JumpSpeed;
    AudioSource JumpSound;
    // Start is called before the first frame update
    void Start()
    {
        JumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 0, (int)1f);
        if(hit.collider!=null)
        {
            Jump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Jump==false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, JumpSpeed, 0);
            Jump = true;
        }
        JumpSound.Play();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

