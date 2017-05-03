using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Interfaces;
using System;
using WarriorsBoard.Warriors.AnimationStates;

namespace WarriorsBoard.Warriors
{
    public class SpearMan : Warrior, WarriorTranslation
    {
        private static SpearMan spearMan;

        public float speed = 5.0f;

        public bool enableTranslation;

        public static SpearMan getInstance()
        {
            return spearMan;
        }

        public void Translate(float speed)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        void Awake()
        {
            spearMan = this;
        }

        void Start()
        {
            
        }

        void Update()
        {
            if (enableTranslation)
                Translate(speed * Time.deltaTime);
        }
    }
}


