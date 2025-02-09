using UnityEngine;

namespace misc
{
    public class SameColliderNSpriteSize : MonoBehaviour
    {
        private Collider2D _collider;
        private SpriteRenderer _spriteRenderer;

        void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _collider = GetComponent<Collider2D>();
        }

        void Update()
        {
            if (_spriteRenderer != null && _collider != null)
            {
                Vector2 localCenter = _spriteRenderer.sprite.bounds.center; 

                if (_collider is BoxCollider2D boxCollider)
                {
                    boxCollider.size = _spriteRenderer.sprite.bounds.size;
                    boxCollider.offset = localCenter; 
                }
                else if (_collider is CircleCollider2D circleCollider)
                {
                    circleCollider.radius = Mathf.Max(_spriteRenderer.sprite.bounds.size.x, _spriteRenderer.sprite.bounds.size.y) / 2;
                    circleCollider.offset = localCenter;
                }
            }
        }
    }
}
