using UnityEngine;

public class TraceManager : MonoBehaviour
{
    private bool isTracing = false;
    private LineRenderer lineRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //座標変換
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        //左クリックでisTracingをtrueにする
        if (Input.GetMouseButtonDown(0))
        {
            isTracing = true;

        }
        //ドラッグ時の挙動
        if(Input.GetMouseButton(0))
        {
            if(isTracing)
            {
                //ドラッグ中の処理
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, mousePos);
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            isTracing = false;
            float totalError = 0f;
            for (int i = 0; i < lineRenderer.positionCount; i++)
            {
                Vector3 point = lineRenderer.GetPosition(i);
                totalError += Mathf.Abs(point.y);
            }
            float averageError = totalError / lineRenderer.positionCount;
            float score = Mathf.Max(0, 100 - averageError * 10);
            Debug.Log("精度スコア：" + score.ToString("F1"));
        }
    }
}
