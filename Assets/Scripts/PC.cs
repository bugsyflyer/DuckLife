using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D playerRb;
    private GameObject player;
    public float jumpForce = 10;
    public float gravityModifier = 1f;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if ((playerRb.transform.position.y !< 0.2 && playerRb.transform.position.y !> 0.2)){
            playerRb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        }
        else {
            if (Input.GetKeyDown(KeyCode.UpArrow)){
                if (playerRb.velocity.y == 0){
                    playerRb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
                    playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }; 
            } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                if (playerRb.velocity.y == 0){
                    playerRb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
                    playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
            }
            else {
                playerRb.constraints = RigidbodyConstraints2D.FreezePositionY;   
            }

        };
        if (playerRb.transform.position.y < -0.2){
            playerRb.AddForce(-Physics.gravity, ForceMode2D.Force);
        }

    }

// water is opposite to gravity
    

}