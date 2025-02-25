using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _score = 0;
    private void Awake()
    {
        SetScoreText();
    }
    public void GetScore(int scorePoint)
    {
        _score += scorePoint;
        SetScoreText();
    }
    private void SetScoreText()
    {
        _scoreText.text = string.Format("{0:D5}", _score);
    }
}
