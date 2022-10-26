using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
    }
}
