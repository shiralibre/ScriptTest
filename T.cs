using UnityEngine;
using System.Collections;

public class T : MonoBehaviour
{
    // Use this for initialization
    void Start() { 
        int[] points = { 30, 50, 10, 60, 100 };
		for (int i = 0; i<points.Length; i++) {
			Debug.Log(points[i]); 
		}
		for (int i = points.Length-1; i>-1; i--){
			Debug.Log(points[i]);
		}
	}

    

    // Update is called once per frame
    void Update()
    {

    }
}
