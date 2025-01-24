using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject BubblePreFab;
    int spawnCounter = 0;
    public float x = 0;
    public float y = -10;
    //public GameObject DeSpawner;
    // Start is called before the first frame update
    void Start()
    {
        BubblePreFab.transform.position = new Vector2(x, -10);

    }

    // Update is called once per frame
    void Update()
    {
        BubblePreFab.transform.position = new Vector2(x, y/150);
        y++;

        if (y >= 1453.5F)
        {
            BubblePreFab.SetActive(false);
            y = -10;
        }   
    }
}
