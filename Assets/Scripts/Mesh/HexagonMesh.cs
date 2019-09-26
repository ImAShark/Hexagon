using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class HexagonMesh : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    void Start()
    {
        CreateMesh();
        DrawMesh();
    }

    void CreateMesh()
    {
        vertices = new Vector3[] {
          new Vector3(0, 0, 0),     //0
          new Vector3(1, 0, 0.75f),  //1
          new Vector3(1, 0, 0),     //2
          new Vector3(2, 0, 0),     //3
          new Vector3(2, 0, -1),    //4
          new Vector3(1, 0, -1),    //5
          new Vector3(1, 0, -1.75f), //6
          new Vector3(0, 0, -1),    //7
         }; 
        triangles = new int[] {0,1,2,
                               2,1,3,
                               2,3,4,
                               5,2,4,
                               6,5,4,
                               7,5,6,
                               7,0,2,
                               7,2,5 };
    }

    void DrawMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }













    //https://www.youtube.com/watch?v=yGfS-U740x4
}

