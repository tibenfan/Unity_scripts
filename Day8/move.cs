using UnityEngine;
using System.Collections.Generic;
public class TraceInput : MonoBehaviour
{
  public float speed = 5f;
  void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            //デフォルトは右→左
            //逆方向の場合は-speed * Time.deltaTime
        }
    }
    //このスクリプトをオブジェクトにアタッチしてください。
}
