using UnityEngine;
using System.Collections;
using WarriorsBoard.Base;
using WarriorsBoard.Tags;
using WarriorsBoard.Warriors;

namespace WarriorsBoard.PowerCubes
{
    public class RedCube : Cube
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnTriggerEnter(Collider col)
        {
            base.OnTriggerEnter(col);

            if (col.gameObject.tag == GameTags.WarriorsTags.SwordsMan.ToString())
            {
                SwordsMan.getInstance().transform.position = new Vector3(this.transform.position.x, 0.0f, transform.position.z);

                SwordsMan.getInstance().attackForce += this.forceAttack;
                SwordsMan.getInstance().RotateTowards(this.nextDestination);

                Destroy(this.gameObject);
            }
        }
    }
}


