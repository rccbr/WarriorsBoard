using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;
using System;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SpearManIdleState : DynamicAnimationState
    {
        public void UpdateAnimParameters(Animator anim)
        {
            anim.SetBool("run", false);
            anim.SetBool("attack", false);

            SpearMan.getInstance().enableTranslation = false;
        }

        void Start()
        {

        }

        void Update()
        {

        }
    }
}


