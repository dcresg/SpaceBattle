using UnityEngine;

public class finpartida : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy") 
        {
            Destroy(GameObject.FindGameObjectWithTag("player"));
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "enemyBullet")
        {
            Destroy(collision.gameObject);
        }
    }
} 
