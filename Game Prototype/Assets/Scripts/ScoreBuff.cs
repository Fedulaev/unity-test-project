using UnityEngine;
public class ScoreBuff : Buff
{
    [SerializeField] private int _scorePoint;
    protected override void TakeEffect()
    {
        GameScore gameScore = Player.GetComponent<GameScore>();
        gameScore.GetScore(_scorePoint);
    }
}
