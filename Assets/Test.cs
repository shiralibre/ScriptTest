using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int mp = 53;          
	public void Magic() { 
		if (mp >= 5) {
			Debug.Log ("魔法攻撃をした残りのmpは" + (this.mp - 5));
			this.mp -= 5;
		}
		else{ 
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



