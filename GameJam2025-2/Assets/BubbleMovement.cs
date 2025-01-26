using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject PoolManager;
    public GameObject BubblePreFab;
    Rigidbody2D bubbleRigidbody2D;
    BubbleSpawn bubbleSpawner; 
    int spawnCounter = 0;
    public float timer;
    public float despawnHeight;
    
    //public GameObject DeSpawner;
    // Start is called before the first frame update
    void Start()
    {
        PoolManager = GameObject.FindGameObjectWithTag("anything");
        bubbleSpawner = PoolManager.GetComponent<BubbleSpawn>();
        BubblePreFab.transform.position = bubbleSpawner.SpawnPosition;
        bubbleRigidbody2D = BubblePreFab.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        bubbleRigidbody2D.gravityScale = -0.5f;

        if (timer >= despawnHeight)
        {
            BubblePreFab.SetActive(false);
            timer = 0;
        }
    }
}
