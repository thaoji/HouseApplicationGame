using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLVL2 : MonoBehaviour
{
	//A reference to the game manager
	public Transform Player;
	public Transform RP;

	// When an object enters the finish zone, let the
	// game manager know that the current game has ended


	void OnTriggerEnter(Collider other)
	{
		Player.transform.position = RP.transform.position;

	}
}
