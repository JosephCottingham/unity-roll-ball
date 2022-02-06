using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] private GameObject player;
    private Vector3 cameraOffset;

    private void awake()
    {
      //player = FindObjectOfType<PlayerMove>().gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
      cameraOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = cameraOffset + player.transform.position;
        Quaternion.LookRotation(player.transform.position - transform.position);
    }
}
