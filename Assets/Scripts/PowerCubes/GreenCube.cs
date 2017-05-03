using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Base;
using WarriorsBoard.Tags;
using WarriorsBoard.Warriors;
using WarriorsBoard.Warriors.AnimationStates;

namespace WarriorsBoard.PowerCubes
{
    public class GreenCube : Cube
    {
        void Start()
        {

        }

        void Update()
        {
            nextDestination = new Vector3(SpearMan.getInstance().transform.position.x - transform.position.x, 0f, SpearMan.getInstance().transform.position.z - transform.position.z);
        }

        protected override void OnTriggerEnter(Collider col)
        {
            base.OnTriggerEnter(col);

            if (col.gameObject.tag == GameTags.WarriorsTags.SwordsMan.ToString())
            {
                SwordsMan.getInstance().transform.position = new Vector3(this.transform.position.x, 0.0f, transform.position.z);

                SwordsMan.getInstance().attackForce += this.forceAttack;
                SwordsMan.getInstance().RotateTowards(this.nextDestination);
                SpearManAnimationStates.getInstance().NoTranslation();

                Destroy(this.gameObject);
            }
        }
    }
}


