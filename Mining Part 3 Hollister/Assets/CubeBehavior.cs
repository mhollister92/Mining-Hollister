using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	public OreType mytype;


	// Use this for initialization
	void Start () {
		if (mytype == OreType.Bronze) 
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		} 
		else if (mytype == OreType.Silver) 
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
		} 
		else if (mytype == OreType.Gold) 
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
		}
		else if (mytype == OreType.Kryptonite) 
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}
	
	}
	void OnMouseDown()
	{
		Destroy (gameObject);

		if (mytype == OreType.Bronze) 
		{
			GameController.bronzeCount--;
			GameController.score += GameController.bronzePoints;
		} 
		else if (mytype == OreType.Silver) 
		{
			GameController.silverCount--;
			GameController.score += GameController.silverPoints;
		} 
		else if (mytype == OreType.Gold) 
		{
			GameController.goldCount--;
			GameController.score += GameController.goldPoints;
		} 
		else if (mytype == OreType.Kryptonite) 
		{
			GameController.kryptoniteCount--;
			GameController.score += GameController.kryptonitePoints;
		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
