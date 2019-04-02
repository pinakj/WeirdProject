using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killyoself : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name != "Airplane")
        {
            Destroy(gameObject);
        }
        print(col.name);
    }
}
