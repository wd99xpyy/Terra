using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class slot : MonoBehaviour
{
    public item slotItem;
    public Image slotImage;
    public TextMeshProUGUI slotIndex;

    public GameObject objectUsing;
    public bool isUsing = false;

    public GameObject slotPrefab;

    public void Update()
    {
        if (isUsing)
        {
            followMouse(objectUsing);
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider !=null&& hit.collider.gameObject.CompareTag("Animal"))
                {
                    Debug.Log("Click Animal");
                    if (slotItem.itemHeld > 0)
                    {
                        slotItem.itemHeld--;
                        inventoryManager.RefreshItem();
                        isUsing = false;
                        Destroy(objectUsing);
                        if (slotItem.isFood)
                        {
                            hit.collider.gameObject.GetComponent<AnimalOnWorld>().animalHungry += 20;
                            hit.collider.gameObject.GetComponent<AnimalOnWorld>().animalHappiness += 20;

                        }
                        if (slotItem.isMed)
                        {
                            hit.collider.gameObject.GetComponent<AnimalOnWorld>().animalHealth += 20;
                            hit.collider.gameObject.GetComponent<AnimalOnWorld>().animalThirst += 20;
                        }
                        hit.collider.gameObject.GetComponent<AnimalOnWorld>().refreshBar();
                    }
                }
            }
            if (Input.GetMouseButtonDown(1))
            {
                isUsing = false;
                Destroy(objectUsing);
            }
        }
    }

    public void ItemOnClick()
    {
        inventoryManager.UpdateItemInfo(slotItem.itemInfo);
    }
    public void useItem()
    {
        if(slotItem.itemHeld > 0)
        {
            createdImage();
        }
    }
    public void createdImage()
    {
        if (isUsing == false)
        {
            GameObject newObject = new GameObject();
            Image itemImage = newObject.AddComponent<Image>();
            itemImage.sprite = slotImage.sprite;
            newObject.GetComponent<RectTransform>().SetParent(slotPrefab.transform);
            newObject.SetActive(true);
            isUsing = true;
            objectUsing = newObject;
        }
    }

    public void followMouse(GameObject gameobject)
    {
        gameobject.transform.position = Input.mousePosition;
    }


}
