using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class VagrancyModeStrategy : IModeStrategy
{
    public int randomDirection;
    private float speed;
    private GameObject ghost;
    public VagrancyModeStrategy(int rd, GameObject go, float sp)
    {
        randomDirection = rd;
        speed = sp;
        ghost = go;
    }
    public void PerformMode()
    {
        if (randomDirection == 0)
        {
            Debug.Log("¬верх");
            ghost.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (randomDirection == 1)
        {
            Debug.Log("¬низ");
            ghost.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        else if (randomDirection == 2)
        {
            Debug.Log("¬право");
            ghost.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (randomDirection == 3)
        {
            Debug.Log("¬лево");
            ghost.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
