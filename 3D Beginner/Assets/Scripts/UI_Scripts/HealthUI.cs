using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    private const float MAX_HEALTH = 100f;
    public GameEnding gameEnding;
    [SerializeField] private float health = MAX_HEALTH;

    private Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / MAX_HEALTH;
    }

    public void Hurt(int damage)
    {
        Debug.Log("Hit: " + damage);
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
       gameEnding.CaughtPlayer();
    }

}
