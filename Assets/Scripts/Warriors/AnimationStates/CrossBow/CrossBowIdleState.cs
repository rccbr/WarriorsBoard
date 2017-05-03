using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;
using System;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class CrossBowIdleState : DynamicAnimationState
    {
        public void UpdateAnimParameters(Animator anim)
        {
            anim.SetBool("attack", false);
        }

        void Start()
        {

        }

        void Update()
        {

        }
    }
}


