using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{


    // Use this for initialization
    void Start()
    { }

    // Update is called once per frame
    void Update()
    { }
    public AudioClip sound01;


    void OnTriggerStay(Collider other) //OnTriggerStay continues to be called when an object is slipping through.
    {
        if (other.gameObject.CompareTag("WallF"))
        {
            GetComponent<AudioSource>().PlayOneShot(sound01);
        }
        if (other.gameObject.CompareTag("WallB"))
        {
            GetComponent<AudioSource>().PlayOneShot(sound01);
        }
        if (other.gameObject.CompareTag("WallR"))
        {
            GetComponent<AudioSource>().PlayOneShot(sound01);
        }
        if (other.gameObject.CompareTag("WallL"))
        {
            GetComponent<AudioSource>().PlayOneShot(sound01);
        }
    }
}