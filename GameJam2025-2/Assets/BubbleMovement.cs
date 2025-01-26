using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject PoolManager;
    public GameObject BubblePreFab;
    BubbleSpawn bubbleSpawner; 
    int spawnCounter = 0;
    public float y;
    public float despawnHeight;
    
    //public GameObject DeSpawner;
    // Start is called before the first frame update
    void Start()
    {
        PoolManager = GameObject.FindGameObjectWithTag("anything");
        bubbleSpawner = PoolManager.GetComponent<BubbleSpawn>();
        BubblePreFab.transform.position = bubbleSpawner.SpawnPosition;
        y = BubblePreFab.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        BubblePreFab.transform.position = new Vector2(BubblePreFab.transform.position.x , y/150);

        y++;

        if (y >= despawnHeight)
        {
            BubblePreFab.SetActive(false);
            y = -10;
        }
        if (!BubblePreFab.activeSelf)
        {
            y = -10;
        }
    }
}
