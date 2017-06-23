using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	private Animator anim;
	static string heroFacing;
	private string checkFacing;
	public GameObject shield;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Turn (Swipe direction){
		anim.SetTrigger (direction.ToString());
		heroFacing = direction.ToString ();

		if (heroFacing == "Up") {
			shield.transform.rotation = Quaternion.Euler(0,0,180);
		} else if (heroFacing == "Right") {
			shield.transform.rotation = Quaternion.Euler(0,0,90);
		}else if (heroFacing == "Down") {
			shield.transform.rotation = Quaternion.Euler(0,0,0);
		}else if (heroFacing == "Left") {
			shield.transform.rotation = Quaternion.Euler(0,0,270);
		}
	}

	public string CheckFacing(){
		return heroFacing;
	}
}
