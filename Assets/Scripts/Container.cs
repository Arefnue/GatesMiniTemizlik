using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    // Start is called before the first frame update
    //private BoxCollider2D collider2D;
    public int conID;
    public ParticleSystem l1, b1, t1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (collider2D.bounds.Intersects(other.bounds)){
        
        if (other.CompareTag("Book"))
        {
            if (conID == 0)
            {
                Destroy(other.gameObject);
                //b1.enableEmission = true;
                b1.enableEmission = true;
                
            }
        }
        // }
        //if (collider2D.bounds.Intersects(other.bounds)){
        if (other.CompareTag("Dirty"))
        {
            if (conID == 1)
            {
                Destroy(other.gameObject);

                l1.enableEmission = true;


            }
        }
        // }
        //if (collider2D.bounds.Intersects(other.bounds)){
        if (other.CompareTag("Garbage"))
        {
            if (conID == 2)
            {
                Destroy(other.gameObject);
                t1.enableEmission=true;

            }
        }
        
        // }
    }
    void turnoff()
    {
        b1.enableEmission = false;
        t1.enableEmission = false;
        l1.enableEmission = false;

    }
    private void Start()
    {
        InvokeRepeating("turnoff", 2, 2);
    }
}
