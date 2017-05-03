using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Warriors.EnemyDetection;
using WarriorsBoard.Warriors.AnimationStates;
using WarriorsBoard.Warriors.Damage;


namespace WarriorsBoard.Warriors.Attack
{
    public class SwordsManAttack : WarriorAttack
    {
        private static SwordsManAttack swordsManAttack;

        public WarriorDamage enemyDamageSystem;

        // Use this for initialization
        void Awake()
        {
            swordsManAttack = this;
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public static SwordsManAttack getInstance()
        {
            return swordsManAttack;
        }

        public override void CheckEnemyDirection(Warrior enemy)
        {
            base.CheckEnemyDirection(enemy);

            if (Mathf.Round(Vector3.Dot(this.transform.forward, enemy.transform.forward)) == -1)
            {
                //plays the attack animation when the enemy is face to face with Swords Man

                SwordsManAnimationStates.getInstance().FaceToFaceEnemy();

                enemyDamageSystem = SwordsManEnemyDetection.getInstance().currentEnemy.GetComponent<WarriorDamage>();
            }
        }

        void AttackDamage()
        {
            if (SwordsManEnemyDetection.getInstance().currentEnemy != null)
            {
                if (SwordsManEnemyDetection.getInstance().currentEnemy.status != WarriorStatus.Dead)
                    enemyDamageSystem.GotDamage(SwordsMan.getInstance().attackForce);
               
                if (SwordsManEnemyDetection.getInstance().currentEnemy.status == WarriorStatus.Dead)
                {
                    SwordsManAnimationStates.getInstance().NoTranslation();
                    SwordsMan.getInstance().nextDestination = SwordsManEnemyDetection.getInstance().currentEnemy.nextDestination;
                    SwordsManEnemyDetection.getInstance().currentEnemy = null;
                }
            }
        }

        public void UseAttackForce()
        {
            SwordsMan.getInstance().attackForce = 0;
        }
    }
}


