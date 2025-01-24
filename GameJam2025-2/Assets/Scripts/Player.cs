using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    BoxCollider2D playerCollider;

    [SerializeField]
    GameObject floor;
    BoxCollider2D floorCollider;

    [SerializeField]
    float acceleration = 3.5f;
    [SerializeField]
    float jumpPower = 0.5f;
    Vector2 jump = new Vector2(0, 2);

    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = player.GetComponent<BoxCollider2D>();
        floorCollider = floor.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollider.IsTouching(floorCollider))
        {
            isGrounded = true;
        }


        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {

            player.GetComponent<Rigidbody2D>().AddForce(jump * jumpPower, ForceMode2D.Impulse);
            isGrounded = !isGrounded;
        }
    }
}
