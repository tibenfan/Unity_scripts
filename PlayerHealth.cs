using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //è’ìÀîªíË
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Ç‘Ç¬Ç©ÇÁÇÍÇΩÇÁè¡Ç¶ÇÈ
        Destroy(gameObject);
        Debug.Log("Game Over");
    }
}
