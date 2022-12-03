using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIfollow : MonoBehaviour
{
    Camera theCamera;
    public GameObject target;
    public bool alwaysFollow;
    public float UIlocationY = 1;
    public float UIlocationX = 0;

    bool hasFollowed = false;
    public Canvas canvas;

    public void Start()
    {
        theCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
        FollowObject();
    }
    public void Update()
    {
        FollowObject();
    }

    void FollowObject()
    {
        if (!alwaysFollow && hasFollowed)
        {
            Debug.Log("not follow");
            return;
        }
        if(theCamera != null && target != null)
        {

            Vector2 pos = new Vector2(target.transform.position.x+ UIlocationX, target.transform.position.y+UIlocationY);
            pos = theCamera.WorldToScreenPoint(pos);
            Vector2 point;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent as RectTransform, pos, canvas.worldCamera, out point))
            {
                transform.localPosition = new Vector3(point.x, point.y, 0);
                hasFollowed = true;
            }
        }
    }
}
