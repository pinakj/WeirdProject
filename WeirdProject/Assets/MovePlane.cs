using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovePlane : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject shit;
    [SerializeField] private Transform shitPos;
    [SerializeField] private float delaybetweenShits;
    [SerializeField]
    private TextMeshProUGUI hpText;

    private int hp;
    private float lastShit;
    // Start is called before the first frame update
    void Start()
    {
        delaybetweenShits = 0.35f;
        lastShit = Time.time;
        hp = 10;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastShit > delaybetweenShits)
            {
                lastShit = Time.time;
                Instantiate(shit,new Vector3(shitPos.position.x,shitPos.position.y,shitPos.position.z),Quaternion.identity);
               
            }
        }
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.transform.position += Vector3.right * -speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<BoxCollider2D>(), col);

        }
        else if(col.gameObject.tag == "Enemy")
        {
            hp -= 1;
            hpText.text = "Health: " + hp;
        }
    }
}
