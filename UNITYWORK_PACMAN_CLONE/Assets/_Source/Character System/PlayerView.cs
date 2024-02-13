using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CharacterSystem
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] public TMP_Text scoreText;
        [SerializeField] public Slider lifesSlider;
        public int score { get; private set; }
        public int lifes { get; private set; }

        public void UpdateText(int value)
        {
            score = value;
            scoreText.text = $"Score: {score}";
        }

        public void UpdateHealth(int value)
        {
            lifes = value;
            lifesSlider.value = lifes;
        }
    }
}

