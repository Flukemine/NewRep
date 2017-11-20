using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
    public int maxHits;
    int timesHit;
	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collsion)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);

        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
    }
}
