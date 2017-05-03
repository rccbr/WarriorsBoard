using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Interfaces;

public class HammerManDeadState : DynamicAnimationState
{
    public void UpdateAnimParameters(Animator anim)
    {
        anim.SetTrigger("die");
    }
}
