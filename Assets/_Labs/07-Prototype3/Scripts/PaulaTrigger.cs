using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaulaTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxPaula;
    public Text textComponentPaula;
    public string textToDisplayPaula;
    public Image imagePaula;

    void Start()
    {
        imagePaula.enabled = false;
        textBoxPaula.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPaula.SetActive(true);
            textComponentPaula.text = textToDisplayPaula;
            imagePaula.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxPaula.SetActive(false);
            imagePaula.enabled = false;
        }
    }
}
