using UnityEngine;
using System.Collections;

public class BossMovement : MonoBehaviour
{
    public Vector3 pointB;
    public GameObject Projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        StartCoroutine(EnemyAttack());
        StartCoroutine(Start2());
    }
    IEnumerator Start2()
    {
        var pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f));
        }

    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }

    IEnumerator EnemyAttack()
    {
        Instantiate(Projectile, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(EnemyAttack());
    }
}
