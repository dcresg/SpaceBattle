using UnityEngine;

public class enemyController : MonoBehaviour
{
    [SerializeField] public GameObject enemyBullet;
    Rigidbody2D rb;
    float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
            
        timer += Time.deltaTime;

        if (timer > 0.8f)
        {
            timer = 0f;

            GameObject newEnemy = Instantiate(enemyBullet);

            newEnemy.transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
        }
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
