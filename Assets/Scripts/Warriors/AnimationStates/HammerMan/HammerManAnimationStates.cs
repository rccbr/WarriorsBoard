using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class HammerManAnimationStates : MonoBehaviour
    {
        public enum WarriorAnimState
        {
            Idle,
            Locomotion,
            Attack,
            Dead
        };

        public WarriorAnimState status;

        public DynamicAnimationState animState;

        private Animator anim;

        private static HammerManAnimationStates animationStates;


        void Awake()
        {
            anim = GetComponent<Animator>();

            animationStates = this;
        }

        void Start()
        {

        }

        public static HammerManAnimationStates getInstance()
        {
            return animationStates;
        }

        public void NoTranslation()
        {
            animState = new HammerManIdleState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Idle;
        }

        public void FaceToFaceEnemy()
        {
            animState = new HammerManAttackState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Attack;
        }

        public void NoEnergy()
        {
            animState = new HammerManDeadState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Dead;
        }
    }
}

