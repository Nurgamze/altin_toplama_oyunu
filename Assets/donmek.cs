using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donmek : MonoBehaviour
{
    // altın y mıknatıs x


    string isim;

    float deger = 500f;

    void Start()
    {
        isim = gameObject.tag;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isim=="miknatis")
        {
            transform.Rotate(deger*Time.deltaTime, 0, 0);
        }


        if (isim == "altin")
        {
            transform.Rotate(0, deger * Time.deltaTime, 0, Space.World);
        }
    }
}
