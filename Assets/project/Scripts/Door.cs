using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	bool locked = true;
	bool closed = true;

	void Update(){
		if (!locked && !closed && transform.position.y < 23.2f) {
			transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
		}

	}

	public void Unlock()
	{


		locked = !locked;
	}

	public void openDoor(){
		if (!locked) {
			closed = !closed;
		}



	}
	
}
