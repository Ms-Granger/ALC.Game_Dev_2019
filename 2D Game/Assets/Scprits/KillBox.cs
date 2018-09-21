using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillBox : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D other){

		if(other.name == "Hero PC")
		{
			Debug.Log("Player Enters Kill Zone");
			Destroy(other);
		}
	}
	
}
