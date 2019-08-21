using UnityEngine;

namespace _Script
{
    public class CameraSmoothFollow : MonoBehaviour
    {

        public Transform player;
        public float distance = 10;
        public float height = 5;
        public Vector3 lookOffset = new Vector3(0, 1, 0);
        private readonly float _cameraSpeed = 100;
        private readonly float _rotationSpeed = 100;

        void FixedUpdate()
        {
            if (!player) return;
            var currentPosition = transform.position;
            var lookPosition = player.position + lookOffset;
            var relativePos = lookPosition - currentPosition;
            var finalRotation = Quaternion.LookRotation(relativePos);
            transform.rotation =
                Quaternion.Slerp(transform.rotation, finalRotation, Time.deltaTime * _rotationSpeed * 0.1f);
            var playerTransForm = player.transform;
            var finalPosition = playerTransForm.position + playerTransForm.up * height + playerTransForm.forward * distance;
            transform.position = Vector3.Lerp(currentPosition, finalPosition, Time.deltaTime * _cameraSpeed * 0.1f);
        }
    }
}
