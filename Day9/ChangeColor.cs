using UnityEngine;
using System.Collections.Generic;
public class ChangeColor : MonoBehaviour
{
  private Renderer sr;
  void Start()
  {
      sr = GetComponent<Renderer>(); //コンポーネントの取得
  }
  
  void Update()
  {
      if (Input.GetMouseButtonDown(0))
      {
          sr.material.color = new Color(Random.value, Random.value, Random.value);
      }
      if (Input.GetMouseButtonDown(2))
      {
          sr.material.color = Color.white;
      }
  }
  }
