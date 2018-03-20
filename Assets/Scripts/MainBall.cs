using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainBall : MonoBehaviour {
    public Rigidbody2D rb;
    bool isGrounded;
    float scoreValue = 0;
    public Text ScoreBoard;

    public Image image1;
    public Image image2;
    public Image image3;
    // Use this for initialization
    void Start () {
       
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;

    }

    public void ScoreUpdate(int sc) {

        scoreValue += sc;
    }
	
	// Update is called once per frame
	void Update () {

        ScoreBoard.text = "Scores = "+ scoreValue;
        
        if (Input.GetButton("Left"))
        {
            transform.Translate(-Vector2.right  *5.3f* Time.deltaTime);
          
        }
        if (Input.GetButton("Right"))
        {
            transform.Translate(Vector2.right  *5.3f* Time.deltaTime);
           
        }
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0, 55f));

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("walls"))
        {
            isGrounded = true;
          
        }
        if (col.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            print("enter");
            if (image3 != null)
            {
                Destroy(image3);
               
            }
            else if (image2 != null)
            {
                Destroy(image2);
               
            }
            else if (image1 != null)
            {
                Destroy(image1);
              
            }
            else
            {
                Destroy(gameObject);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            

        }


    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("walls"))
        {
            isGrounded = false;
         
        }
    }




}
