using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime;

    public TextMeshProUGUI timeCounter;

    private void Update() {
        TimeCount();
    }
    private void TimeCount()
    {
        startTime -= Time.deltaTime;
        
        timeCounter.text = Mathf.Round(startTime).ToString();

        if(startTime <= 0)
        {
            // SceneScripts _scene = GameObject.FindGameObjectWithTag("Scripts").GetComponent<SceneScripts>();
            // _scene.ChangeScene(nextScene);
        }
    }
}
