using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public float spawnTime;
	float timeToAct = 0.0f;
	public GameObject bronzeCubePrefab;
	public GameObject silverCubePrefab;
	public GameObject goldCubePrefab;
	public GameObject kryptoniteCubePrefab;
	public static int bronzeCount = 0;
	public static int silverCount = 0;
	public static int goldCount = 0;
	public static int kryptoniteCount = 0;
	public static int bronzePoints = 1;
	public static int silverPoints = 10;
	public static int goldPoints = 100;
	public static int kryptonitePoints = 1000;
	public static int score = 0;
	private bool recentlySpawnedGold = false;
	float timer;
	float minutes;
	float seconds;

	// Use this for initialization
	void Start () {
		timeToAct += spawnTime;

	}

	void OnGUI()
	{
		timer = Time.time;
		minutes = timer / 60;
		seconds = timer % 60;
		GUI.Label (new Rect (10, 10, 50, 20), (int)minutes + ":" + (int)seconds);

		GUI.Label (new Rect (100, 10, 100, 20), "Score: " + score);
	}
	// Update is called once per frame
	void Update () {


		if (Time.time >= timeToAct) 
		{
	
			if ((silverCount + kryptoniteCount == 2 && goldCount == 2)
			    || (silverCount == 2 && goldCount + kryptoniteCount == 2)&& kryptoniteCount < 3)
			{
				Instantiate (kryptoniteCubePrefab,
				             new Vector3(Random.Range (-9f,9f), Random.Range (-3f, 5f), 0),
				             Quaternion.identity);
				kryptoniteCount++;
				recentlySpawnedGold = false;
			}
			if ((bronzeCount == 2 && silverCount + kryptoniteCount == 2) 
			    || (bronzeCount + kryptoniteCount == 2 && silverCount == 2) && recentlySpawnedGold == false)
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
