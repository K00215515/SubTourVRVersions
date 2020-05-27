using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LivingQ")
        {
            SceneManager.LoadScene("LivingQuarters");
        }
        else if (other.gameObject.tag == "OutsideS")
        {
            SceneManager.LoadScene("OutsideScene");
        }
        else if (other.gameObject.tag == "ControlR")
        {
            SceneManager.LoadScene("LaunchTorpedo");
        }
    }
}
