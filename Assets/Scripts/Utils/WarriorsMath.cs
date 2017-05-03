using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Utils
{
    public static class MathUtilities
    {
        public static float FindOrientationVector(Transform gameObjForward, float angle)
        {
            float orientVec;

            Vector2 forw = new Vector2(gameObjForward.position.normalized.x, gameObjForward.position.normalized.z);

            return orientVec = 0;
        }

       public static float VectorLength(Vector3 vec)
        {
            return Mathf.Sqrt(Mathf.Pow(vec.x,2.0f) + Mathf.Pow(vec.y,2.0f) + Mathf.Pow(vec.z,2.0f));
        }

        public static float VectorDot(Vector3 a, Vector3 b)
        {
            return ((a.x*b.x) + (a.y*b.y) + (a.z*b.z));
        }

        public static float AngleBetweenVectors(Vector3 a, Vector3 b)
        {
            return Mathf.Acos(VectorDot(a, b)) * (180.0f/Mathf.PI);
        }
    }
}

