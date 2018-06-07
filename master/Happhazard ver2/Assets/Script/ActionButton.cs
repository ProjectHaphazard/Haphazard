using UnityEngine;
using System.Collections;

public class ActionButton : MonoBehaviour
{
    public GameObject DestroyButton;
    public GameObject GatheringButton;
    public GameObject Branches;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClick()
    {
        Destroy(this.gameObject);

        Instantiate(Branches, transform.position, Quaternion.identity);
        DestroyButton.SetActive(false);
        GatheringButton.SetActive(false);
    }
}