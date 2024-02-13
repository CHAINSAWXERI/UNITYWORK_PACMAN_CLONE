using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
using CharacterSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace BonusSystems
{
    public class Pill : MonoBehaviour
    {
        [SerializeField] public Boostraper boostraper;
        [SerializeField] public int points;
        [SerializeField] public int layerId;
        int layer_number;
        LayerMask layermask;

        void Start()
        {
            layer_number = LayerMask.NameToLayer("Player");
            layermask = 1 << layer_number;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (layermask == (layermask | (1 << layer_number)))
            {
                Debug.Log("YES");
                boostraper.playerController.GetScore(points);
                gameObject.SetActive(false);
            }
        }
    }

}