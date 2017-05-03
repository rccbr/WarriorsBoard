using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Interfaces;

public class HammerManAttackState : DynamicAnimationState
{
    public void UpdateAnimParameters(Animator anim)
    {
        anim.SetBool("attack", true);
    }
}
