using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleDegree : MonoBehaviour {
	
	float scale_y = 1;
	// Use this for initialization
	void Start () {
		
	}

	//float position_x_fixed = this.transform.position.x;
	//float position_y = this.transform.position.y;
	//float position_z_fixed = this.transform.position.z;

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (-4f, 4.3f, -17.1f);
		this.transform.localScale = new Vector3 (0.25f, scale_y, 0.118f);
		scale_y += 0.01f;
	}
}
