using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;

    public GameObject rectangle;
    public float spawnTime;
    private int m_score;
    private bool m_isGameOver;

    UI m_ui;




    void Start()
    {
        spawnTime = 0;
        m_ui = FindObjectOfType<UI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isGameOver)
        {
            return;
        }
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            CreateBall();
            spawnTime = 2;
        }

    }

    public void CreateBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);
        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        m_score = value;
    }

    public int GetScore()
    {
        return m_score;
    }
    public void IncreaseScore()
    {
        m_score++;
        m_ui.SetScoreText("Soccer: " + m_score);
    }

    public void IsGameOver()
    {
        SetGameOverState(true);
        m_ui.showGameOverPanel(m_isGameOver);

    }

    public void SetGameOverState(bool state)
    {
        m_isGameOver = state;
    }

    public void Replay()
    {
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Soccer: " + m_score);
        m_ui.showGameOverPanel(m_isGameOver);
        rectangle.transform.position = new Vector3(0, (float)-3.51, 0);
    }
}
