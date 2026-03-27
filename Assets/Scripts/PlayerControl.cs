using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool IsPlayerOne;
    void Start()
    {
        
    }

    void Update()
    {
        if (IsPlayerOne) //Controls for Player 1
        {
            if (Input.GetKeyUp(KeyCode.W))
            {

            }
        }
        else //Controls for Player 2
        {

        }
    }
}
