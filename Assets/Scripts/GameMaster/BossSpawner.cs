using System.Collections;
using UnityEngine;

public class BossSpawner : MonoBehaviour {

    public GameObject[] Bosses;
    public Transform spawnPoint;

	// Update is called once per frame
	void Update () {
        
        if (GameManager.Rounds != 0 && GameManager.Rounds % 10 == 0)
        {
            if (!GameManager.isBossAlive)
            {
                GameObject boss = Bosses[GameManager.Rounds / 10];
                SpawnBoss(boss);
            }
        }
		
	}

    void SpawnBoss(GameObject boss)
    {
        Instantiate(boss, spawnPoint.position, spawnPoint.rotation);
        GameManager.isBossAlive = true;
    }


}
