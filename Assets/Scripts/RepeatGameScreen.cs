using UnityEngine;

public class RepeatGameScreen : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 8.0f + repeatWidth)
        {
            transform.position = new Vector3(-38.5f, 20.5f, Random.Range(12.47f, 12.5f));
        }
    }
}
