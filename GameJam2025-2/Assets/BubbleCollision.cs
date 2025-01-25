using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCollision : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<BoxCollider2D>().IsTouching(this.gameObject.GetComponent<CircleCollider2D>()))
        {
            if (!Input.GetKey(KeyCode.Space))
            {
                Player.transform.position = this.gameObject.transform.position;
            }
            Player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.transform.position = this.gameObject.transform.position;
        }
        
    }
}
