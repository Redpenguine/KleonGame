using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    private Vector2 direction;
    
    private Rigidbody2D playerRigidbody;
    private Transform player;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
        playerRigidbody = FindObjectOfType<PlayerMovement>().GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0);
        
    }

    void FixedUpdate()
    {
        playerRigidbody.MovePosition(playerRigidbody.position + direction * Time.deltaTime);
    }
    
}
