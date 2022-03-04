using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    [SerializeField] public int controlCol;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("Top"))
        {
            Debug.Log("123");
            controlCol = 1;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Top"))
        {
            controlCol = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
