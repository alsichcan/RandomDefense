using UnityEngine;
using UnityEngine.UI;

public class BossHPUI : MonoBehaviour {

    public GameObject MainCamera;
    public Image BossHPBar;
    public Text BossHPText;

	// Update is called once per frame
	void Update () {

        if (!GameManager.isBossAlive)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
            float BossHPRatio = GameManager.BossHealthPoint / GameManager.BossMaxHealthPoint;
            BossHPText.text = (BossHPRatio * 100).ToString() + "%";
            BossHPBar.fillAmount = BossHPRatio;

        }
    }

    public void MoveCamera()
    {
        MainCamera.transform.position = new Vector3(-70f, 220f, 0f);
    }
}
