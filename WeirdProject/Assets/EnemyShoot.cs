using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject checkpoint1;
    [SerializeField] private GameObject checkpoint2;

    private string movetowards;
    // Start is called before the first frame update
    void Start()
    {
        movetowards = "Checkpoint2";
    }

    // Update is called once per frame
    void Update()
    {
        if(movetowards == "Checkpoint2")
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, checkpoint2.transform.position, 4f * Time.deltaTime);
        }
        else if(movetowards == "Checkpoint1")
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, checkpoint1.transform.position, 4f * Time.deltaTime);
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.name == "Checkpoint1")
        {
            movetowards = "Checkpoint2";
            gameObject.GetComponent<SpriteRenderer>().flipX = false;


        }
        else if(col.gameObject.name == "Checkpoint2")
        {
            movetowards = "Checkpoint1";
            gameObject.GetComponent<SpriteRenderer>().flipX = true;


        }
    }
}
