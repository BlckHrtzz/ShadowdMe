using UnityEngine;
using System.Collections;

public class MovingGame : MonoBehaviour {

	private GameObject gLayer;
	public float gameSpeed = 2.0f;
	public bool playerAlive = true;
	public float timer;
	public float waitTime = 2.0f;

	void Start () {
		gLayer = GameObject.Find ("GameLayer");
	}
	void FixedUpdate () {
	
		gLayer.transform.position = new Vector2 (gLayer.transform.position.x - gameSpeed * Time.deltaTime, 0);

	}
	/*void Update ()
	{
		if (playerAlive == false)
		{
			LevelReset ();
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boy") 
		{
			playerAlive = false;
		}

	}

	void LevelReset()
	{
		//timer += Time.deltaTime;

		//if(timer >= waitTime)
		//{
			Application.LoadLevel(0);
		//}
	}-*/
}
