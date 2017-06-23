using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, gun;

	private GameObject projectileParent;


	//private Animator animator;
	public float delayCount = 0;

	public bool isLastEnemy = false;

	void Start(){
		//gameObject.layer = LayerMask.NameToLayer("Untouchable");

		//InvokeRepeating("FireDelay", 2.0f, 1f);
		InvokeRepeating("Fire", delayCount, 3f);

		//animator = GameObject.FindObjectOfType<Animator> ();

		//creates a parent if neccessary
		projectileParent = GameObject.Find ("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
	}
	void Update(){
		
	}

	private void FireDelay(){
		
	}

	private void Fire(){
		

			GameObject newProjectile = Instantiate (projectile)  as GameObject;
			newProjectile.transform.rotation = projectileParent.transform.rotation;
			newProjectile.transform.rotation = gun.transform.rotation;
			newProjectile.transform.position = gun.transform.position;
			newProjectile.transform.parent = projectileParent.transform;

	}
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "shredder") {
			Destroy (gameObject);
		}
	}
}
