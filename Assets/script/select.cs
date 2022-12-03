using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    public int currentlySelect;
    public GameObject[] selectedGameObject;

    private void Start()
    {
        currentlySelect = 0;
    }

    public void setSelect(int select)
    {
        selectedGameObject[select].transform.GetChild(0).gameObject.SetActive(false);
        selectedGameObject[select].transform.GetChild(1).gameObject.SetActive(true);
        selectedGameObject[select].transform.GetChild(2).gameObject.SetActive(false);
        disSetSelect(currentlySelect);
        currentlySelect = select;   
    }

    public void disSetSelect(int select)
    {
        selectedGameObject[select].transform.GetChild(0).gameObject.SetActive(true);
        selectedGameObject[select].transform.GetChild(1).gameObject.SetActive(false);
        selectedGameObject[select].transform.GetChild(2).gameObject.SetActive(false);
    }
}
