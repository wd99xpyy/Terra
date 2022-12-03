using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class assignPlayerName : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI Pname;
    public TextMeshProUGUI Pname1;
    public TextMeshProUGUI Pname2;

    void Start()
    {
        assignName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void assignName()
    {
        Pname.text = PlayerPrefs.GetString("PlayerName");
        Pname1.text = PlayerPrefs.GetString("PlayerName");
        Pname2.text = PlayerPrefs.GetString("PlayerName");

    }
}
