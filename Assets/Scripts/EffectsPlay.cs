using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsPlay : MonoBehaviour
{
    public AudioSource hit;
    [SerializeField] private ParticleSystem smoke;
    [SerializeField] private ParticleSystem smokes;
    void Start()
    {
        smoke.Stop();
        smokes.Stop();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Untagged"))
        {
            hit.Play();
            smoke.Play();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            smokes.Play();
        }
    }
}
