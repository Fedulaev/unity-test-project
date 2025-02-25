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
    public void TakeDamage(int damage)
    {
        _healthPoints -= damage;
        FillHealthBar();
        if(_healthPoints <= 0)
            Die();
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
