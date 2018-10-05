using UnityEngine;
using UnityEngine.UI;

public class EnemyCountUI : MonoBehaviour {

    public GameObject MainCamera;
    public Image enemyCountBar;
    public Text enemyCountText;

    // Update is called once per frame
    void Update()
    {
        enemyCountText.text = GameManager.EnemyCount.ToString();
        enemyCountBar.fillAmount = (float) GameManager.EnemyCount / GameManager.MaxEnemyCount;
    }

    public void MoveCamera()
    {
        MainCamera.transform.position = new Vector3(120f, 400f, 250f);
    }
}
