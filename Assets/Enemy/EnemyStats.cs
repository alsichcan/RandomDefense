using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour {

    [Header("EnemyInfo")]
    public string enemyName;
    public string enemyClass;
    public Sprite unitPortrait;
    public int enemyRound;

    [Header("UnitStats")]
    public float startUnitHealth;
    public float startUnitArmor;
    public float startUnitSpeed;
    public int goldDrop;

    [HideInInspector]
    public float unitHealth, unitArmor, unitSpeed;
    [HideInInspector]
    public ArrayList unitStatus;

    [Header("UI Element")]
    public Image healthBar;


    private void Start()
    {
        unitHealth = startUnitHealth;
        unitArmor = startUnitArmor;
        unitSpeed = startUnitSpeed;
        unitStatus = new ArrayList();
    }

    public void TakeDamage (int damage)
    {
        unitHealth -= damage;

        healthBar.fillAmount = unitHealth / startUnitHealth;

        if(unitHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameManager.EnemyCount--;
        PlayerStats.Gold += goldDrop;
    }
}
