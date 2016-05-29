using UnityEngine;
using System.Collections;

public class TestClickEvent : MonoBehaviour {

	public UISprite uisprite;
	public TweenPosition myheroPosition;
	public TweenPosition enemyherePosition;
	public TweenScale vsTweenScale;


	void Awake(){
		//uisprite = this.transform.parent.Find ("hero0").GetComponent<UISprite> ();	
		//uilabel = this.transform.parent.Find ("heroname").GetComponent<UILabel> ();
	}

	void OnClick(){
		print ("Startbutton has been clicked");
		//sprite.GetComponent<VSShow> ().Show ("hero2","hero3");
		//this.transform.parent.Find ("hero0").GetComponent<UISprite> ();
		/*
		int min=5;
		int max=5;
		for (int i=0; i<3; i++) {
			int a=Random.Range (1,10);     //返回1~9, 9个整数中的某个随机整数；如果Range中指定为float，则返回float；
			min=Mathf.Min (min,a);
			max=Mathf.Max (max,a);
		}
*/
		//print ("Random value="+a);
		//print ("Random max=" + max);
		//print ("Random min=" + min);
		int a=Random.Range (1,10);  
		Show (uisprite.spriteName, "hero"+a);
	}

	
	// Update is called once per frame
	public void Show (string a,string b) {
		myheroPosition.GetComponent<UISprite> ().spriteName = a;
		enemyherePosition.GetComponent<UISprite> ().spriteName = b;
		vsTweenScale.PlayForward();
		myheroPosition.PlayForward ();
		enemyherePosition.PlayForward ();
	}
}
