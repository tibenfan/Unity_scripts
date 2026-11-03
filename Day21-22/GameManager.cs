using UnityEngine;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private ProbeController[] probes;
    public TMP_Text Timer;
    private float timeLimit = 15f;
    private bool allPlaced = false; 

    void Start()
    {
        
        probes = FindObjectsOfType<ProbeController>();
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
               
        
       
        allPlaced = true;
        foreach (ProbeController probe in probes)
        {
            if (!probe.isPlaced)
            {
                allPlaced = false;
                break;
            }
        }
        if (allPlaced)
        {
            Debug.Log("終了");
        }
    }

    IEnumerator CountDown() 
    {
        
        while (timeLimit > 0 && !allPlaced)
        {
            yield return new WaitForSeconds(1f);
            timeLimit -= 1;
            Debug.Log(timeLimit);
            Timer.text = "Left Time: " + timeLimit.ToString("F0") + "sec"; 
            
        }
        if (timeLimit <= 0)
        {
            Debug.Log("タイムアップ！");
            Timer.text = "Time's Up!";
        }
        
    }
}
