using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    Rigidbody2D rb2d;

    private Rigidbody2D charcterRb2d;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        charcterRb2d = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(0, charcterRb2d.velocity.y);
        rb2d.position = new Vector2(-3.79f, charcterRb2d.position.y);
    }
}
