using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour {

    public GameObject Tree;

	// Use this for initialization
	void Start () {
        Vector3 TreePosition = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, -0.1f, Camera.main.nearClipPlane));
        TreePosition.y = 0;
        Instantiate(Tree, TreePosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
