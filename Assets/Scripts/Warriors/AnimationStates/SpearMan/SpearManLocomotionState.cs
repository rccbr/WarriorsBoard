using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;
using System;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SpearManLocomotionState : DynamicAnimationState
    {
        public void UpdateAnimParameters(Animator anim)
        {
            anim.SetBool("run", true);
            anim.SetBool("attack", false);

            SpearMan.getInstance().enableTranslation = true;
        }

        void Start()
        {

        }

        void Update()
        {

        }
    }
}


