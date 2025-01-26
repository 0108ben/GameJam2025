using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject PoolManager;
    public GameObject BubblePreFab;
    Rigidbody2D bubbleRigidbody2D;
    public GameObject Despawner;
    BubbleSpawn bubbleSpawner; 
    int spawnCounter = 0;
    public float timer;
    public float despawnHeight;
    
    //public GameObject DeSpawner;
    // Start is called before the first frame update
    void Awake()
    {
        PoolManager = GameObject.FindGameObjectWithTag("anything");
        bubbleSpawner = PoolManager.GetComponent<BubbleSpawn>();
        Despawner = bubbleSpawner.Despawner;
        BubblePreFab.transform.position = bubbleSpawner.SpawnPosition;
        bubbleRigidbody2D = BubblePreFab.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bubbleRigidbody2D.gravityScale = -0.5f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision);
        if (collision.gameObject.CompareTag("DeSpawn"))
        {
            bubbleRigidbody2D.velocity = Vector3.zero;
            BubblePreFab.SetActive(false);
        }
    }
}
