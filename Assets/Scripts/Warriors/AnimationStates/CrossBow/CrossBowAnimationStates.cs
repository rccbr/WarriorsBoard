using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class CrossBowAnimationStates : MonoBehaviour
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

        private static CrossBowAnimationStates animationStates;


        void Awake()
        {
            anim = GetComponent<Animator>();

            animationStates = this;
        }

        void Start()
        {

        }

        public static CrossBowAnimationStates getInstance()
        {
            return animationStates;
        }

        public void NoTranslation()
        {
            animState = new CrossBowIdleState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Idle;
        }

        public void FaceToFaceEnemy()
        {
            animState = new CrossBowAttackState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Attack;
        }

        public void NoEnergy()
        {
            animState = new CrossBowDieState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Dead;
        }
    }
}

