using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
	//public Text Info;
	//public GameObject gameObject;

	//void start(){
		//Info.enabled(false); not working
		//Info.gameObject.SetActive(false);
	//}
	//void OnCollisionEnter(Collision col)
	//{
		//if(col.gameObject.name == "RigidBodyFPSController1")
		//{
		//	SceneManager.LoadScene("LivingQuarters");
		//}
		//if(col.gameObject.name == "RigidBodyFPSController2")
		//{
		//	SceneManager.LoadScene("OutsideScene");
		//}
        //if (col.gameObject.name == "RigidBodyFPSController1")
        //{
         //   SceneManager.LoadScene("LaunchTorpedo");
        //}
        //Info.gameObject.SetActive(true);
    //}


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


    //private void OnTriggerEnter(Collider other){
    //	if(other.gameObject.tag == "DisplayButton")
    //	{
    //Info.gameenabled = true;	not working
    //Info.gameObject.SetActive(true);
    //	}
    //	if(other.gameObject.tag == "LivingButton")
    //	{
    //		SceneManager.LoadScene("LivingQuarters");
    //	}
    //	if(other.gameObject.tag == "OutsideButton")
    //	{
    //		SceneManager.LoadScene("OutsideScene");
    //	}
    //}
}
