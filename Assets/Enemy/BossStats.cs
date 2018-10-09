using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BossStats : MonoBehaviour {

    [Header("BossInfo")]
    public string bossName;
    public string bossClass;
    public Sprite unitPortrait;
    public int bossRound;

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
    private GameObject healthBarUI;
    private GameObject healthBarUiText;

    private void Start()
    {
        unitHealth = startUnitHealth;
        unitArmor = startUnitArmor;
        unitSpeed = startUnitSpeed;
        unitStatus = new ArrayList();

        healthBarUI = GameObject.FindGameObjectWithTag("BossHPBar");
        healthBarUiText = GameObject.FindGameObjectWithTag("BossHPText");
    }

    public void TakeDamage(int damage)
    {
        unitHealth -= damage;

        float BossHPRatio = unitHealth / startUnitHealth;

        healthBar.fillAmount = BossHPRatio;
        healthBarUI.GetComponent<Image>().fillAmount = BossHPRatio;
        healthBarUiText.GetComponent<Text>().text = (BossHPRatio * 100).ToString() + "%";

        if (unitHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameManager.isBossAlive = false;
        PlayerStats.Gold += goldDrop;
    }
}
