using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool IsPlayerOne;
    public float PlayerSpeed;
    public int PlayerHealth;
    public GameObject Projectile;
    void Start()
    {
    }

    void Update()
    {
        if (IsPlayerOne) //Controls for Player 1
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.back * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * PlayerSpeed);
            }

            if (Input.GetKey(KeyCode.Z)) //Murder Button
            {
                StartCoroutine(PlayerAttack());
            }
        }





        else //Controls for Player 2
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.back * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * PlayerSpeed);
            }

            if (Input.GetKey(KeyCode.Alpha7)) //Murder Button
            {
                StartCoroutine(PlayerAttack());
            }
        }



        if (PlayerHealth == 0)
        {
            //Game Over
        }
    }

    IEnumerator PlayerAttack()
    {
        yield return null;
    }
}
