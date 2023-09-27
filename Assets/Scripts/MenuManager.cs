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
    public string bestName;
    [HideInInspector]
    public int bestScore;

    [HideInInspector]
    public string userName;
    [HideInInspector]
    public int userScore;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        bestName = PlayerPrefs.GetString("name", "noname");
        bestScore = PlayerPrefs.GetInt("score", 0);
        Text.text = "Best Score : " + bestName  + " : " + bestScore;
        userScore = 0;
        userName = "noname";
    }

    // Update is called once per frame
    void Update()
    {
        
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
