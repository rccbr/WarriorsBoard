using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;
using System;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SwordsManLocomotionState : DynamicAnimationState
    {
        public void UpdateAnimParameters(Animator anim)
        {
            anim.SetBool("run", true);
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


