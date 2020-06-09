using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	[SerializeField]
	Transform Player;

	Vector3 offset;

	void Start () {
		offset = Player.transform.position - this.transform.position;

	}


	void Update () {
		Vector3 Requiredpos = Player.transform.position - offset;
		this.transform.position = Vector3.Lerp (this.transform.position, Requiredpos, 1.5f);
	}
}
