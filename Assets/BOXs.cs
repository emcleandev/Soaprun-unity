using UnityEngine;
using System.Collections.Generic;

public class BOXs : MonoBehaviour {

	List<SpriteRenderer> CratespriteList = new List<SpriteRenderer>();

	public GameObject Manger;
	//public GameObject[] Test; shows how to create a list of a variable type
	public bool allowBoxesToInvisible;
	public SpriteRenderer c1;
	public SpriteRenderer c2;
	public SpriteRenderer c3;
	public SpriteRenderer c4;
	public SpriteRenderer c5;
	public SpriteRenderer c6;
	public SpriteRenderer c7;
	public SpriteRenderer c8;
	public SpriteRenderer c9;
	public SpriteRenderer c10;
	public SpriteRenderer c11;
	public SpriteRenderer c12;
	public SpriteRenderer c13;
	public SpriteRenderer c14;
	public SpriteRenderer c15;
	public SpriteRenderer c16;
	public SpriteRenderer c17;
	public SpriteRenderer c18;
	public SpriteRenderer c19;
	public SpriteRenderer c20;
	public SpriteRenderer c21;
	public SpriteRenderer c22;


	void Start () {
		CratespriteList.Add (c1);
		CratespriteList.Add (c2);
		CratespriteList.Add (c3);
		CratespriteList.Add (c4);
		CratespriteList.Add (c5);
		CratespriteList.Add (c6);
		CratespriteList.Add (c7);
		CratespriteList.Add (c8);
		CratespriteList.Add (c9);
		CratespriteList.Add (c10);
		CratespriteList.Add (c11);
		CratespriteList.Add (c12);
		CratespriteList.Add (c13);
		CratespriteList.Add (c14);
		CratespriteList.Add (c15);
		CratespriteList.Add (c16);
		CratespriteList.Add (c17);
		CratespriteList.Add (c18);
		CratespriteList.Add (c19);
		CratespriteList.Add (c20);
		CratespriteList.Add (c21);
		CratespriteList.Add (c22);



	
	}
	
	// Update is called once per frame
	void Update () {

		if (allowBoxesToInvisible == true) {
			foreach (SpriteRenderer cratesprite in CratespriteList) {
		
				cratesprite.enabled = !Manger.GetComponent<Manger> ().clearCrates;
			
			}
		}
	}
}
