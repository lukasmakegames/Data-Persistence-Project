using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

	public TMP_Text Text;
	public TMP_InputField InputText;

	public static string BestName { get; private set; }
	public static int BestScore { get; private set; }
	public static string UserName { get; private set; }
	public static int UserScore { get; private set; }

	// Start is called before the first frame update
	void Start()
	{
		BestName = PlayerPrefs.GetString("name", "noname");
		BestScore = PlayerPrefs.GetInt("score", 0);
		Text.text = "Best Score : " + BestName + " : " + BestScore;
		UserScore = 0;
		UserName = "noname";
	}

	public void UpdateName()
	{
		UserName = InputText.text;

	}

	public void StartButton()
	{
		SceneManager.LoadScene("main");
	}

	public void Quit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#endif
		Application.Quit();
	}

	public static void SetBestScore(int score)
	{
		BestScore = score;
	}

	public static void SetBestName(string name)
	{
		BestName = name;
	}

}
