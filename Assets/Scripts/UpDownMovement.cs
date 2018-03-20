using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpDownMovement : MonoBehaviour {

    Rigidbody2D r;
    float y;
    float speed;
    // Use this for initialization
    void Start()
    {
        y = transform.position.y;
        r = GetComponent<Rigidbody2D>();
       

        speed = Random.Range(1,5);

    }

    // Update is called once per frame
    void Update () {
        
        if (transform.position.y >= y)
        {
            
            r.velocity = Vector2.down*speed;
        }
         else if (transform.position.y <= y-2.4)
        {
         
            r.velocity = Vector2.up*speed;
        }
       
    }

    
}
