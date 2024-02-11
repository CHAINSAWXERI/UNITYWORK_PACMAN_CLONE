using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerModel
{
    public int Score;
    public int Health;

    public void AddScore(int value)
    {
        Score += value;
    }

    public void SubtractLife(int value)
    {
        Health -= value;
    }
}


