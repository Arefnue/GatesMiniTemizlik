using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initialpoint;
    private Vector3 arranger;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 touch0position;
            Touch touch0 = Input.GetTouch(0);
            touch0position = Camera.main.ScreenToViewportPoint(touch0.position);
            touch0position.z = 0f;
            arranger.x = touch0position.x - touch0.position.x;
            arranger.y = touch0position.y - touch0.position.y;
            this.transform.localPosition = new Vector3(touch0position.x - arranger.x, touch0position.y - arranger.y, 0f);
        }
    }
    
}
