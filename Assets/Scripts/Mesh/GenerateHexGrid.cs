using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHexGrid : MonoBehaviour
{
    [SerializeField] private GameObject hexagon;
    [SerializeField] private float height, width;

    private float xOffset = 2.05f, zOffset = 1.8f;
    void Start()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                if (z % 2 == 0)
                {
                    Instantiate(hexagon, new Vector3(x * xOffset, 0, z * zOffset), Quaternion.identity);
                }
                else
                {
                    Instantiate(hexagon, new Vector3(x * xOffset + xOffset / 2, 0, z * zOffset), Quaternion.identity);
                }
            }

        }


    }
}
