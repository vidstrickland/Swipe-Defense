using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour {

	//TODO
	//Rotate Hero to match swipe. (Sprite change? Actual rotation? Both?)
	//Add collision rules for two projectile types (Fireball, Arrow)

	public HeroController hero;

	void Start ()
	{
		
		SwipeManager.OnSwipeDetected += OnSwipeDetected;
	}

	void OnSwipeDetected (Swipe direction, Vector2 swipeVelocity)
	{
		print ("Direction: " + direction + " Velocity: " + swipeVelocity);
		hero.Turn (direction);
	}

}
