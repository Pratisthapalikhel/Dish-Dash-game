using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

	[SerializeField]
	Transform miniplayer;

	Vector3 offset;

	void Start () {
		offset = miniplayer.transform.position - this.transform.position;
		
	}
	

	void Update () {
		if (miniplayer.gameObject.GetComponent<miniplayer> ().canmove) {
			Vector3 Requiredpos = miniplayer.transform.position - offset;
			this.transform.position = Vector3.Lerp (this.transform.position, Requiredpos, 1.5f);
		}
	}
}
