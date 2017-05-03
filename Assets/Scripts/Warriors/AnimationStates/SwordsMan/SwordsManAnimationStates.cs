using UnityEngine;
using System.Collections;
using WarriorsBoard.Interfaces;

namespace WarriorsBoard.Warriors.AnimationStates
{
    public class SwordsManAnimationStates : MonoBehaviour
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

        private static SwordsManAnimationStates animationStates;
        

        void Awake()
        {
           anim = GetComponent<Animator>();

           animationStates = this;
        }

        void Start()
        {
            
        }

        public static SwordsManAnimationStates getInstance()
        {
            return animationStates;
        }

        public void NoTranslation()
        {
            animState = new SwordsManIdleState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Idle;
        }

        public void Translate()
        {
            animState = new SwordsManLocomotionState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Locomotion;
        }

        public void FaceToFaceEnemy()
        {
            animState = new SwordsManAttackState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Attack;
        }

        public void NoEnergy()
        {
            animState = new SwordsManDieState();

            animState.UpdateAnimParameters(this.anim);

            status = WarriorAnimState.Dead;
        }
    }
}

