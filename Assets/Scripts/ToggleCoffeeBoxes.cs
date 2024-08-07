using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCoffeeBoxes : MonoBehaviour
{
    public GameObject cofee_box01;
    public GameObject cofee_box02;

    void Start()
    {
        cofee_box01.SetActive(true);
        cofee_box02.SetActive(false);
    }

    void OnMouseDown()
    {
        cofee_box01.SetActive(false);
        cofee_box02.SetActive(true);
    }
}

