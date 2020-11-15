using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    [SerializeField] GameObject blade;

    // Update is called once per frame
    void Update()
    {
        Touch();
    }

    // ekrana dokunmalarda arkasinda iz olusmasi icin 
    void Touch()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos;
            pos.x = Input.mousePosition.x;
            pos.y = Input.mousePosition.y;
            pos.z = 5f;

            if (Input.GetMouseButtonDown(0))
            {
                blade.transform.position = Camera.main.ScreenToWorldPoint(pos);
                blade.SetActive(true);
            }

            blade.transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
        if (Input.GetMouseButtonUp(0))
        {
            blade.SetActive(false);
        }
    }
}
