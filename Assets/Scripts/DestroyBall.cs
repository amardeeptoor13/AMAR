using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  

public class DestroyBall : MonoBehaviour {

      public Image image1;
      public Image image2;
    public Image image3;
	// Use this for initialization
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "MainBall")
        {
            if (image3!= null)
            {
                Destroy(image3);

            }
            else if (image2!=null )
            {
                Destroy(image2);
            }
            else if (image1 != null)
            {
                Destroy(image1);
            }
            else
            {
                SceneManager.LoadScene("GameOver");
                Destroy(col.gameObject);


            }

            Destroy(gameObject);
            


        }
    }
}
