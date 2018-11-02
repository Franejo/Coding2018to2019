using UnityEngine;

public class GameManager
{
	static GameManager instance;

	public static GameManager Instance
	{ get { return instance ?? ((instance = new GameManager())); } }
	public Character MyCharater
	{ get; set; }

	private GameManager()
	{
		Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
	}


	private void Update()
	{

	}


	class Updater : MonoBehaviour
	{
		private void Update()
		{
			instance.Update();
		}
	}

	
}