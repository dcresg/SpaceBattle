using UnityEngine;

public class finpartida : MonoBehaviour
{

    public Canvas myCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
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
            myCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
} 
