using UnityEngine;
using UnityEngine.UI;

public class ModeUI : MonoBehaviour
{
    public Text ModeText;

    private void Start()
    {
        ModeText.text = GameManager.GameMode;
    }
}