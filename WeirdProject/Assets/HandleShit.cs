using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleShit : MonoBehaviour
{
    private Rigidbody2D rb;

    private GameObject player;

    float moveSpeed = 10f;

    Vector2 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Airplane");
        moveDir = (player.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bubble")
        {
            moveSpeed += 1f;
        }
        Destroy(gameObject);
    }
}
