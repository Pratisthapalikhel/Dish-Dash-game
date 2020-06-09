using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour {

	private float size;

	[SerializeField]
	GameObject Platform;

	[SerializeField]
	GameObject Soap;

	Vector3 lastpos;


	void Start () {
		size = Platform.transform.localScale.x;
		lastpos = Platform.transform.position;
		InvokeRepeating ("SpawnPlatform", 2f, 0.2f);
	}

	

	void Update () {
		
	}

	private void SpawnPlatform(){
		int random = Random.Range (0, 6);
		int soaprandom = Random.Range (0, 7);
		if (random < 3)
			SpawnX ();
		if (random >= 3)
			SpawnZ ();
		if (soaprandom < 2)
			SpawnSoap ();
	}

	private void SpawnSoap(){
		Instantiate (Soap, lastpos + new Vector3 (0f, 2f, 0f), Soap.transform.rotation);
	}

	private void SpawnX(){
		GameObject _platform = Instantiate (Platform) as GameObject;
		_platform.transform.position = lastpos + new Vector3 (size, 0f, 0f);
		lastpos = _platform.transform.position;
	}

	private void SpawnZ(){
		GameObject _platform = Instantiate (Platform) as GameObject;
		_platform.transform.position = lastpos + new Vector3 (0f, 0f, size);
		lastpos = _platform.transform.position;
	}
}
