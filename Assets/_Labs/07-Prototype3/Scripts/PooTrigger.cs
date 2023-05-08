using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PooTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxPoo;
    public Text textComponentPoo;
    public string textToDisplayPoo;
    public Image imagePoo;

    void Start()
    {
        imagePoo.enabled = false;
        textBoxPoo.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPoo.SetActive(true);
            textComponentPoo.text = textToDisplayPoo;
            imagePoo.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPoo.SetActive(false);
            imagePoo.enabled = false;
        }
    }
}
