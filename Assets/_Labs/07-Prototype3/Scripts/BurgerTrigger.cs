using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject textBoxBurger;
    public Text textComponentBurger;
    public string textToDisplayBurger;
    public Image imageBurger;

    void Start()
    {
        imageBurger.enabled = false;
        textBoxBurger.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxBurger.SetActive(true);
            textComponentBurger.text = textToDisplayBurger;
            imageBurger.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            textBoxBurger.SetActive(false);
            imageBurger.enabled = false;
        }
    }
}
