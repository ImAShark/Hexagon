using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHexGrid : MonoBehaviour
{
    [SerializeField] private GameObject hexagon;
    [SerializeField] private int amountX, amountY;
    [SerializeField] private float height, widthOdd, widthEven, yOdd, yEven;
    private int timesX, timesY = 1;
    void Start()
    {
        for (int i = 0; i < amountY; i++)
        {
            
            Instantiate(hexagon, new Vector3( 0, 0, -height * timesY), Quaternion.identity);

            for (int j = 0; j < amountY; j++)
            {
                if (timesY%2 == 1)
                {
                    Instantiate(hexagon, new Vector3(widthOdd * timesX, 0, -yOdd * timesY), Quaternion.identity);

                }
                else if(timesY%2 == 0)
                {
                    Instantiate(hexagon, new Vector3(widthEven * timesX, 0, -yEven * timesY), Quaternion.identity);
                }
                
                timesX++;
            }
            timesY++;
            timesX = 0;
        }


    }
}
