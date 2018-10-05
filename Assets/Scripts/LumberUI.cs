using UnityEngine;
using UnityEngine.UI;

public class LumberUI : MonoBehaviour {

    public Text lumberText;
	
	// Update is called once per frame
	void Update () {
        lumberText.text = PlayerStats.Lumber.ToString();
	}
}
