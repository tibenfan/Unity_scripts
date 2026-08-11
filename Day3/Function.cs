using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //関数を作る
    //関数名(引数の名前と型)｛処理｝
    void Greet(string name) //関数名”Greet”
    {
        Debug.Log("こんにちは、" + name + "！");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Greet("サーキー");
        }
    }
    
}
