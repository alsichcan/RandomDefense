using UnityEngine;
using UnityEngine.UI;

public class RoundCountdownUI : MonoBehaviour {

    public Text RoundCountdownText;

    private void Update()
    {
        // 전광판에 표시
        if (GameManager.Rounds < 10)
        {
            if (GameManager.currentTime < 10f)
                RoundCountdownText.text = "Lv." + "0" + GameManager.Rounds.ToString() + " " + "0" + Mathf.Floor(GameManager.currentTime).ToString() + "'";
            else
                RoundCountdownText.text = "Lv." + "0" + GameManager.Rounds.ToString() + " " + Mathf.Floor(GameManager.currentTime).ToString() + "'";

        }
        else
        {
            if (GameManager.currentTime < 10f)
                RoundCountdownText.text = "Lv." + GameManager.Rounds.ToString() + " " + "0" + Mathf.Floor(GameManager.currentTime).ToString() + "'";
            else
                RoundCountdownText.text = "Lv." + GameManager.Rounds.ToString() + " " + Mathf.Floor(GameManager.currentTime).ToString() + "'";
        }
    }
}
