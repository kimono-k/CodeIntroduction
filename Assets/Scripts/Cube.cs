using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;


/**
 * Definition of the cube class, MonoBehaviour is the base class.
 */
public class Cube : MonoBehaviour
{
    // Variables
    public float sizeModifier = 0.9f;
    public string newName = "Hyuna";
    public bool isRotated = false;

    // Used for initalization
    void Start ()
    {
        transform.name = ImproveName(newName); // Renames the cube GameObject.

        if (!isRotated)
        {
            transform.localEulerAngles = Vector3.one * 45; // 1, 1, 1 * 45, tilt the cube on 3-axes.
        }
    }

    // Called once per frame, a game loop, 60 FPS.
    void Update()
    {
        transform.localScale = Vector3.one * sizeModifier; // Makes the cube bigger
    }

    string ImproveName(string originalString)
    {
        return "-[" + originalString + "]-";
    }
}
