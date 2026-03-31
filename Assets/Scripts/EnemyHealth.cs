using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
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
        health--;
        if (health == 0);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
