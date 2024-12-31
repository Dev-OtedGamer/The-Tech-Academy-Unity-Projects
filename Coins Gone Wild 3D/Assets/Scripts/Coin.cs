using UnityEditor.Build.Content;
using UnityEngine;

public class Coin : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Destroy(gameObject);
			GameSession.Instance.CoinCollected();
		}
	}
}
