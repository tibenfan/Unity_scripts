using UnityEngine;
using System.Collections.Generic;
public class collision : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision)
	{
	  //AがBにぶつかることを想定
		//ぶつかられたBを消す 
		Destroy(gameObject);
	  //ぶつかってきたAを消す
	  Destroy(collision.gameObject);
	}
	 //このスクリプトをオブジェクトBにアタッチしてください。
}
