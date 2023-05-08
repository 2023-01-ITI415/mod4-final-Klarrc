using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NessTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBox;
    public Text textComponent;
    public string textToDisplay;
    public Image image;

    void Start()
    {
        image.enabled = false;
        textBox.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBox.SetActive(true);
            textComponent.text = textToDisplay;
            image.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBox.SetActive(false);
            image.enabled = false;
        }
    }
}
