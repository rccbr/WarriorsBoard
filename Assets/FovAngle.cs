using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarriorsBoard.Utils;

public class FovAngle : MonoBehaviour
{
    public Vector3 lookDirection;
    public Vector3 fovDirection;

    public float fovAngle = 30.0f;
    public float rayDistance = 5.0f;

    public bool enemyDetected = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DetectEnemy()
    {
        Debug.DrawRay(this.transform.position, transform.forward * rayDistance, Color.yellow);
        Debug.DrawRay(this.transform.position, (lookDirection - fovDirection) * rayDistance, Color.yellow);
        Debug.DrawRay(this.transform.position, (lookDirection - (-fovDirection)) * rayDistance, Color.blue);

        Debug.Log(transform.eulerAngles.y);

        if (MathUtilities.AngleBetweenVectors(lookDirection.normalized, transform.forward) > fovAngle)
        {
            Debug.Log("Inside Field of View");
        }
    }
}
