using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public Rigidbody fodderRb;
    public Rigidbody bossRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "playerproj")
        {
            health--;
            Destroy(other.gameObject);
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
