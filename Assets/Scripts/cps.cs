using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cps : MonoBehaviour
{
    public Vector3 vec;

    void Start()
    {
        var pos= transform.position;
        vec = new Vector3(pos.x, 1, pos.z);
    }
}
