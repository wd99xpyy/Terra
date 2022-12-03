using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI;

public class AnimalOnWorld : MonoBehaviour
{
    public Animal thisAnimal;
    public Specise animalInSpecise;
    public int animalHealth;
    public int animalMaxHealth = 100;
    public int animalHungry;
    public int animalMaxHungry = 100;
    public int animalHappiness;
    public int animalMaxHappiness = 100;
    public int animalThirst;
    public int animalMaxThirst = 100;

    public float time = 0;

    public TextMeshProUGUI species;
    public TextMeshProUGUI sickness;

    public healthbar healthbar;
    public healthbar hungrybar;

    public TextMeshProUGUI infospecies;
    public healthbar infohealthbar;
    public healthbar infohungrybar;
    public healthbar infohappinessbar;
    public healthbar infothirstbar;

    public GameObject release;

    // Start is called before the first frame update
    void Start()
    {
        animalHealth = Random.Range(30, 70);
        animalHungry = Random.Range(30, 70);
        animalHappiness = Random.Range(30, 70);
        animalThirst = Random.Range(30, 70);
        setAnimalInfo();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>5)
        {
            time = 0;
            takeDamage(1);
        }
    }

    public void refreshBar()
    {
        hungrybar.SetHealth(animalHungry);
        healthbar.SetHealth(animalHealth);
        infohealthbar.SetHealth(animalHealth);
        infohungrybar.SetHealth(animalHungry);
        infohappinessbar.SetHealth(animalHappiness);
        infothirstbar.SetHealth(animalThirst);
        if( animalHealth > 90 && animalHungry > 90 && animalHappiness > 90 && animalThirst > 90) {
            release.SetActive(true);
        }
    }

    void takeDamage(int damage)
    {
        animalHealth -= damage;
        healthbar.SetHealth(animalHealth);
    }


    void setAnimalInfo()
    {
        healthbar.SetMaxHealth(animalMaxHealth);
        healthbar.SetHealth(animalHealth);

        hungrybar.SetMaxHealth(animalMaxHungry);
        hungrybar.SetHealth(animalHungry);

        species.text = "Specise: " + thisAnimal.anmalSpecise;
    }

    public void selectSetup()
    {
        infospecies.text = thisAnimal.anmalSpecise;

        infohealthbar.SetMaxHealth(100);
        infohealthbar.SetHealth(animalHealth);

        infohungrybar.SetMaxHealth(100);
        infohungrybar.SetHealth(animalHungry);

        infohappinessbar.SetMaxHealth(100);
        infohappinessbar.SetHealth(animalHappiness);

        infothirstbar.SetMaxHealth(100);
        infothirstbar.SetHealth(animalThirst);
    }

}
