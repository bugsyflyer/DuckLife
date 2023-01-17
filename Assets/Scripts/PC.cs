using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D playerRb;
    private GameObject player;
    public float jumpForce = 5;
    public float gravityModifier = 1f;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            if (playerRb.velocity.y == 0){
                playerRb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
                playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        };
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            if (playerRb.velocity.y == 0){
                playerRb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
                playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        };
        
        if (playerRb.transform.position.y < 0.1){
            playerRb.AddForce(-Physics.gravity, ForceMode2D.Force);
        }
        else {
            playerRb.constraints = RigidbodyConstraints2D.FreezePositionY;  
        } ;

    }

// water is opposite to gravity
    

}