using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public GameObject cat;

    public Transform[] pos;
    private int randomNumber;
    public int time;

    GameMaster gm;

    private void Start() 
    {
        gm = GameMaster.GM;    
        Invoke("SpawnCat",time);
    }

    void SpawnCat()
    {
        randomNumber = Random.Range(0,pos.Length);
        Instantiate(cat,pos[randomNumber]);
        gm.window = pos[randomNumber].position;
    }
}
