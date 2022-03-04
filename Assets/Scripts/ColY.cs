using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColY : MonoBehaviour
{
    [SerializeField] public int colOnY;
    private bool collided;
    // Start is called before the first frame update

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
        colOnY = 1;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        collided = false;
        colOnY = 0;
    }

    // Update is called once per frame
    public void OnUpdate()
    {
        Debug.Log('d');
        if (collided)
        {
            colOnY = 1;
            Debug.Log('b');
        }
        else
        {
            colOnY = 0;
            Debug.Log('c');
        }
    }


}
