using UnityEngine;
using UnityEngine.UI;

public class EnemyCountUI : MonoBehaviour {

    public Camera MainCamera;
    public Image enemyCountBar;
    public Text enemyCountText;

    public Vector3 defaultPosition = new Vector3(-150f, -70f, 0);

    // Update is called once per frame
    void Update()
    {
        enemyCountText.text = GameManager.EnemyCount.ToString();
        enemyCountBar.fillAmount = (float) GameManager.EnemyCount / GameManager.MaxEnemyCount;
    }

    public void MoveCamera()
    {
        MainCamera.transform.position = defaultPosition;
        MainCamera.fieldOfView = 60f;
    }
}
