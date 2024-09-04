using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    private TextMeshProUGUI bestScoreText;

    private void Awake()
    {
        bestScoreText = GameObject.Find("Best Score Text").GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.BestPlayer + ": " + DataManager.Instance.BestScore;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

     public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit():
        #endif
    }

    public void NewName(string newName)
    {
        DataManager.Instance.PlayerName = newName;
    }
}
