using UnityEngine;
using System.Collections;
using WarriorsBoard.Warriors;
using WarriorsBoard.Base;
using WarriorsBoard.Warriors.AnimationStates;
using WarriorsBoard.Warriors.Attack;

namespace WarriorsBoard.Warriors.EnemyDetection
{
    public class SwordsManEnemyDetection : WarriorEnemyDetection
    {
        public static SwordsManEnemyDetection swordsManEnemyDetection;

        public bool enemyDetected = false;

        public Warrior currentEnemy;

        // Use this for initialization
        void Awake()
        {
            swordsManEnemyDetection = this;
        }

        // Update is called once per frame
        void Update()
        {
           
            DetectEnemy();
        }

        public static SwordsManEnemyDetection getInstance()
        {
            return swordsManEnemyDetection;
        }

        public override void DetectEnemy()
        {
            RaycastHit hit;

            base.DetectEnemy();

            Debug.Log("SwordsMan forward: " + transform.forward);

            if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    enemyDetected = true;

                    SwordsMan.getInstance().enableTranslation = false;

                    SwordsManAnimationStates.getInstance().NoTranslation();

                    currentEnemy = hit.collider.gameObject.GetComponent<Warrior>();

                    SwordsManAttack.getInstance().CheckEnemyDirection(currentEnemy);
                }
            }
            else
            {
                enemyDetected = false;

                currentEnemy = null;
            }
                
        }
    }
}


