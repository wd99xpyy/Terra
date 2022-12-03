using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Specise", menuName = "Specise/New Specise")]
public class Specise : ScriptableObject
{
    public List<Animal> animalList = new List<Animal>();
}

