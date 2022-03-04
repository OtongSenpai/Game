using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            SceneManager.LoadScene(0);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
