using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public Transform target; //takip edecegi obje
    public Vector3 offset;   //takip etme mesafe aral�g�
   
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
           target.position + offset, Time.deltaTime * 2);
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
