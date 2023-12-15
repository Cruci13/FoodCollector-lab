using System;
using TMPro;
using UnityEngine;

namespace Game.Sources.Player
{
    public class PlayerFruitsCollector : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentScoreText;
        [SerializeField] private TextMeshProUGUI _highScoreText;

        private int _score = 0;
        private int _highScore = 0;

        private void Start()
        {
            _highScore = PlayerPrefs.GetInt("HighScore", 0);
            _highScoreText.text = $"Record : {_highScore}";
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Fruit"))
            {
                Destroy(other.gameObject);
                _score++;
                _currentScoreText.text = $"Score : {_score}";
                if(_score > _highScore)
                {
                    _highScore = _score;
                    _highScoreText.text = $"Record : {_highScore}";
                    PlayerPrefs.SetInt("HighScore", _highScore);
                }
            }
        }
    }
}