using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionassign : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform container;
    void Start()
    {
        transform.position = container.position;
    }


    // Update is called once per frame
    
}
