using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public TweenPosition selectHeroPosition;
	// Use this for initialization
	void OnClick(){
		selectHeroPosition.PlayForward ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
