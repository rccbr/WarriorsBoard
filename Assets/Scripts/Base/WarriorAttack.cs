using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Base
{
    public class WarriorAttack : MonoBehaviour
    {
        public virtual void CheckEnemyDirection(Warrior enemy)
        {
            Debug.Log("Checking " + enemy.gameObject.name + " direction...");
        }
    }
}

