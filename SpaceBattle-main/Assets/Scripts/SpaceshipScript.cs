using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpaceshipScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject EnemyPrefab;

    float timer = 0;
    int cooldown = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.D) && transform.position.x < 6.9f)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -6.9f)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && cooldown <= 0)
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f , transform.position.z);

            

            cooldown = 200;
        }

        if (timer > 2f)
        {
            timer = 0f;

            GameObject newEnemy = Instantiate(EnemyPrefab);

            newEnemy.transform.position = new Vector3(Random.Range(-6.9f, 6.9f), 11f);
        }



        cooldown--;
    }
}
