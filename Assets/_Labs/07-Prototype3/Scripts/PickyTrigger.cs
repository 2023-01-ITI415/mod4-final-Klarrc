using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickyTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxPicky;
    public Text textComponentPicky;
    public string textToDisplayPicky;
    public Image imagePicky;

    void Start()
    {
        imagePicky.enabled = false;
        textBoxPicky.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPicky.SetActive(true);
            textComponentPicky.text = textToDisplayPicky;
            imagePicky.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPicky.SetActive(false);
            imagePicky.enabled = false;
        }
    }
}
