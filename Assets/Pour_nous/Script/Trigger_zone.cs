using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_zone : MonoBehaviour
{
    GameObject gameObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
