using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTilemap : MonoBehaviour
{
    [SerializeField] private float speed = -7f;

    private Rigidbody2D rb2d;
    public GameObject collX;
    private ColX colX_script;
    public GameObject collL;
    private ColL colL_script;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        colX_script = collX.GetComponent<ColX>();
        colX_script = collX.GetComponent<ColX>();
        colL_script = collL.GetComponent<ColL>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && colX_script.colOnX == 0)
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && colL_script.colOnL == 0)
        {
            rb2d.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }
}
  
    
