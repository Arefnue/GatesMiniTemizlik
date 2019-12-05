using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private int randomNumber;
    public int speed;
    
    public GameObject scaredCat;
    private float step;
    bool isReached = false;
    private int countUp;
    
    bool faceRight = true;

    //Time
    private float timeAway = 5;
    private int timeLimit;

    //Animation
    private enum State { idle, running, scared}
    private State state = State.idle;
    Animator anim;
    

    GameMaster gm;

    private void Start() 
    {
        gm = GameMaster.GM;  
        anim = GetComponent<Animator>(); 
        randomNumber = Random.Range(0,gm.pastPos.Count); 
    }

    private void Update() 
    {
        step =  speed * Time.deltaTime;
        if(Input.touchCount>0) TouchScript();
        AnimationState();
        anim.SetInteger("state",(int)state);
        if (countUp >= 3)
        {
            state = State.scared;
        }
        if(state != State.scared)
        {
            CatMoves();
        }
        

        if(Input.GetKeyDown(KeyCode.J))
        {
            state = State.scared;
        }

    }

    void CatMoves()
    {  
        
        state = State.running;
        
        if(transform.position == gm.pastPos[randomNumber])
        {
            state = State.idle;
        }
    }

     void TouchScript()
     {
         Touch t0 = Input.GetTouch(0);
         Vector3 touch0position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
         touch0position.z = 0f;

         switch (Input.GetTouch(0).phase) 
      {
             case TouchPhase.Began:
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touch0position))
                {
                     
                    countUp += 1;
                    
                }
                 break;
             default:
                 break;
         }
     }

    void CatAway()
    {
        transform.position = Vector3.MoveTowards(transform.position,gm.window,step);


        if(transform.position == gm.window)
        {
            randomNumber = Random.Range(0,gm.pastPos.Count);
            Invoke("CatMoves",2.0f);
        }
    }

    private void Flip()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    
    private void AnimationState()
    {
        if(state == State.running)
        {
            transform.position = Vector3.MoveTowards(transform.position, gm.pastPos[randomNumber], step);
        }
        else if(state == State.scared)
        {
            CatAway();
        }
        else
        {
            state = State.idle;
        }
    }

    


    
}
