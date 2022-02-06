using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 moveInput;
    private PlayerCamera playerCam;
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 4f;

    private void awake() {
      rb = GetComponent<Rigidbody>();
      print(gameObject);
      playerCam = FindObjectOfType<PlayerCamera>();
    }


    private void FixedUpdate()
    {
        // Move player.
        MovePlayer();
    }


    // Update is called once per frame
    private void Update()
    {
      moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

      if(Input.GetKeyDown(KeyCode.Space)) {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      }
    }

    // Move Player
    private void MovePlayer()
    {
      rb.velocity = new Vector3(moveInput.x * speed, rb.velocity.y, moveInput.z * speed);
    }
}
