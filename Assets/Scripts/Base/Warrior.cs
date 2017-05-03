using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Base
{
    public enum WarriorStatus
    {
        Alive,
        Dead
    };

    public class Warrior : MonoBehaviour
    {
        public float energy;

        public int attackForce;

        public Vector3 nextDestination;

        public WarriorStatus status;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        
        // Rotate towards to some direction

        protected virtual void RotateTowards(Vector3 direction)
        {
            Debug.Log("Rotate towards to " + direction);
        }
    }
}


