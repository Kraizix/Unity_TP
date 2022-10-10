using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class maze : MonoBehaviour
{
    private gameManager gm;
    private void Awake()
    {
        gm = GetComponentInParent<gameManager>();
    }
    void Update()
    {
        float moveZ = Input.GetAxis("Horizontal") * Time.deltaTime * 30;
        float moveX = Input.GetAxis("Vertical") * Time.deltaTime * 30;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x - moveX, 0, transform.eulerAngles.z + moveZ);
    }
    
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Ball")
        {
            gm.destroyBall();
        } 
    }
}
