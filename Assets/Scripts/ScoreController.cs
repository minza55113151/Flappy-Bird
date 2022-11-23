using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("scorepipe"))
        {
            int score = int.Parse(GameManager.instance.scoreText.text);
            score++;
            GameManager.instance.scoreText.text = score.ToString();
            SoundManager.instance.PlayPointSound();
        }
    }
}
