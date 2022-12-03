using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    /*  From:
        https://blog.csdn.net/weixin_43003169/article/details/95387553
        https://blog.csdn.net/qq_45632382/article/details/108444540?spm=1001.2101.3001.6650.1&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7ERate-1-108444540-blog-95387553.pc_relevant_3mothn_strategy_and_data_recovery&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7ECTRLIST%7ERate-1-108444540-blog-95387553.pc_relevant_3mothn_strategy_and_data_recovery&utm_relevant_index=2
       */
    public bool is2D = false;
    public bool is1D_X = false;
    public bool is1D_Y = false;
    public bool isMouseDown = false;
    private Vector3 lastMousePosition = Vector3.zero;
    public float CAM_Yspeed = 0.05f;
    public float CAM_Xspeed = 0.05f;
    //public GameObject thecamera;
    public GameObject select;

    // Update is called once per frame
    void Update()
    {
        if(select.GetComponent<select>().currentlySelect != 1)
        {
            is1D_X = false;
        }
        else
        {
            is1D_X = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;
        }
        if (isMouseDown)
        {
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Input.mousePosition - lastMousePosition;

                if (is1D_X)
                {
                    transform.Translate(offset.x * -CAM_Xspeed, 0, 0);
                }
                else if (is1D_Y)
                {
                    transform.Translate(0, offset.y * -CAM_Yspeed, 0);
                }
                else if (is2D)
                {
                    transform.Translate(offset.x * -CAM_Xspeed, offset.y * -CAM_Yspeed, 0);
                }
            }
            lastMousePosition = Input.mousePosition;
        }
        if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
    }
}
