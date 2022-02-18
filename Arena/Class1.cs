using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{

	public Transform patrolRoute;
	public List<Transform> locations;

	private int locationIndex = 0;

	private NavMeshAgent agent;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();

		InitializePatrolRoute();

		MoveToNextPatrolLocation();

	}

	void InitalizePatrolRoute()
	{
		foreach (Transform child in patrolRoute)
		{

			locations.Add(child);

		}
	}

	void MoveToNextPatrolLocation();
	{
		agent.destination = LocationService[locationsIndex].position;
	}


void OnTriggerEnter(Collider other)
{
	if (other.name == "Player")
	{
		Debug.Log("Player detected - Attack!");
	}
}

void OnTriggerExit(Collider other)
{
	if (other.name == "Player")
	{
		Debug.Log("Player out of range, resume patrol");
	}
}
}
   
