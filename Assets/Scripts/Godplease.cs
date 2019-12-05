using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godplase : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 arranger;
    bool t = false;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t0 = Input.GetTouch(0);
        }
        Vector3 touch0position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        touch0position.z = 0f;

        switch (Input.GetTouch(0).phase)
        {
            case TouchPhase.Began:
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch0position))
                {
                    arranger = touch0position - transform.position;
                    t = true;
                }
                break;
            case TouchPhase.Moved:
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch0position) && t)
                {
                    transform.position = touch0position - arranger;

                }
                break;

            case TouchPhase.Ended:
                t = false;
                break;
            default:
                break;
        }
    }
}