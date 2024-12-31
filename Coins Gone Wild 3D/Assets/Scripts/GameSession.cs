using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
	public static GameSession Instance;
	private int totalCoins;
	private int CollectedCoins = 0;

	private void Awake()
	{
		Instance = this;
		totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
	}

	public void CoinCollected()
	{
		CollectedCoins++;
		if (CollectedCoins >= totalCoins)
		{
			WinGame();
		}
	}

	void WinGame()
	{
		Debug.Log("You Win!");
		SceneManager.LoadScene("MainMenu");
	}
}
