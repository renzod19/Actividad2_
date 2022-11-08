using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour { 

    [SerializeField]
    private Vector3 axes;
    public float ScaleUnits;

    void Udate()
    {
        axes = capsule_mov.ClampVector3(axes);
        transform.localScale += axes * (ScaleUnits * Time.deltaTime);
    }
}
   