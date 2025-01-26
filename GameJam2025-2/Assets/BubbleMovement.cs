using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public GameObject PoolManager;
    public GameObject BubblePreFab;
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
        Despawner = PoolManager.GetComponent<BubbleSpawn>().Despawner;
        bubbleSpawner = PoolManager.GetComponent<BubbleSpawn>();
        BubblePreFab.transform.position = bubbleSpawner.SpawnPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= Physics.gravity * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision);
        if (collision.gameObject.CompareTag("DeSpawn"))
        {
            BubblePreFab.SetActive(false);
        }
    }
}
