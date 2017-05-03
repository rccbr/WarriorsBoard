using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Interfaces;
using WarriorsBoard.Manager;
using System;

namespace WarriorsBoard.Warriors
{
    public class SwordsMan : Warrior, WarriorTranslation, WarriorRotation
    {
        //Swords Man in-game translation velocity

        public float speed = 5.0f;

        //able to translate or not

        public bool enableTranslation = false;

        //global instance

        private static SwordsMan swordsMan;

       
        // Use this for initialization

        void Awake()
        {
            swordsMan = this;
        }

        // Update is called once per frame

        void Update()
        {
            if (enableTranslation)
                Translate(speed);
        }

        public static SwordsMan getInstance()
        {
            return swordsMan;
        }

        /*---------------------------------------------------------------
            Interface implementation for warrior that translates
        ---------------------------------------------------------------*/

        public void Translate(float speed)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        public void RotateTowards(Vector3 direction)
        {
            transform.rotation = Quaternion.LookRotation(direction.normalized);
        }
    }
}


