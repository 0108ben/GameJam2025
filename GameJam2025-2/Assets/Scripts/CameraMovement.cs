using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    GameObject player;
    GameObject camera;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = player.transform.position + new Vector3(0, 1, 0);
    }
}
