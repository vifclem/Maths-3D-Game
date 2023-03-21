
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeMatrix : MonoBehaviour
{
    public float [,] MatrixIdentity = new float[3, 3];
    public float[,] Matrix = new float[3, 3];
    public float[,] Matrix1 = new float[3, 3];

    public Vector3 Vector = new Vector3(1,2,2);


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            MatrixIdentity[i, i] = 1.0f;
        }

        for(int i=0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Matrix[i, j] = Random.Range(1,10);
            }
        }


        PrintMatrix();
        
    }

   void PrintMatrix()
    {
        //print(Matrix[0,0] + "" + Matrix[0,1] + "" + Matrix[0,2]);
        for(int i = 0; i < 3; i++)
        {
            string result = "";
            for(int j = 0; j < 3; j++)
            {
                result += Matrix[i, j] + " ";
                //print(Matrix[i,j]);
            }
            Debug.Log(result);
        }
    }

    public Vector3 MultipleByVector(float[,] matrix, Vector3 vector)
    {
        Vector3 result = Vector3.zero;
        if(matrix != null)
        {
            for (int i = 0; i < 3; i++)
            {
                float stock = 0;
                for (int j = 0; j < 3; j++)
                {
                    stock = Matrix[i, j] * vector[j];
                    result[j] += stock;
                }


            }
            
        }
        return result;


    }

    public float[,] MultiplieByMatrix(float[,] matrix, float[,] matrix1)
    {
        float [,] resultMatrix = new float[3, 3];

        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix [i, j] = matrix [i, j] * matrix1[i,j];
            }
        }
        return (resultMatrix);
    }

    void MatrixAdd()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
