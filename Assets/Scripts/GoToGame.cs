using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour 
{

	void Start () 
	{
		Invoke ("GoingToGame", 3);
	
	}

	void GoingToGame() 
	{
		Debug.Log ("Die");

		SceneManager.LoadScene(1);
	}
}
