using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        private bool isGrounded;
        public Transform GroundCheck;
        public float CheckRadius;
        public LayerMask WhatIsGround;

        [SerializeField] private float speed;
        [SerializeField] private int ExtraJumps;
        [SerializeField] private float jumpForce;

        private float HorizontalInput;
        private Rigidbody2D rb;
        private bool facingRight = true;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        private void LateUpdate()
        {
            transform.rotation = Quaternion.identity;
            isGrounded = Physics2D.OverlapCircle(GroundCheck.position,CheckRadius,WhatIsGround);
            HorizontalInput = Input.GetAxis("Horizontal");
            rb.linearVelocityX = HorizontalInput * speed;

            if (HorizontalInput > 0 && facingRight!=true) {
                ToggleFaceSide();
            }
            if (HorizontalInput < 0 && facingRight != false) {
                ToggleFaceSide();
            }
        }

        private void Update()
        {
            if (isGrounded)
            {
                ExtraJumps = 2;
            }

            if(Input.GetKeyDown(KeyCode.Space) && ExtraJumps > 0){
                rb.linearVelocity = Vector2.up * jumpForce;
                ExtraJumps--;
            }
        }

        void ToggleFaceSide()
        {
            facingRight = !facingRight;
            Vector2 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
    }

}