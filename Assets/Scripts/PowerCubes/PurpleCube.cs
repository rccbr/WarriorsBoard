using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Base;
using WarriorsBoard.Tags;
using WarriorsBoard.Warriors;

namespace WarriorsBoard.PowerCubes
{
    public class PurpleCube : Cube
    {
        public GreenCube greenCube;

        public bool generateGreen;

        void Start()
        {

        }

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

                SpearMan.getInstance().transform.Rotate(Vector3.up, 21.94f);

                if (generateGreen)
                    Instantiate(greenCube, this.nextDestination+this.transform.position, Quaternion.identity);

                Destroy(this.gameObject);
            }
        }
    }
}

   
