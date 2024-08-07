using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCupsBoxes : MonoBehaviour
{
    public GameObject cups_box01;
    public GameObject cups_box02;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cups_box01.SetActive(false);
            cups_box02.SetActive(true);
        }
    }
}

