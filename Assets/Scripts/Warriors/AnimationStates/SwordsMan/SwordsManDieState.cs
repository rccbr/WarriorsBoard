using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;
using System;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SwordsManDieState : DynamicAnimationState
    {
        public void UpdateAnimParameters(Animator anim)
        {
            anim.SetBool("run", false);
            anim.SetBool("attack", false);
            anim.SetTrigger("die");
        }
    }
}


