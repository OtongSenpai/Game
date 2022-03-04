using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColL : MonoBehaviour
{
    [SerializeField] public int colOnL;
    private bool collided;
    // Start is called before the first frame update

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
        colOnL = 1;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        collided = false;
        colOnL = 0;
    }

    // Update is called once per frame
    public void OnUpdate()
    {
        Debug.Log('d');
        if (collided)
        {
            colOnL = 1;
            Debug.Log('b');
            
        }
        else
        {
            colOnL = 0;
            Debug.Log('c');
        }
    }

}
