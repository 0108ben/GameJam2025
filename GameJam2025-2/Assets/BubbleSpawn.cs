using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{
    [SerializeField]
    public Vector2 SpawnPosition = new Vector2();
    public GameObject BubblePreFab;
    public int spawnCounter = 0;
    [SerializeField]
    float despawnHeight = 1453.5f;
    [SerializeField]
    float spawnTime = 1200;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter++;
        if (spawnCounter >= spawnTime)
        {
            Spawn();
            spawnCounter = 0;
        } 
        
    }

    public void Spawn()
    {
        
        GameObject Bubble = PoolManager.instance.GetPooledObject();

        if (Bubble != null)
        {
            Bubble.GetComponent<BubbleMovement>().despawnHeight = despawnHeight;
            Bubble.transform.position = SpawnPosition;
            Bubble.gameObject.SetActive(true);
        }
    }

    
}
