using UnityEngine;
using System;
using System.Collections;

public class Controll : MonoBehaviour {

    private float speed = 0.1F;
    private Vector3 direction = new Vector3(0, 0, 0.1F);

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        var p = speed / Math.Sqrt(direction.x * direction.x + direction.z * direction.z);
        var player = GameObject.FindWithTag("Player");

        direction.x += Input.GetAxis("Horizontal") * speed;

        if (direction.x > speed)
        {
            direction.x = speed;
        }
        if (direction.x < -speed)
        {
            direction.x = -speed;
        }
        player.transform.Translate(direction * (float) p);
	}
}
