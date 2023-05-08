using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DawgTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxDog;
    public Text textComponentDog;
    public string textToDisplayDog;
    public Image imageDog;

    void Start()
    {
        imageDog.enabled = false;
        textBoxDog.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxDog.SetActive(true);
            textComponentDog.text = textToDisplayDog;
            imageDog.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxDog.SetActive(false);
            imageDog.enabled = false;
        }
    }
}
