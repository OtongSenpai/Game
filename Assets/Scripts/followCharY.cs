using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCharY : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;

    private Rigidbody2D charcterRb2d;
    public GameObject character;
    public GameObject cameraCon;
    private cameraControl cameraCon_script;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        cameraCon_script = cameraCon.GetComponent<cameraControl>();
        charcterRb2d = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraCon_script.controlCol == 1 && rb2d.position.y >= 1)
        {
            rb2d.velocity = new Vector2(0, charcterRb2d.velocity.y);
            
        }
        
        if (rb2d.position.y < 1)
        {
            rb2d.velocity = new Vector2(0, 0);
            rb2d.position = new Vector2(0, 1);
            Debug.Log("f4");
        }
    }
}
