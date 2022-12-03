using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Animal", menuName = "Specise/New Animal")]
public class Animal : ScriptableObject
{
    public string anmalSpecise;
    public Sprite animalImage;
    public int saveNum;
    public int deadNum;
    public bool beSaw;
    [TextArea]
    public string AnimalInfo;

}
