using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    
      
    }
    public bool isOnGround = true; 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && isOnGround)
        {
            playerRb.AddForce(Vector3.up *jumpForce, ForceMode.Impulse);
        } 
    }
}
