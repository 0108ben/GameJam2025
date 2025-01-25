using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;
    private List<GameObject> pooledMetal = new List<GameObject>();
    [SerializeField] public GameObject cubePrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++) //Create 30 inactive sprites
        {
            GameObject obj = Instantiate(cubePrefab);
            obj.SetActive(false);
            //obj.transform.position = new Vector2(0, -10);
            pooledMetal.Add(obj); //Add all pooledObjects to list
        }

    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledMetal.Count; i++)
        {
            if (!pooledMetal[i].activeInHierarchy) //If cube
            {
                return pooledMetal[i];
            }
        }
        return null;
    }

}