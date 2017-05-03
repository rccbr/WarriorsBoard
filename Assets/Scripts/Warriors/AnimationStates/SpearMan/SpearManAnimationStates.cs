using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SpearManAnimationStates : MonoBehaviour
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

        private static SpearManAnimationStates animationStates;


        void Awake()
        {
            anim = GetComponent<Animator>();

            animationStates = this;
        }

        void Start()
        {
            Translate();
        }

        public static SpearManAnimationStates getInstance()
        {
            return animationStates;
        }

        public void NoTranslation()
        {
            animState = new SpearManIdleState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Idle;
        }

        public void Translate()
        {
            animState = new  SpearManLocomotionState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Locomotion;
        }

        public void FaceToFaceEnemy()
        {
            animState = new SpearManAttackState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Attack;
        }

        public void NoEnergy()
        {
            animState = new SpearManDeadState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Dead;
        }
    }
}

