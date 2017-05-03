using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Base
{
    public class Cube : MonoBehaviour
    {
        public int forceAttack;

        public Vector3 nextDestination;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected virtual void OnTriggerEnter(Collider col)
        {
            Debug.Log("Something collided with this cube" + this.gameObject.name);
        }
    }
}

