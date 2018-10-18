using UnityEngine;
using UnityEngine.UI;

public class BossHPUI : MonoBehaviour {

    public GameObject MainCamera;
    public Image BossHPBar;
    public Text BossHPText;

    private Vector3 defaultPosition = new Vector3(-150f, 70f, 0);
    
	// Update is called once per frame
	void Update () {
        if (!GameManager.isBossAlive)
        {
            BossHPBar.gameObject.SetActive(false);
        }
        else
        {
            BossHPBar.gameObject.SetActive(true);
        }
    }

    public void MoveCamera()
    {
        MainCamera.transform.position = defaultPosition;
    }
}
