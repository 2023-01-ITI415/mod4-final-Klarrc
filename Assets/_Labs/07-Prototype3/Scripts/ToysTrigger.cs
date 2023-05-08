using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToysTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxToy;
    public Text textComponentToy;
    public string textToDisplayToy;
    public Image imageToy;

    void Start()
    {
        imageToy.enabled = false;
        textBoxToy.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxToy.SetActive(true);
            textComponentToy.text = textToDisplayToy;
            imageToy.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxToy.SetActive(false);
            imageToy.enabled = false;
        }
    }
}
