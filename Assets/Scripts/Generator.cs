using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{   
    [Header ("Prefabs")]
    //Objeleri al
    public List<GameObject> books;
    public List<GameObject> garbages;
    public List<GameObject> dirties;

    // the range of X
    [Header ("X Spawn Range")]
    public float xMin;
    public float xMax;
  
    // the range of y
    [Header ("Y Spawn Range")]
    public float yMin;
    public float yMax;
    
    //Limitation
    [Header ("Limitation")]
    public int booksLimit;
    public int garbagesLimit;
    public int dirtiesLimit;
    
    GameMaster gm;

    private void Start() 
    {
        gm = GameMaster.GM;

        SpawnObjects("books",booksLimit);
        SpawnObjects("garbages",garbagesLimit);
        SpawnObjects("dirties",dirtiesLimit);
               
    }

    void SpawnObjects(string objectName,int limit)
    {
        // Defines the min and max ranges for x and y
        

        for (int i = 0; i < limit; i++)
        {
            Vector3 pos = new Vector3 (Random.Range (xMin, xMax), Random.Range (yMin, yMax));
            
            gm.pastPos.Add(pos);

            if(objectName == "books")
            {
                GameObject objectSpawned = books[Random.Range(0, books.Count)];
                Instantiate(objectSpawned, pos, Quaternion.identity);

            }
            else if(objectName == "dirties")
            {
                GameObject objectSpawned = dirties[Random.Range(0, dirties.Count)];
                Instantiate(objectSpawned, pos, Quaternion.identity);
            }
            else if(objectName == "garbages")
            {
                GameObject objectSpawned = garbages[Random.Range(0, garbages.Count)];
                Instantiate(objectSpawned, pos, Quaternion.identity);
            }
        }
        
    }

}
