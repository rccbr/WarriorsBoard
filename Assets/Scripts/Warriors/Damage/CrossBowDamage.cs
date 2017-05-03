using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Manager;
using WarriorsBoard.Warriors.AnimationStates;

namespace WarriorsBoard.Warriors.Damage
{
    public class CrossBowDamage : WarriorDamage
    {
        private static CrossBowDamage crossBowDamage;


        public static CrossBowDamage getInstance()
        {
            return crossBowDamage;
        }

        void Awake()
        {
            crossBowDamage = this;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void GotDamage(int attackForce)
        {
            base.GotDamage(attackForce);

            CrossBow.getInstance().energy -= attackForce;

            if (CrossBow.getInstance().energy <= 0)
            {
                CrossBowAnimationStates.getInstance().NoEnergy();

                CrossBow.getInstance().status = WarriorStatus.Dead;

                Destroy(CrossBow.getInstance().GetComponent<BoxCollider>());

                GameplayManager.getInstance().Go();
            }
        }
    }

}

