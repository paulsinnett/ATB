using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
	public int speed = 10;
	float initiative = 0.0f;

	void Update()
	{
		initiative += speed * Time.deltaTime;
	}
}
