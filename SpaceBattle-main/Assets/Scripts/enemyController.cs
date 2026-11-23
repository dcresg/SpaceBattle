using UnityEngine;

public class enemyController : MonoBehaviour
{
    Rigidbody2D rb;
    private GameObject canvasGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        canvasGO = GameObject.FindGameObjectWithTag("canvas_gameover");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }

        if (collision.gameObject.tag == "player")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
