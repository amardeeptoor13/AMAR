using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyRing : MonoBehaviour {

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public GameObject obstacle;
    bool oneTine = true;
    public AudioClip clip;
    private AudioSource source;
    float timer = 0f;

    MainBall ball;
	// Use this for initialization
	void Start () {

        ball = GameObject.Find("MainBall").GetComponent<MainBall>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "MainBall")
        {
            if (image6!=null)
            {
                Destroy(image6);
            }
            else if (image5!=null)
            {
                Destroy(image5);
            }
            else if (image4 != null)
            {
                Destroy(image4);
            }
            else if (image3 != null)
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
                Destroy(obstacle);
            }

            if (oneTine)
            {
                ball.ScoreUpdate(50);
                oneTine = false;
            }
            source.PlayOneShot(clip);


            Destroy(this.gameObject);

           
           
            
        }
    }
}
