using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public KeyCode upKey; 
    public KeyCode downKey;
    public Color playercolor;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
       rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = playercolor;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            rigidbody2D.velocity = Vector2.up * speed;
        }
        
        else if(Input.GetKey(downKey) && transform.position.y > -5)
        {
            rigidbody2D.velocity = Vector2.down * speed;
        }

        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
