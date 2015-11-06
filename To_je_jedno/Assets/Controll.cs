using UnityEngine;
using System;

public class Controll : MonoBehaviour {
    private float maxTurn = 2F;
    private float speed = 0.1F;
    private Vector3 direction = new Vector3(0, 0, 0.1F);

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
        var p = speed / Math.Sqrt(direction.x * direction.x + direction.z * direction.z);

        direction.x += Input.GetAxis("Horizontal") * speed;

        if (direction.x > speed * maxTurn)
        {
            direction.x = speed * maxTurn;
        }
        if (direction.x < -(speed * maxTurn))
        {
            direction.x = -(speed * maxTurn);
        }
        transform.Translate(direction * (float) p);
	}

    void OnCollisionEnter(Collision collision)
    {
        direction = new Vector3();
    }
}
