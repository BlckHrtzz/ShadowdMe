using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour 
{
	public bool playerAlive = true;
	public float timer;
	public float waitTime = 2.0f;

	void Start () 
	{
	}
	
	void Update ()
	{
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Boy") 
		{
			Debug.Log ("Die");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


		}

	}
		
}