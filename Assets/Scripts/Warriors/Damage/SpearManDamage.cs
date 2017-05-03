using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Manager;
using WarriorsBoard.Warriors;
using WarriorsBoard.Warriors.AnimationStates;

namespace WarriorsBoard.Warriors.Damage
{
    public class SpearManDamage : WarriorDamage
    {
        private static SpearManDamage spearManDamage;

        public static SpearManDamage getInstance()
        {
            return spearManDamage;
        }

        void Awake()
        {
            spearManDamage = this;
        }

        public override void GotDamage(int attackForce)
        {
            base.GotDamage(attackForce);

            SpearMan.getInstance().energy -= attackForce;

            if (SpearMan.getInstance().energy <= 0)
            {
                SpearManAnimationStates.getInstance().NoEnergy();

                SpearMan.getInstance().status = WarriorStatus.Dead;

                Destroy(SpearMan.getInstance().GetComponent<BoxCollider>());

                GameplayManager.getInstance().Go();
            }
        }
    }

}

