using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy_Ghost : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Get().StartCandy();
        }
    }
}
