using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool IsPlayerOne;
    public float PlayerSpeed;
    public int PlayerHealth;
    public GameObject Projectile;
    private bool OffCooldown = true;
    private Vector3 ProjectileOffset = new Vector3(0,0.275f,0);
    public GameObject GameOverScreen;

    void Start()
    {
    }

    void Update()
    {
        if (IsPlayerOne) //Controls for Player 1
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < 25)
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x < 5.1f)
            {
                transform.Translate(Vector3.back * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > 16)
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x > -4)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * PlayerSpeed);
            }

            if (Input.GetKeyDown(KeyCode.Z) && OffCooldown == true) //Murder Button
            {
                StartCoroutine(PlayerAttack());
            }
        }





        else //Controls for Player 2
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 25)
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 5.1f)
            {
                transform.Translate(Vector3.back * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 16)
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -4)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * PlayerSpeed);
            }

            if (Input.GetKeyDown(KeyCode.Alpha7) && OffCooldown == true) //Murder Button
            {
                StartCoroutine(PlayerAttack());
            }
        }



        if (PlayerHealth == 0)
        {
            GameOverScreen.SetActive(true);
            //Game Over
        }
    }

    IEnumerator PlayerAttack()
    {
        OffCooldown = false;
        Debug.Log("Falsed");
        Instantiate(Projectile, transform.position + ProjectileOffset, Quaternion.identity);
        ProjectileOffset = ProjectileOffset * -1;
        yield return new WaitForSeconds(0.25f);
        OffCooldown = true;
        Debug.Log("Trued");
    }
}
