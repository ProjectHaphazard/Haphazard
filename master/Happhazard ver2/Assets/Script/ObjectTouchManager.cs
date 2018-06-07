using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTouchManager : MonoBehaviour {

    //選択したオブジェクトの種類ごとにアクションを起こすscript

    Rigidbody rigidBody;
    
    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody>();
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
