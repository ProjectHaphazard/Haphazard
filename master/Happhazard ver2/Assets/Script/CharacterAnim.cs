using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour {

    private Animator animator;

    private const string flg_isRight = "isRight";
    private const string flg_isLeft = "isLeft";

    // Use this for initialization
    void Start () {
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("LeftClick" + mousePosition);
        }
	}
}
