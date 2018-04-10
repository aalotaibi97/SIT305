using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;            // The position that that camera will be following.
        public float smoothing = 5f;        // The speed with which the camera will be following.


		public Vector3 offset;                     // The initial offset from the target.


        void Start ()
        {
            // Calculate the initial offset.
			offset = transform.localPosition - target.localPosition;
        }


        void Update ()
        {
            // Create a postion the camera is aiming for based on the offset from the target.
			Vector3 targetCamPos = target.localPosition + offset;

            // Smoothly interpolate between the camera's current position and it's target position.
			transform.localPosition = Vector3.Lerp (transform.localPosition, targetCamPos, smoothing * Time.deltaTime);
        }
    }
}