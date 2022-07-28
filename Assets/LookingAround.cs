using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAround : MonoBehaviour
{

    void Update()
    {

        Mouse();
    }

    void Mouse()
    {
        Vector3 mousePos = Input.mousePosition;
        {
            Debug.Log(mousePos.x + mousePos.y);
        }




        {
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

}





