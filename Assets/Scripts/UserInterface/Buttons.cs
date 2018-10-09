using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public GameObject unitUI;

    public GameObject barrackUI;
    public GameObject upgradeUI;
    public GameObject strategyUI;
    public GameObject storageUI;
    public GameObject guideUI;


    public void CloseAll()
    {
        unitUI.SetActive(false);
        barrackUI.SetActive(false);
        upgradeUI.SetActive(false);
        strategyUI.SetActive(false);
        storageUI.SetActive(false);
        guideUI.SetActive(false);
    }


    public void OpenBarrack()
    {
        CloseAll();
        barrackUI.SetActive(true);
    }

    public void OpenUpgrade()
    {
        CloseAll();
        upgradeUI.SetActive(true);
    }

    public void OpenStrategy()
    {
        CloseAll();
        strategyUI.SetActive(true);
    }

    public void OpenStorage()
    {
        CloseAll();
        storageUI.SetActive(true);
    }

    public void OpenGuide()
    {
        CloseAll();
        guideUI.SetActive(true);
    }
}
