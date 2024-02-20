using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace BonusSystems
{
    public class Pill : MonoBehaviour
    {
        [SerializeField] private Boostraper boostraper;
        [SerializeField] public int points;
        [SerializeField] private LayerMask layermask;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (layermask == (layermask | (1 << collision.gameObject.layer)))
            {
                boostraper.playerController.GetScore(points);
                gameObject.SetActive(false);
            }
        }
    }

}