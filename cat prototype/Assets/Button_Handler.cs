using UnityEngine;
using System.Collections;

public class Button_Handler : MonoBehaviour 
{
	
	public bool button1;
	public bool button2;
	public bool button3;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "VrController")
		{
			if(button1 == true)
			{
				Debug.Log ("button1");
			}
			else if(button2 == true)
			{
				Debug.Log ("button1");
			}
			else if(button3 == true)
			{
				Debug.Log ("button1");
			}
		}
	}
	
	
}
