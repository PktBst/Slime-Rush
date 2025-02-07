using UnityEngine;
using System.Collections;

namespace jumpSfxEffect
{
    public class JumpSfxScript : MonoBehaviour
    {
        [SerializeField] private float lifeTime = 0.3f;
        void Start()
        {
            StartCoroutine(deleteAfter());
        }

        IEnumerator deleteAfter()
        {
            yield return new WaitForSeconds(lifeTime);
            Destroy(gameObject);
        }
    }
}
