using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public TMP_Text Text;
    public TMP_InputField InputText;


    [HideInInspector]
    public static string bestName;
    [HideInInspector]
    public static int bestScore;

    [HideInInspector]
    public static string userName;
    [HideInInspector]
    public static int userScore;

    // Start is called before the first frame update
    void Start()
    {
        bestName = PlayerPrefs.GetString("name", "noname");
        bestScore = PlayerPrefs.GetInt("score", 0);
        Text.text = "Best Score : " + bestName  + " : " + bestScore;
        userScore = 0;
        userName = "noname";
    }

	public void UpdateName()
	{
        userName = InputText.text;

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
}
