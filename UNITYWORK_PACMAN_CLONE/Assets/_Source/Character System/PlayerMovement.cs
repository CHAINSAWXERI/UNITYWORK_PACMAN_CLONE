using UnityEngine;
using System.Collections;

namespace CharacterSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private LayerMask ghostLayer;
        [SerializeField] public float speed;
        [SerializeField] public DeathLooker deathLooker;
        [SerializeField] private Restarting restarting;
        private int marker;
        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            float horizontalMove = Input.GetAxis("Horizontal");
            float verticalMove = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(horizontalMove, verticalMove) * speed;

            rb.velocity = movement;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (ghostLayer == (ghostLayer | (1 << collision.gameObject.layer)))
            {
                deathLooker.lives[marker].SetActive(false);
                marker++;
                restarting.Restart();
            }
        }
    }
}