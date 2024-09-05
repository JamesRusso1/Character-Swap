using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public Rigidbody2D rb;

    public bool RedMove;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //make sure one player's bool starts true and the other false
        RedMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Character Swap
        if (Input.GetMouseButtonDown(0))
        {
            RedMove = !RedMove;
        }

        if (RedMove == true)
        {
            //horizontal motion
            float x = (Input.GetAxis("Horizontal") * speed);
            transform.position += new Vector3(x * Time.deltaTime, 0f, 0f);

            //jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, jumpForce));
            }
        }

        

    }
}
