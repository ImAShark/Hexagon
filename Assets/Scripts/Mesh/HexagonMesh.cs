using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class HexagonMesh : MonoBehaviour
{
    Mesh mesh;

    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    void Start()
    {

    }













    //https://www.youtube.com/watch?v=yGfS-U740x4
}

