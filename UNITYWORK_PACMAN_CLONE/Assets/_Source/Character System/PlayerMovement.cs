using UnityEngine;
using System.Collections;

namespace CharacterSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 5.0f;
        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            float horizontalMove = Input.GetAxis("Horizontal");
            float verticalMove = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(horizontalMove, verticalMove).normalized * speed;

            rb.velocity = movement;
        }
    }
}