using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public Transform trans;


	// Use this for initialization
	void Start () {

		Debug.Log("Hello World!");
		Debug.Log("これがユニテー");


		
		Debug.Log("追加下ヨーーーーー");

		
		int    i  = 10;   //整数型
		double d  = 1.0;  //実数型
		bool   b  = true; //論理値型
		string s = "str"; //文字列型
		print(i); //出力:10
		print(d); //出力:1
		print(b); //出力:True
		print(s); //出力:str

		Debug.Log(trans.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
