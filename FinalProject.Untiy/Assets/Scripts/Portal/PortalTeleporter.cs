using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{

	public Transform player;
	public Transform reciever;
	public Transform PortalA; 
	[SerializeField] bool playerIsOverlapping = true;

	 
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			player = other.transform;
			playerIsOverlapping = true; 
			player.position = PortalA.position;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			player = other.transform;
			playerIsOverlapping = false;
		}
	}
}