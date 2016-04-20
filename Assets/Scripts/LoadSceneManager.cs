using UnityEngine;
using System.Collections;

public class LoadSceneManager : MonoBehaviour
{
	public void LoadCustomScene(string sceneName)
	{
		Debug.Log("Try to load scene "+sceneName);
		Application.LoadLevel (""+sceneName); 
	}
}