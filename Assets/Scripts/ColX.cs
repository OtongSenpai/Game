using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColX : MonoBehaviour
{
    [SerializeField] public int colOnX;
    private bool collided;
    // Start is called before the first frame update

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
        colOnX = 1;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        collided = false;
        colOnX = 0;
    }

    // Update is called once per frame
    public void OnUpdate()
    {
        Debug.Log('d');
        if (collided)
        {
            colOnX = 1;

        }
        else
        {
            colOnX = 0;
            Debug.Log('c');
        }
    }

}
