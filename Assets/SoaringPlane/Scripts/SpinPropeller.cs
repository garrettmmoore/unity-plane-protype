﻿using UnityEngine;

namespace SoaringPlane.Scripts
{
    public class SpinPropeller : MonoBehaviour
    {
        private const float RotationSpeed = 1000f;
        
        private void LateUpdate()
        {
            transform.Rotate(Vector3.forward * (Time.deltaTime * RotationSpeed));
        }
    }
}
