using UnityEngine;
using System.Collections;
using WarriorsBoard.Warriors;
using WarriorsBoard.Base;
using WarriorsBoard.Warriors.AnimationStates;
using WarriorsBoard.Warriors.Attack;
using WarriorsBoard.Utils;


namespace WarriorsBoard.Warriors.EnemyDetection
{
    public class HammerManEnemyDetection : WarriorEnemyDetection
    {
        private static HammerManEnemyDetection hammerManEnemyDetection;

        public Vector3 lookDirection;
        public Vector3 fovDirection;

        public float fovAngle = 60.0f;
        public float rayDistance = 5.0f;

        public bool enemyDetected = false;


        // Use this for initialization
        void Awake()
        {
            hammerManEnemyDetection = this;
        }

        // Update is called once per frame
        void Update()
        {
                DetectEnemy();
        }

        public static HammerManEnemyDetection getInstance()
        {
            return hammerManEnemyDetection;
        }

        public override void DetectEnemy()
        {
            base.DetectEnemy();

            Vector3 directionToSwordsMan = (SwordsMan.getInstance().transform.position - this.transform.position).normalized;

            Debug.DrawRay(this.transform.position, directionToSwordsMan * rayDistance, Color.yellow);
            Debug.DrawRay(this.transform.position, (lookDirection-fovDirection) * rayDistance, Color.yellow);
            Debug.DrawRay(this.transform.position, (lookDirection + (fovDirection)) * rayDistance, Color.blue);
            Debug.Log(transform.eulerAngles.y);

            if (MathUtilities.AngleBetweenVectors(lookDirection.normalized, directionToSwordsMan) >= 0 &&
                MathUtilities.AngleBetweenVectors(lookDirection.normalized, directionToSwordsMan) <= (fovAngle/2))
            {
                enemyDetected = true;
            }
            else
                enemyDetected = false;
        }
    }
}


