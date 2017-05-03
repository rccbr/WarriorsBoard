using UnityEngine;
using System.Collections;
using WarriorsBoard.Warriors;
using WarriorsBoard.Base;
using WarriorsBoard.Warriors.AnimationStates;
using WarriorsBoard.Warriors.Attack;
using WarriorsBoard.Utils;


namespace WarriorsBoard.Warriors.EnemyDetection
{
    public class CrossBowEnemyDetection : WarriorEnemyDetection
    {
        private static CrossBowEnemyDetection crossBowEnemyDetection;

        public Vector3 lookDirection;
        public Vector3 fovDirectionLeft;
        public Vector3 fovDirectionRight;

        public float fovAngle = 30.0f;
        public float angleFormed;
        public float rayDistance = 5.0f;

        public bool enemyDetected = false;


        // Use this for initialization
        void Awake()
        {
            crossBowEnemyDetection = this;
        }

        // Update is called once per frame
        void Update()
        {
           

            DetectEnemy();

            lookDirection = transform.forward;
        }

        public static CrossBowEnemyDetection getInstance()
        {
            return crossBowEnemyDetection;
        }

        public override void DetectEnemy()
        {
            base.DetectEnemy();

            Vector3 directionToSwordsMan = (SwordsMan.getInstance().transform.position - this.transform.position).normalized;

            Debug.DrawRay(this.transform.position, directionToSwordsMan*rayDistance, Color.red);
            Debug.DrawRay(this.transform.position, lookDirection * rayDistance, Color.yellow);
            Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionLeft) * rayDistance, Color.yellow);
            Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionRight) * rayDistance, Color.yellow);

            angleFormed = MathUtilities.AngleBetweenVectors(lookDirection.normalized, directionToSwordsMan);

            if (MathUtilities.AngleBetweenVectors(lookDirection.normalized, directionToSwordsMan) >= 0 &&
                MathUtilities.AngleBetweenVectors(lookDirection.normalized, directionToSwordsMan) <= (fovAngle))
            {
                Debug.DrawRay(this.transform.position, lookDirection * rayDistance, Color.green);
                Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionLeft) * rayDistance, Color.green);
                Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionRight) * rayDistance, Color.green);
            }
            else
            {
                Debug.DrawRay(this.transform.position, lookDirection * rayDistance, Color.yellow);
                Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionLeft) * rayDistance, Color.yellow);
                Debug.DrawRay(this.transform.position, (lookDirection - fovDirectionRight) * rayDistance, Color.yellow);
            }
        }
    }
}


