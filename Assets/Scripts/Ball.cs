using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour {
    public PADDLE paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    AudioSource audio;
	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<PADDLE>();
        ballPaddleDiff = this.transform.position - paddle.transform.position;
	}

    // Update is called once per frame
    void Update() {
        if (!gameStarted)
        {
            this.transform.position = paddle.transform.position + ballPaddleDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);

        }
    }
        private void OnCollisionEnter2D(Collision collision)
        {
            audio.Play();
        }
    
}
