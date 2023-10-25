using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;

    public GameObject gameOverPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }

    public void showGameOverPanel(bool isShow)
    {
        if (gameOverPanel)
            gameOverPanel.SetActive(isShow);
    }

}
