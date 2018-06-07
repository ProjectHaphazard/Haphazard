using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour {
 
   
    	// Player オブジェクトへの参照
	[SerializeField]
	GameObject player;

	// 『Player』オブジェクトと『MainCamera』オブジェクトの距離
	Vector3 offset;

	

	// カメラの拡大率(%)
	float magnify = 100f;

	void Start(){
		// オフセットを計算する
		offset = gameObject.transform.position - player.transform.position;
	}
	
	void LateUpdate(){
		// カメラの拡大率に応じたオフセットを取得
		Vector3 magnifiedOffset = GetMagnifiedOffset();

		// 『Sphere』オブジェクトとオフセットからカメラの現在位置を計算
		gameObject.transform.position = player.transform.position + magnifiedOffset;
	}

	Vector3 GetMagnifiedOffset(){
		// 規格化されたオフセットを取得
		Vector3 normalizedOffset = offset.normalized;

		// 『Sphere』オブジェクトとカメラの距離を取得
		float offsetDistance = offset.magnitude;

		// offsetDistanceに拡大率をかけて補正後の距離を取得
		float magnifiedDistance = offsetDistance * magnify / 100f;

		// 規格化されたベクトルと拡大後の距離からオフセットを返す
		Vector3 magnifiedOffset = magnifiedDistance * normalizedOffset;
		return magnifiedOffset;
	}
}
