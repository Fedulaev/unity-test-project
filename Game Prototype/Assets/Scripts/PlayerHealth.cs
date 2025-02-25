using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent (typeof(BoxCollider2D))]
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _healthPoints;
    [SerializeField] private Image _healthBar;
    protected float _maxHealthPoints = 100;
    private void Start()
    {
        _healthPoints = _maxHealthPoints;
    }
    public void TakeDamage(int _damage)
    {
        _healthPoints -= _damage;
        FillHealthBar();
        if(_healthPoints <= 0)
            Die();
    }
    public void Heal(int _healPoint)
    {
        _healthPoints += _healPoint;
        if (_healthPoints > _maxHealthPoints)
            _healthPoints = _maxHealthPoints;
        FillHealthBar();
    }
    private void FillHealthBar()
    {
        _healthBar.fillAmount = _healthPoints/100;
    }
    private void Die()
    {
        _healthPoints = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
