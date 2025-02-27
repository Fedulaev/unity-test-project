using UnityEngine;
public class ScoreBuff : Buff
{
    [SerializeField] private int _scoreAmount;
    protected override void TakeEffect()
    {
        GameScore gameScore = _player.GetComponent<GameScore>();
        gameScore.GetScore(_scoreAmount);
    }
}
