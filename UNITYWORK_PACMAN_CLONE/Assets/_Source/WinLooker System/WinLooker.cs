using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinLooker : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] public GameObject WinPanel;
    [SerializeField] private TimeControll timeController;
    void Update()
    {
        if (score.text == "Score: 367")
        {
            WinPanel.SetActive(true);
            timeController.StopTime();
        }
    }
}
