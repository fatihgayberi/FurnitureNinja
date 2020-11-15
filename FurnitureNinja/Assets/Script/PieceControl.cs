using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ColliderEditor());
    }

    // parcalndiktan sonra temasinin kesilmesi icin cagirilir
    IEnumerator ColliderEditor()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Collider>().enabled = false;
        Destroy(transform.parent.gameObject, 3f);
    }
}
