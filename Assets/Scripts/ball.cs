using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private gameManager gm;
    private void Awake()
    {
        gm = GetComponentInParent<gameManager>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Goal")
        {
            gm.win();
        } else if(col.gameObject.tag == "Trap")
        {
            gm.destroyBall();
        } else if (col.gameObject.tag == "Cp")  
        {
            Debug.Log("oui");
            gm.save = col.GetComponent<cps>().vec;
        }
    }
}
