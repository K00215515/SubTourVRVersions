using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinking : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public ParticleSystem Smoke;
    void Start() 
    {
        Smoke.Stop();
    }


    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Ship")
        {
            anim.Play("sinking");
            Smoke.Play();
            Destroy(gameObject);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
