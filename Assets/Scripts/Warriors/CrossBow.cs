using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;

namespace WarriorsBoard.Warriors
{
    public class CrossBow : Warrior
    {
        private static CrossBow crossBow;

        public static CrossBow getInstance()
        {
            return crossBow;
        }

        // Use this for initialization
        void Awake()
        {
            crossBow = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


