using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController mgc;

    public void Start()
    {
        mgc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            mgc.IncreaseScore();
            Destroy(gameObject);
            Debug.Log("Rơi vào giá đỡ");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("DeathZone"))
        {
            mgc.IsGameOver();
            Destroy(gameObject);
            Debug.Log("Rơi Trúng vùng chết");
        }
    }

}
