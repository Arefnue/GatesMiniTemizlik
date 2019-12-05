using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    private SpriteRenderer rend;
    private BoxCollider2D collider;
    

    public Sprite[] tileGraphics;

    public float hoverAmount;

    //Positions
    private float minX;
    private float maxX;
    private float minY;
    private float maxY;
    private float lenX;
    private float lenY;
    private float reckX;
    private float reckY;

    GameMaster gm;

    private void Start() {
        rend = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
        
        gm = GameMaster.GM;

        int ranTile = Random.Range(0,tileGraphics.Length);
        rend.sprite = tileGraphics[ranTile];

        CreateColliderForEverySprite();
        
    }


    private void OnMouseEnter() {
        transform.localScale += Vector3.one * hoverAmount;
    }
    private void OnMouseExit() {
        transform.localScale -= Vector3.one * hoverAmount;
    }


    public void CreateColliderForEverySprite()
    {   
        minX = -rend.bounds.extents.x;//Distance to the left side
        maxX = rend.bounds.extents.x; //Distance to the right side, from your center point
        lenX = (maxX - minX);
        reckX = lenX/transform.localScale.x;
        minY = -rend.bounds.extents.y; //Distance to the bottom
        maxY = rend.bounds.extents.y; //Distance to the top
        lenY = (maxY - minY);
        reckY = lenY/transform.localScale.y;

       
        collider.size = new Vector3(reckX,reckY,0);
    }

    
    
}
