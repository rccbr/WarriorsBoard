using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Interfaces;

public class HammerManIdleState : DynamicAnimationState
{
    public void UpdateAnimParameters(Animator anim)
    {
        anim.SetBool("attack", false);
    }
}
