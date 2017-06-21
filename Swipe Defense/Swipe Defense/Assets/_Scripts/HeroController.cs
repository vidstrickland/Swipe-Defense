using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	//TODO
	//Rotate Hero to match swipe. (Sprite change? Actual rotation? Both?)
	//Add collision rules for two projectile types (Fireball, Arrow)

	void Start ()
	{
		SwipeManager.OnSwipeDetected += OnSwipeDetected;
	}

	void OnSwipeDetected (Swipe direction, Vector2 swipeVelocity)
	{
		print ("Direction: " + direction + " Velocity: " + swipeVelocity);
	}

}
