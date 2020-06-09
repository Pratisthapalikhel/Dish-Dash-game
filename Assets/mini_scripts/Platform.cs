using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		Debug.Log ("Collision Function Entered");
		if (col.gameObject.tag == "miniplayer") {
			Debug.Log("Strike called");
			Invoke ("Strike", 0.7f);
		}
	}

	private void Strike(){
		this.GetComponentInParent<Rigidbody> ().isKinematic = false;
		Destroy (this.transform.parent.gameObject, 2f);
	}
}
