using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductTest : MonoBehaviour
{
    public Transform enemy;

	void Start ()
    {
		
	}

    void Update()
    {
        Debug.Log(this.transform.forward);
        Debug.Log(transform.position);
        Vector3 localFwd = new Vector3(transform.forward.x, transform.forward.y, Vector3.forward.z * transform.position.z);

        Debug.Log(localFwd);
        Debug.Log(enemy.transform.forward);
        Debug.Log(Vector3.Dot(this.transform.forward, enemy.transform.forward));

        if ((Vector3.Dot(this.transform.forward, enemy.transform.forward)) == -1)
        {
            Debug.Log("Detected Enemy");
        }
    }
}
