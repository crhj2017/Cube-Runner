using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	Canvas menu;

	[SerializeField]
	ObstacleGenerate generate;

	[SerializeField]
	Score score;

	[SerializeField]
	private Transform rb;

	void Start()
	{
		menu = this.GetComponent<Canvas>();
		score.enabled = false;
		Time.timeScale = 1f;
	}

	public void playGame()
	{
		menu.enabled = false;
		generate.enabled = true;

		score.score.text = "0";
		score.enabled = true;
	}
	void Menu()
	{
		menu.enabled = true;
		generate.enabled = false;
		score.enabled = false;
	}

    public void Quit()
    {
		Application.Quit();
	}

	void Update()
	{
		// Checks for losing state
		if (rb.position[1] <= -5)
		{
			Invoke("Menu", 0.5f);
		}
	}
}
