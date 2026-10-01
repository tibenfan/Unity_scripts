using UnityEngine;
using System.Collections.Generic;
public class TraceInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private List<Vector2> tracePoints = new List<Vector2>();
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //マウスを押し続けている間、毎フレーム tracePoints にマウスの座標を追加する
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tracePoints.Add(mousePos);

            lineRenderer.positionCount = tracePoints.Count;
            for (int i = 0; i < tracePoints.Count; i++)
            {
                lineRenderer.SetPosition(i, tracePoints[i]);
            }
        }
        //マウスを離したら tracePoints をクリアする
        // そして、Y=0からの距離の平均を計算してログに出力する
        if (Input.GetMouseButtonUp(0))
        {
            float totalError = 0f;
            foreach (Vector2 point in tracePoints)
            {
                totalError += Mathf.Abs(point.y); // Y=0からの距離
            }
            float averageError = totalError / tracePoints.Count;
            Debug.Log("平均誤差：" + averageError);
            tracePoints.Clear();
        }
    }
}
