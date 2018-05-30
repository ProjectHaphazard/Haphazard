using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject ReSpawnObject;
   // public float intarval = 30.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider col)
    {
        Destroy(this.gameObject);
        // コルーチン開始
        StartCoroutine("ReSpawnobject");
    }

    IEnumerator ReSpawnobject()
    {
        // リスポーン開始
        while(true)
        {
            // オブジェクトの位置に、発生するオブジェクトをインスタンス化して生成する
            Instantiate(ReSpawnObject, transform.position, Quaternion.identity);
            transform.localScale = new Vector3(3, 3, 3);
            yield return new WaitForSeconds(10);
        }
    }
}
