using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	float spawnTime = 3.0f;
	float timeToAct = 0.0f;
	public GameObject bronzeCubePrefab;
	public GameObject silverCubePrefab;
	public GameObject goldCubePrefab;
	public static int bronzeCount = 0;
	public static int silverCount = 0;
	public static int goldCount = 0;
	public static int bronzePoints = 1;
	public static int silverPoints = 10;
	public static int goldPoints = 100;
	public static int score = 0;
	private bool recentlySpawnedGold = false;

	// Use this for initialization
	void Start () {
		timeToAct += spawnTime;

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timeToAct) 
		{
	
			if (bronzeCount == 2 && silverCount == 2 && recentlySpawnedGold == false)
			{
				Instantiate(goldCubePrefab,
				            new Vector3(Random.Range (-9f,9f), Random.Range (-3f,5f), 0),
				            Quaternion.identity);
				goldCount++;
				recentlySpawnedGold = true;
			}
			else if (bronzeCount < 4)
			{
				Instantiate(bronzeCubePrefab,
				            new Vector3(Random.Range (-9f,9f), Random.Range (-3f,5f), 0),
				            Quaternion.identity);
				bronzeCount++;
				recentlySpawnedGold = false;

			}
			else if (bronzeCount >= 4)
			{
				Instantiate(silverCubePrefab,
				            new Vector3(Random.Range (-9f,9f), Random.Range (-3f,5f), 0),
				            Quaternion.identity);
				silverCount++;
				recentlySpawnedGold = false;
			}

			timeToAct += spawnTime;
		}
	
	}
}
