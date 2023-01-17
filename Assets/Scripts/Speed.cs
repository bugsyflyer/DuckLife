using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    const float SPEED_INCREASE_INTERVAL = 3f; // how often do you want the speed to change
    const float SPEED_CHANGE = 1; // how much do you want the speed to change 
    float _IntervalTimer = SPEED_INCREASE_INTERVAL;
    private float speed = 1;

    public GameObject regidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate () 
    {
        _IntervalTimer -= Time.deltaTime;
            if (_IntervalTimer < 0)
            {
                speed -= SPEED_CHANGE;
  
                Vector2 velocity = new Vector2(speed, 0);
                GetComponent<Rigidbody2D>().velocity = velocity;
  
                //Destroy(gameObject,destroyTime);
                _IntervalTimer = SPEED_INCREASE_INTERVAL;
            }
            
    }
}
