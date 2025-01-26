using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    BoxCollider2D playerCollider;
    Rigidbody2D playerRigidBody;

    [SerializeField]
    GameObject[] floor;

    [SerializeField]
    float acceleration = 3.5f;
    [SerializeField]
    float jumpPower = 0.05f;
    Vector2 jump = new Vector2(0, 2);

    bool isGrounded = false;
    [SerializeField] TextMeshProUGUI lives;
    public int Lives = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = player.GetComponent<BoxCollider2D>();
        playerRigidBody = player.GetComponent<Rigidbody2D>();
        floor = GameObject.FindGameObjectsWithTag("Ground");

    }

    // Update is called once per frame
    void Update()
    {
        lives.text = string.Format($"Lives: {Lives}");



        for (int i = 0; i < floor.Length; i++)
        {
            if (playerCollider.IsTouching(floor[i].GetComponent<BoxCollider2D>()))
            {
                playerRigidBody.velocity = Vector2.zero;
                isGrounded = true;
            }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Restart"))
        {
            gameObject.transform.position = new Vector2(-1.7F, 0.47F);
            Lives -= 1;
        }
    }
}
