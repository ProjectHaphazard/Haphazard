using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine;

public class Move : MonoBehaviour {

    //private Vector3 targetPosition; //移動する位置
    public GameObject DestroyButton;
    public GameObject GatheringButton;
    public string Fixationtag = "Fixation";
    private NavMeshAgent agent;
    private RaycastHit hit;
    private Ray ray;
    static Canvas _canvas;

    // Use this for initialization
    void Start () {
        // Canvasコンポーネントを保持
        _canvas = GetComponent<Canvas>();
        DestroyButton.SetActive(false);
        GatheringButton.SetActive(false);
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray,out hit,100))
            {
                if (hit.collider.gameObject)
                {
                    agent.SetDestination(hit.point);
                    if (hit.collider.gameObject.CompareTag(Fixationtag))
                    {
                        agent.SetDestination(hit.point);
                        DestroyButton.SetActive(true);
                        GatheringButton.SetActive(true);
                        Debug.Log("HitTree");
                    }
                    else
                    {
                        //DestroyButton.SetActive(false);
                        //GatheringButton.SetActive(false);
                    }
                }
            }
        }
	}
}
