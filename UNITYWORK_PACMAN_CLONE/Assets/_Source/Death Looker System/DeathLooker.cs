using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLooker : MonoBehaviour
{
    [SerializeField] public List<GameObject> lives = new List<GameObject>();
    [SerializeField] public GameObject DeathScreen;
    [SerializeField] private TimeControll timeController;
    private int x;
    void Update()
    {
        x = 0;
        for (int i = 0; i < lives.Count; i++)
        {
            if (lives[i].active == false)
            {
                x++;
            }
        }
        if (x == lives.Count)
        {
            DeathScreen.SetActive(true);
            timeController.StopTime();
        }
    }
}
