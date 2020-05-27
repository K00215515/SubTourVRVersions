using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinking : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public ParticleSystem Smoke;
    public new AudioSource audio;
    private IEnumerator coroutine;
    void Start() 
    {
        Smoke.Stop();
        audio.Stop();
    }


    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Ship")
        {
            StartCoroutine(Delay());
            anim.Play("sinking");
            Smoke.Play();
            Destroy(gameObject);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            audio.Play();
        }
        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Delay Collision");
    }
}
