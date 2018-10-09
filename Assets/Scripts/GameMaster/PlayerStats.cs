using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int Life;
    public int startLife = 5;

    public static int Gold;
    public int startGold = 10;

    public static int Lumber;
    public int startLumber = 5;

    private void Start()
    {
        Life = startLife;
        Gold = startGold;
        Lumber = startLumber;
    }
}
