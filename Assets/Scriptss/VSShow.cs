using UnityEngine;
using System.Collections;


public class VSShow : MonoBehaviour {

	public TweenScale vsTweenScale;
	public TweenPosition myheroPosition;
	public TweenPosition enemyherePosition;

	void Awake(){

	}

	// Use this for initialization
	void Start () {
		Show ("hero3", "hero4");
	}
	
	// Update is called once per frame
	void Show (string a,string b) {
		myheroPosition.GetComponent<UISprite> ().spriteName = a;
		enemyherePosition.GetComponent<UISprite> ().spriteName = b;
		vsTweenScale.PlayForward();
		myheroPosition.PlayForward ();
		enemyherePosition.PlayForward ();
	}
}
