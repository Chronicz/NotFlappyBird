using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    //var
    public GameManager gameManager;
    private float velocity = 2;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameStatus)
            if (Input.GetMouseButtonDown(0))
            {
                //Flap
                rb.velocity = Vector2.up * velocity;
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }

    public void toggleGravityOn()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }

    public void toggleGravityOff()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    public void gameReset()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
