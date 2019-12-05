using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class NewDragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemdraged;
    Vector3 startposition;
    Transform startparent;
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemdraged = gameObject;
        startposition = transform.position;
        startparent = transform.parent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
            itemdraged = null;
        if (transform.parent != startparent)
        {
            transform.position = startposition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
