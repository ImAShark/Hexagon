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
        vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0), new Vector3(1, 0, 1),
        };
        triangles = new int[] {0,1,2,2,1,3};
    }

    void DrawMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }













    //https://www.youtube.com/watch?v=yGfS-U740x4
}

