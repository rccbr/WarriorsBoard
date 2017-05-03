using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Manager;
using WarriorsBoard.Warriors;
using WarriorsBoard.Warriors.AnimationStates;

namespace WarriorsBoard.Warriors.Damage
{
    public class HammerManDamage : WarriorDamage
    {
        private static HammerManDamage hammerManDamage;


        public static HammerManDamage getInstance()
        {
            return hammerManDamage;
        }

        void Awake()
        {
            hammerManDamage = this;
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

           HammerMan.getInstance().energy -= attackForce;

            if (HammerMan.getInstance().energy <= 0)
            {
                HammerManAnimationStates.getInstance().NoEnergy();

                HammerMan.getInstance().status = WarriorStatus.Dead;

                Destroy(HammerMan.getInstance().GetComponent<BoxCollider>());

                GameplayManager.getInstance().Go();
            }
        }
    }

}

