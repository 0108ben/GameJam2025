using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour
{
    public GameObject BubblePreFab;
    public int spawnCounter = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter++;
        if (spawnCounter >= 700)
        {
            Spawn();
            spawnCounter = 0;
        } 
        
    }

    public void Spawn()
    {
        Vector3 SpawnPos = new Vector3(0, -10, 0);
        GameObject Bubble = PoolManager.instance.GetPooledObject();


        if (Bubble != null)
        {
            Bubble.transform.position = SpawnPos;
            Bubble.gameObject.SetActive(true);
        }
    }

    
}
