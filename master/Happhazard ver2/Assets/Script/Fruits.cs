using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour {

    public GameObject fruits;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Destroy(this.gameObject);
        Instantiate(fruits, transform.position, Quaternion.identity);
    }
}
