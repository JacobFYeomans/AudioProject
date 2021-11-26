using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{

    public AudioSource source;
    public GameObject trigger;

    private void OnTriggerEnter(Collider collision)
    {
        source.Play();
        trigger.SetActive(false);
    }
}
