using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {


	public GameObject door;

	public void OnKeyClicked(){
		door.GetComponent<Door> ().Unlock ();
		Destroy (gameObject);
	}
	}
