using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        myTransform.Rotate(1.0f, 1.0f, 1.0f);
    }
}
