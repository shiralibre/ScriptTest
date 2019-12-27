using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] points = { 30, 50, 10, 60, 100 };
		for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]); 
		}
		for (int i = points.Length-1; i>-1; i--){
			Debug.Log (points [i]);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
	

public class Boss {        
	private int mp = 53;          
	public void Magic() { 
		Debug.Log("魔法攻撃をした残りのmpは"+(this.mp-5));
		this.mp -= 5;
		if (mp < 5) {
			Debug.Log ("mpが足りない為、魔法が使えない");
		}
	}

}
	
public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// mp用の関数を呼び出す
		for (int i = 0; i <= 10; i++){
			lastboss.Magic ();	}
	}

	// Update is called once per frame
	void Update () {

	}
}	



