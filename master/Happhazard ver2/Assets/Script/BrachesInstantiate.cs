﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrachesInstantiate : MonoBehaviour
{

    public GameObject Branches;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Instantiate(Branches, transform.position, Quaternion.identity);
        }
    }
}
