using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latest : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Laundry, Trash, BookShelf;
    Vector3 arranger;
    bool t = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touchCount > 0) { Touch t0 = Input.GetTouch(0); }
            
            Vector3 touch0position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touch0position.z = 0f;

            switch (Input.GetTouch(0).phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch0position))
                    {

                        //gameObject.GetComponent<ParticleSystem>().enableEmission = true;
                        arranger = touch0position - transform.position;
                        t = true;

                    }
                    break;
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch0position) && t)
                    {
                        transform.position = touch0position - arranger;
                        //gameObject.GetComponent<ParticleSystem>().enableEmission = true;
                    }
                    break;

                case TouchPhase.Ended:
                    t = false;
                    //gameObject.GetComponent<ParticleSystem>().enableEmission = false;
                    /*switch (tag)
                    {
                        case "Book":
                            if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(BookShelf.transform.position))
                            {
                                Destroy(gameObject);
                            }
                            break;
                        case "Garbage":
                            if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(Trash.transform.position))
                            {
                                Destroy(gameObject);
                            }
                            break;
                        case "Dirty":
                            if(GetComponent<Collider2D>() == Physics2D.OverlapPoint(Laundry.transform.position))
                            {
                                Destroy(gameObject);
                            }
                            break;
                        default:
                            break;
                    }*/
                    break;
                default:
                    break;
            }
        }
    }
}