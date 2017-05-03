using UnityEngine;
using System.Collections;
using System;
using WarriorsBoard.Interfaces;


namespace WarriorsBoard.Base
{
    public class WarriorAnimationState
    {
        private Animator anim;

        public WarriorAnimationState(Warrior warrior)
        {
            anim = warrior.GetComponent<Animator>();
        }
    }
}


