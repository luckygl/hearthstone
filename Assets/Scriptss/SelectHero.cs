using UnityEngine;
using System.Collections;

public class SelectHero : MonoBehaviour {
	private UISprite uisprite;
	private UILabel uilabel;
	private string heronametext="wuseer";	//不支持中文？

	void Awake(){
		uisprite = this.transform.parent.Find ("hero0").GetComponent<UISprite> ();	
		uilabel = this.transform.parent.Find ("heroname").GetComponent<UILabel> ();
	}


	void OnClick(){
		print ("hero has been clicked");
		string heroname1 = this.gameObject.name;		
		uisprite.spriteName = heroname1;		

		uilabel.text = heronametext;
	}

}
