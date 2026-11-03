using UnityEngine;

public class ProbeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isDragging = false;
    public string targetSlotName; // 対応するスロットの名前（例："Slot_V1"）
    private Vector2 startPosition; // ドラッグ開始前の元の位置
    public bool isPlaced = false;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //左クリックが押されたとき
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //座標の取得
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
            }
        }
        if (Input.GetMouseButton(0))
        {
            if(isDragging)
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //座標の取得
                transform.position = new Vector2(mousePos.x, mousePos.y); //座標の更新


            }
        }
        if (Input.GetMouseButtonUp(0)) //左クリックが離されたとき
        {
            isDragging = false;
            
            // 対応するスロットを探す
            GameObject slot = GameObject.Find(targetSlotName);
            if (slot != null)
            {
                // スロットとの距離を計算
                float distance = Vector2.Distance(transform.position, slot.transform.position);
                if (distance < 0.5f)
                {
                    // 近ければスロットにはまり込む
                    transform.position = slot.transform.position;
                    isPlaced = true;
                }
                else
                {
                    // 遠ければ元の位置に戻る
                    transform.position = startPosition;
                    isPlaced = false;
                }
            }
        }
    }
}
