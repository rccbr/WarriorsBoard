using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Base
{
    public class WarriorOrientation : MonoBehaviour
    {
        public Vector3 NorthDirection()
        {
            return Vector3.forward * 1.0f;
        }

        public Vector3 NorthWestDirection()
        {
            return Vector3.forward;
        }

        public Vector3 NorthEastDirection()
        {
            return Vector3.forward;
        }

        void Awake()
        {
            Debug.Log(transform.forward);
        }
    }
}


