using UnityEngine;

public class RepeatGameScreen : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < startPos.y - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
