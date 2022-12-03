using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class directoryManager : MonoBehaviour
{
    public Animal thisAnimal;
    public TextMeshProUGUI specise;
    public TextMeshProUGUI info;
    public Image image;

    public void ShowInfo()
    {
        specise.text = thisAnimal.anmalSpecise;
        info.text = thisAnimal.AnimalInfo;
        image.sprite = thisAnimal.animalImage;
    }
}
