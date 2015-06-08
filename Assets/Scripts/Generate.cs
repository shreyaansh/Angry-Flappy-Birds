using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	// Use this for initialization
	public GameObject rocks;
	void Start () {
		InvokeRepeating ("CreateObstacle", 1.5f, 1.5f);
	}

	void CreateObstacle () {
		Instantiate (rocks);
	}
}