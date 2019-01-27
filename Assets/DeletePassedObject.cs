using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePassedObject : MonoBehaviour {

	private GameObject characterObj;
	//

	// Use this for initialization
	void Start () {
		characterObj = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.z < characterObj.transform.position.z){
            Destroy(this.gameObject);
        }
	}
}
