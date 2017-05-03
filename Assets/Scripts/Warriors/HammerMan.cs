using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;

namespace WarriorsBoard.Warriors
{
    public class HammerMan : Warrior
    {
        private static HammerMan hammerMan;

        public static HammerMan getInstance()
        {
            return hammerMan;
        }

        // Use this for initialization
        void Awake()
        {
            hammerMan = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


