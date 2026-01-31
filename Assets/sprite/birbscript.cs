using System.Collections; 
using System.Collections.Generic;   
using UnityEngine;

public class birbscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapstrength;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Tambahkan Rigidbody2D ke objek ini!");
            return;
        }
        gameObject.name = "Sujatmiko Arafuru";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && rb != null)
        {
            rb.linearVelocity = Vector2.up * flapstrength ;
        }
    }
}
