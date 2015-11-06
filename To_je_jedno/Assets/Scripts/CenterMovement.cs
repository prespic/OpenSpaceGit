using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CenterMovement : MonoBehaviour
{
	private GameObject center;
	private List<GameObject> players = new List<GameObject>();
	private int cameraHeight;

	void Start()
	{
		cameraHeight = Camera.main.pixelHeight;
		center = GameObject.Find("/GameCenter");
		for (int i = 1; i <= 4; i++)
		{
			players.Add(GameObject.Find("/F-302_" + i));
		}
	}

	void Update()
	{
		Vector3 calculatedPosition = new Vector3(0.0f, 0.0f, 0.0f);
		float min = players.Min(p => p.transform.position.z);
		float max = players.Max(p => p.transform.position.z);

		calculatedPosition.z = max;

		center.transform.position = calculatedPosition;
	}
}
