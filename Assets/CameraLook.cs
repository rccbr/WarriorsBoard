using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarriorsBoard.Camera
{
    public class CameraLook : MonoBehaviour
    {
        public Transform target;

        void Start()
        {

        }

        void Update()
        {
            this.transform.LookAt(target);
            //this.transform.position = new Vector3(target.position.x, 5.0f, target.position.z) - new Vector3(transform.position.x, 2.0f, transform.position.z);
        }
    }
}


