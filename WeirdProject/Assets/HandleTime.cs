using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleTime : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI time;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer>=0f)
        {
            time.text = "Time Left: " + (int)timer;

        }
    }
}
