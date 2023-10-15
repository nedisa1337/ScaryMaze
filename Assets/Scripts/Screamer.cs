using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screamer : MonoBehaviour
{
    private AudioSource aS;
    public GameObject img;
    public GameObject Player;
    private void Start()
    {
        aS = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            img.SetActive(true);
            aS.Play();
            Destroy(Player);
        }
    }
}
