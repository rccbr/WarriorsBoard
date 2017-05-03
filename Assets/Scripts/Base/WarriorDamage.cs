using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Base
{
    public class WarriorDamage : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public virtual void GotDamage(int attackForce)
        {
            Debug.Log("Getting Damage");
        }
    }
}


