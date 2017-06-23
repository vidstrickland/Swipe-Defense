using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed, damage;
	public HeroController hero;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Shield") {
			print ("BLOCKED!");
		} else {
			print ("HIT!");
		}
		Destroy (gameObject);
	}
}
