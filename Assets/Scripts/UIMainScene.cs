using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScene : MonoBehaviour
{
    private Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText = GameObject.Find("BestScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.BestPlayer + ": " + DataManager.Instance.BestScore;
    }
}
