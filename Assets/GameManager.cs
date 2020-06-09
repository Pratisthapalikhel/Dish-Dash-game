using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private float size;

	[SerializeField]
	GameObject table1;

	[SerializeField]
	GameObject table2;

	[SerializeField]
	GameObject table3;

	[SerializeField]
	GameObject table4;

	[SerializeField]
	GameObject table5;

	[SerializeField]
	GameObject table6;

	[SerializeField]
	GameObject fridge;

	[SerializeField]
	GameObject filter;

	[SerializeField]
	GameObject rack1;

	[SerializeField]
	GameObject rack2;

	[SerializeField]
	GameObject rack3;

	[SerializeField]
	GameObject mirror1;

	[SerializeField]
	GameObject mirror2;

	[SerializeField]
	GameObject mirror3;

	[SerializeField]
	GameObject wallamp;

	[SerializeField]
	GameObject lamp;

	[SerializeField]
	GameObject catfood;

	[SerializeField]
	GameObject bcake;

	[SerializeField]
	GameObject toaster;

	[SerializeField]
	GameObject mwave;

	[SerializeField]
	GameObject milk;

	[SerializeField]
	GameObject sushi;

	[SerializeField]
	GameObject wineb;

	[SerializeField]
	GameObject desserts;

	[SerializeField]
	GameObject cheese;

	[SerializeField]
	GameObject chicken;

	[SerializeField]
	GameObject burger;

	[SerializeField]
	GameObject cake;

	[SerializeField]
	GameObject fruitbowl;

	[SerializeField]
	GameObject foodplate;

	[SerializeField]
	GameObject dishrack;

	[SerializeField]
	GameObject platestack;

	[SerializeField]
	GameObject bowlstack;

	[SerializeField]
	GameObject vase1;

	[SerializeField]
	GameObject vase2;

	[SerializeField]
	GameObject pancakes;

    [SerializeField]
    GameObject Platform;

    [SerializeField]
    GameObject Soap;

    Vector3 lastpos;


	void Start () {
        
            size = 5.25f;
            lastpos = table6.transform.position;
            for (int i = 0; i < 350; i++)
            {
                SpawnPlatform();
                //InvokeRepeating ("SpawnPlatform", 2f, 0.2f);

            }
       
           /* size = Platform.transform.localScale.x;
            lastpos = Platform.transform.position;
            InvokeRepeating("SpawnPlatform", 2f, 0.2f);

        //finish();*/
    }
   


	

	private void SpawnPlatform(){
        int random = Random.Range(0, 6);
		int objrandom1 = Random.Range (0, 20);
		int objrandom2 = Random.Range (0, 10);
		int randomdeco = Random.Range (0, 7);
        //int soaprandom = Random.Range(0, 7);
        /*if (random < 3)
            SpawnX();
        if (random >= 3)
            SpawnZ();
        if (soaprandom < 2)
            SpawnSoap();*/
        if (random == 1)
			Spawn1 ();
		if (random == 2)
			Spawn2 ();
		if (random == 3)
			Spawn3 ();
		if (random == 4)
			Spawn4 ();
		if (random == 5)
			Spawn5 ();
		if (random == 6)
			Spawn6 ();
		if (random < 2)
			Spawncatfood ();
		
		if (objrandom1 == 1)
			Spawnpancakes ();
		if (objrandom1 == 2)
			Spawnvase2 ();
		if (objrandom1 == 3)
			Spawnvase1 ();
		if (objrandom1 == 4)
			Spawnbowlstack ();
		if (objrandom1 == 5)
			Spawnplatestack ();
		if (objrandom1 == 6)
			Spawndishrack ();
		if (objrandom1 == 7)
			Spawnfoodplate ();
		if (objrandom1 == 8)
			Spawnfruitbowl ();
		if (objrandom1 == 9)
			Spawncake ();
		if (objrandom1 == 10)
			Spawnburger ();
		if (objrandom1 == 11)
			Spawnchicken ();
		if (objrandom1 == 12)
			Spawncheese ();
		if (objrandom1 == 13)
			Spawndesserts ();
		if (objrandom1 == 14)
			Spawnwineb ();
		if (objrandom1 == 15)
			Spawnsushi ();
		if (objrandom1 == 16)
			Spawnmilk ();
		if (objrandom1 == 17)
			Spawnmwave ();
		if (objrandom1 == 18)
			Spawntoaster ();
		if (objrandom1 == 19)
			Spawnbcake ();

		if (randomdeco <= 2)
			Spawnmirror1 ();
		if (randomdeco > 2 && randomdeco < 5)
			Spawnmirror2 ();
		if (randomdeco >= 5)
			Spawnmirror3 ();
		if (randomdeco <= 3)
			Spawnwallamp ();
		if (randomdeco >= 5)
			Spawnlamp ();
		if (randomdeco == 2 || randomdeco == 1)
			Spawnrack1 ();
		if (randomdeco == 3 || randomdeco == 4)
			Spawnrack2 ();
		if (randomdeco == 5 || randomdeco == 6)
			Spawnrack3 ();
		if (randomdeco <= 4)
			Spawnfridge ();
		if (randomdeco > 5)
			Spawnfilter ();
	}

	//TABLES***********************************************************************
	private void Spawn1(){
		GameObject _table1 = Instantiate (table1) as GameObject;
		_table1.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table1.transform.position;
	}

	private void Spawn2(){
		GameObject _table2 = Instantiate (table2) as GameObject;
		_table2.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table2.transform.position;
	}

	private void Spawn3(){
		GameObject _table3 = Instantiate (table3) as GameObject;
		_table3.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table3.transform.position;
	}

	private void Spawn4(){
		GameObject _table4 = Instantiate (table4) as GameObject;
		_table4.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table4.transform.position;
	}

	private void Spawn5(){
		GameObject _table5 = Instantiate (table5) as GameObject;
		_table5.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table5.transform.position;
	}

    	private void Spawn6(){
		GameObject _table6 = Instantiate (table6) as GameObject;
		_table6.transform.position = lastpos - new Vector3 (-size, 0f, 0f);
		lastpos = _table6.transform.position;
	}
	//***********************************************************************************************


	//WALLOBJECTS*************************************************************************************
	private void Spawnfridge(){
		Instantiate (fridge, lastpos + new Vector3 (2.65f, 0f, .3f), fridge.transform.rotation);
	}

	private void Spawnfilter(){
		Instantiate (filter, lastpos + new Vector3 (2.5f, 0f, 0.3f), filter.transform.rotation);
	}

	private void Spawnrack1(){
		Instantiate (rack1, lastpos + new Vector3 (0f, 2.5f, .5f), rack1.transform.rotation);
	}

	private void Spawnrack2(){
		Instantiate (rack2, lastpos + new Vector3 (0f, 2.5f, .5f), rack2.transform.rotation);
	}

	private void Spawnrack3(){
		Instantiate (rack3, lastpos + new Vector3 (0f, 2.5f, .5f), rack3.transform.rotation);
	}

	private void Spawnmirror1(){
		Instantiate (mirror1, lastpos + new Vector3 (0f, 1.6f, .6f), mirror1.transform.rotation);
	}

	private void Spawnmirror2(){
		Instantiate (mirror2, lastpos + new Vector3 (0f, 1.6f, .6f), mirror2.transform.rotation);
	}

	private void Spawnmirror3(){
		Instantiate (mirror3, lastpos + new Vector3 (0f, 1.6f, .6f), mirror3.transform.rotation);
	}

	private void Spawnwallamp(){
		Instantiate (wallamp, lastpos + new Vector3 (2.5f, 3f, .45f), wallamp.transform.rotation);
	}

	private void Spawnlamp(){
		Instantiate (lamp, lastpos + new Vector3 (-2.5f, 3f, .6f), lamp.transform.rotation);
	}
	//******************************************************************************************************


	//OBSTACLES*********************************************************************************************
	private void Spawncatfood(){
		Instantiate (catfood, lastpos + new Vector3 (0f, 1.75f, 0f), catfood.transform.rotation);
	}

	private void Spawnbcake(){
		Instantiate (bcake, lastpos + new Vector3 (-5f, .95f, 0f), bcake.transform.rotation);
	}

	private void Spawntoaster(){
		Instantiate (toaster, lastpos + new Vector3 (-5f, 1.15f, 0f), toaster.transform.rotation);
	}

	private void Spawnmwave(){
		Instantiate (mwave, lastpos + new Vector3 (-5f, 1f, 0f), mwave.transform.rotation);
	}

	private void Spawnmilk(){
		Instantiate (milk, lastpos + new Vector3 (-5f, .9f, 0f), milk.transform.rotation);
	}

	private void Spawnsushi(){
		Instantiate (sushi, lastpos + new Vector3 (-5f, 1f, 0f), sushi.transform.rotation);
	}

	private void Spawnwineb(){
		Instantiate (wineb, lastpos + new Vector3 (-5f, 1.25f, 0f), wineb.transform.rotation);
	}

	private void Spawndesserts(){
		Instantiate (desserts, lastpos + new Vector3 (-5f, 1f, 0f), desserts.transform.rotation);
	}

	private void Spawncheese(){
		Instantiate (cheese, lastpos + new Vector3 (-5f, 1f, 0f), cheese.transform.rotation);
	}

	private void Spawnchicken(){
		Instantiate (chicken, lastpos + new Vector3 (-5f, 1f, 0f), chicken.transform.rotation);
	}

	private void Spawnburger(){
		Instantiate (burger, lastpos + new Vector3 (5f, .95f, 0f), burger.transform.rotation);
	}

	private void Spawncake(){
		Instantiate (cake, lastpos + new Vector3 (5f, .95f, 0f), cake.transform.rotation);
	}

	private void Spawnfruitbowl(){
		Instantiate (fruitbowl, lastpos + new Vector3 (5f, 1f, 0f), fruitbowl.transform.rotation);
	}

	private void Spawnfoodplate(){
		Instantiate (foodplate, lastpos + new Vector3 (5f, 1f, 0f), foodplate.transform.rotation);
	}

	private void Spawndishrack(){
		Instantiate (dishrack, lastpos + new Vector3 (0f, 1f, 0f), dishrack.transform.rotation);
	}

	private void Spawnplatestack(){
		Instantiate (platestack, lastpos + new Vector3 (5f, 1f, 0f), platestack.transform.rotation);
	}

	private void Spawnbowlstack(){
		Instantiate (bowlstack, lastpos + new Vector3 (5f, .95f, 0f), bowlstack.transform.rotation);
	}

	private void Spawnvase1(){
		Instantiate (vase1, lastpos + new Vector3 (5f, .9f, 0f), vase1.transform.rotation);
	}

	private void Spawnvase2(){
		Instantiate (vase2, lastpos + new Vector3 (5f, .9f, 0f), vase2.transform.rotation);
	}

	private void Spawnpancakes(){
		Instantiate (pancakes, lastpos + new Vector3 (5f, .9f, 0f), pancakes.transform.rotation);
	}
    private void SpawnSoap()
    {
        Instantiate(Soap, lastpos + new Vector3(0f, 2f, 0f), Soap.transform.rotation);
    }

    private void SpawnX()
    {
        GameObject _platform = Instantiate(Platform) as GameObject;
        _platform.transform.position = lastpos + new Vector3(size, 0f, 0f);
        lastpos = _platform.transform.position;
    }

    private void SpawnZ()
    {
        GameObject _platform = Instantiate(Platform) as GameObject;
        _platform.transform.position = lastpos + new Vector3(0f, 0f, size);
        lastpos = _platform.transform.position;
    }
    //***************************************************************************************************************************
}
