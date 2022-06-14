using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareketi : MonoBehaviour
{
    [SerializeField] float sagSolHareketHizi;
    [SerializeField] float ziplamaGucu1;
    
    Rigidbody2D rb;
    void Start()
    {        
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float xEkseni = Input.GetAxis("Horizontal"); //x ekseni yonun de hareket
        this.transform.Translate(xEkseni * sagSolHareketHizi * Time.deltaTime, 0, 0);    //x ekseni yonun de hareket  edicek

        if (Input.GetKeyDown("space"))
        {
            karakterZiplamasi1();
        }
    }
    public void karakterZiplamasi1()
    {
        rb.AddForce(Vector2.up * ziplamaGucu1);      //karakter y eksenin de ziplama kodu
    }   
    
}
