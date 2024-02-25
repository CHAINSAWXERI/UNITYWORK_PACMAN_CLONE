using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterSystem;

namespace BonusSystems
{
    public class Pill : MonoBehaviour
    {
        [SerializeField] public int points;
        [SerializeField] private LayerMask layermask;
        [SerializeField] private Boostraper _boostraper;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (layermask == (layermask | (1 << collision.gameObject.layer)))
            {
                _boostraper.playerController.GetScore(points);
                gameObject.SetActive(false);
            }
        }
    }

}