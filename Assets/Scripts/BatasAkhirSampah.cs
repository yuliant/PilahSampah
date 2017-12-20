using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(collision.gameObject);
		SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
	}
}