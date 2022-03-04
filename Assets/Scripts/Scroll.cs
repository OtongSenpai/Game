using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private float speed = -6;
    [SerializeField] private bool collider = false;
    private float width;
    private bool isDash;
    public float time;
    public float timer;
    private float direction;
    public int dashPower;

    private BoxCollider2D box2d;
    private Rigidbody2D rb2d;
    
    public GameObject collX;
    private ColX colX_script;
    public GameObject collL;
    private ColL colL_script;

    // Start is called before the first frame update
    private void Start()
    {
        box2d = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        colX_script = collX.GetComponent<ColX>();
        colL_script = collL.GetComponent<ColL>();
        
        width = box2d.size.x;
        box2d.enabled = collider;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && colX_script.colOnX == 0)
        {
            rb2d.velocity = new Vector2(speed, 0);
            if (transform.position.x < -width)
            {
                RepositionR();
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && colL_script.colOnL == 0)
        {
            rb2d.velocity = new Vector2(-speed, 0);
            if (transform.position.x > width)
            {
                RepositionL();
            }
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }
    }

    private void RepositionR()
    {
        Vector2 pos = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + pos;
    }
    private void RepositionL()
    {
        Vector2 pos = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position - pos;
    }
}
  
    
