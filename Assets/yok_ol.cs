using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yok_ol : MonoBehaviour
{
    Transform cocuk;

    void Start()
    {
        cocuk = GameObject.Find("cocuk").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float mesafe = Vector3.Distance(transform.position, cocuk.position);
        if (mesafe<0)
        {
            gameObject.SetActive(false);
        }
    }
}
