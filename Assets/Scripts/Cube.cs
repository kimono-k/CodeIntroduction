using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Definition of the cube class, MonoBehaviour is the base class.
 */
public class Cube : MonoBehaviour
{
    // Variables
    public float sizeModifier = 2.5f;
    public string newName = "Hyuna";
    public bool isRotated = false;

    // Used for initalization
    void Start ()
    {
        transform.name = ImproveName(newName); // Renames the cube GameObject.
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
