using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject PoolManager;
    public GameObject BubblePreFab;
    int spawnCounter = 0;
    float y;
    
    //public GameObject DeSpawner;
    // Start is called before the first frame update
    void Start()
    {
        PoolManager = GameObject.FindGameObjectWithTag("anything");
        BubblePreFab.transform.position = PoolManager.GetComponent<BubbleSpawn>().SpawnPosition;
        y = BubblePreFab.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        BubblePreFab.transform.position = new Vector2(BubblePreFab.transform.position.x , y/150);
        y++;

        if (y >= 1453.5F)
        {
            BubblePreFab.SetActive(false);
            y = -10;
        }   
    }
}
