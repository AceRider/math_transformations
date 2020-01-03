﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateE : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.transform.forward = HolisticMath.Rotate(new Coords(this.transform.forward, 0),
                                                  1 * Mathf.Deg2Rad, false,
                                                  1 * Mathf.Deg2Rad, false,
                                                  1 * Mathf.Deg2Rad, false).ToVector();
    }
}
