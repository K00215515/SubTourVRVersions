using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoScript : MonoBehaviour
{
    [SerializeField] private Animator anim;
    //private GameObject gameObject;
    private GameObject Torpedo;

    void Start()
    {
        anim = GetComponent<Animator>();

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("LTorpedo"))
        {
            anim.SetTrigger("fire");
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "LTorpedo")
    //    {
    //        anim.SetBool("play", true);
    //        Torpedo.GetComponent<Animation>().Play("torpedo");

    //        anim.SetTrigger("fire");
    //    }
    //}
}
