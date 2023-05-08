using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokeyTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxPokey;
    public Text textComponentPokey;
    public string textToDisplayPokey;
    public Image imagePokey;

    void Start()
    {
        imagePokey.enabled = false;
        textBoxPokey.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPokey.SetActive(true);
            textComponentPokey.text = textToDisplayPokey;
            imagePokey.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPokey.SetActive(false);
            imagePokey.enabled = false;
        }
    }
}
