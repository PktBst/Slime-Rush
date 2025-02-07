using UnityEngine;

namespace FollowPlayer
{
    public class FollowPlayer : MonoBehaviour
    {
        private GameObject player;
        void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        void LateUpdate()
        {
            transform.position = player.transform.position + new Vector3(3, 0, -10);
        }
    }
}
