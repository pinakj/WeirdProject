using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTransparency : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
        tmp.a = 0.5f;
        gameObject.GetComponent<SpriteRenderer>().color = tmp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Instantiate(bullet, gameObject.transform);
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
