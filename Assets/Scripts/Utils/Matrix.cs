using UnityEngine;
using System.Collections;

namespace WarriorsBoard.Utils
{
    public class Matrix:MonoBehaviour
    {
        public int rows;
        public int columns;

        public float[,] dim2x2MatrixOutput = new float[,] { { 0, 0 }, { 0, 0 } };

        void Start()
        {
            BuildSquareMatrix();
        }

        void BuildSquareMatrix()
        {
            float[,] dim2x2Matrix45Angle = new float[,] { { Mathf.Cos(45f), -Mathf.Sin(45f) }, { Mathf.Sin(45f), Mathf.Cos(45f) } };

            Debug.Log(Mathf.Cos(45.0f));

            rows = 2;
            columns = 2;

            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= columns - 1; j++)
                {
                    dim2x2MatrixOutput[i, j] = dim2x2Matrix45Angle[i, j];

                    Debug.Log("Output: " + i + "," + j + "= " + dim2x2MatrixOutput[i, j]);
                }
            }
        }

        void GenerateMatrixOutput(Matrix first, Matrix second)
        {

        }
    }
}


