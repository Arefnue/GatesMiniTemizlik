using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Dragdrop : MonoBehaviour, IDragHandler,IDropHandler,IBeginDragHandler
{
    // Start is called before the first frame update
    private Transform initialpoint;
    private Vector3 arranger;
    private bool t;
    private float sizex,sizey;
    private BoxCollider2D collider;

    bool isColliding;


    public TouchPhase Touch;
    // Update is called once per frame
    /*void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 touch0position;
            Touch touch0 = Input.GetTouch(0);
            touch0position = Camera.main.ScreenToViewportPoint(touch0.position);
            touch0position.z = 0f;
            //arranger.x = touch0position.x - touch0.position.x;
            //arranger.y = touch0position.y - touch0.position.y;
            transform.position = touch0position;
        
    }*/
    private void Start()
    {
        initialpoint = transform;
        collider = GetComponent<BoxCollider2D>();
        sizex = collider.size.x / 2;
        sizey = collider.size.y / 2;
        Debug.Log("hadiiii");
    }
    public void OnDrag(PointerEventData eventData)
    {
        isColliding = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        isColliding = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isColliding = false;
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {


            Vector3 touch0position;
            Touch touch0 = Input.GetTouch(0);
            touch0position = Camera.main.ScreenToViewportPoint(touch0.position);
            touch0position.z = 0f;
            //arranger.x = touch0position.x - touch0.position.x;
            //arranger.y = touch0position.y - touch0.position.y;
            Debug.Log("hadi");
            if (isColliding)
            {
                arranger = touch0position - transform.position;
                t = true;
                Debug.Log("amk");
            }
            if (isColliding&&t)
            {  
                    transform.position = touch0position - arranger;    
            }
            else
            {
                t = false;
            }


        }

    }

   
}
