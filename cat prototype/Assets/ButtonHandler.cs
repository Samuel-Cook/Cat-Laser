using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*
This script to be applied to blocks you want to be the buttons.

The button just needs to have a box collider on them so that they can register
that the controller has come into contact with them.

Make sure that the controller you are using to hit the buttons
with has a rigid body component with no gravity enabled and has a collier
component that has triggered enabled.

Also give a tag to the controllers. For an example I'm just going to use
"VrController". This is used for the OnTriggerEnter() Function.

*/



public class ButtonHandler : MonoBehaviour {

//These bools are just so you can easily choose which level you would like to load
//Enable only the level you want in the editor

public bool floor1;
public bool floor2;
public bool floor3;


void OnTriggerEnter(Collider Other) //Senses when an controller touches the object
{
 if(Other.tag == "VrController")
 {
     if(floor1 == true)
     {
        Debug.Log("button1");

		// GameObject prefab = Resources.Load ("brick") as GameObject;
		 // GameObject instance = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
     }
     else if(floor2 == true)
     {
          Debug.Log("button2");
		  //GameObject prefab = Resources.Load ("PrefabName") as GameObject;
		  //GameObject instance = Instantiate(prefab, transform.position, transform.rotation) as GameObject;  
     }
     else if(floor3 == true)
     {
          Debug.Log("button3");
		  //GameObject prefab = Resources.Load ("PrefabName") as GameObject;
		  //GameObject instance = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
     }
     else
     { 
         Debug.Log("Multiple bools were enabled on one object");
     }
  }
 }

}