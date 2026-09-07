using UnityEngine;

public class DragObject : MonoBehaviour
{
    private bool isDragging = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            // Add your code here to handle the mouse button down event
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null)
            {
                isDragging = true;
            }

        }
        if (Input.GetMouseButton(0))
        {
            if (isDragging)
            {
                // Add your code here to handle the mouse button hold event
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(mousePos.x, mousePos.y);
            }
        } 
        if (Input.GetMouseButtonUp(0))
        {
            // Add your code here to handle the mouse button up event
            if(isDragging)
            {
                isDragging = false;
            }
                     
               
        }
    }


}
