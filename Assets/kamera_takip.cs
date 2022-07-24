using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    Transform cocuk_pozisyon;
    Vector3 mesafe;
    float hiz = 7.0f;

    void Start()
    {
        cocuk_pozisyon = GameObject.Find("cocuk").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mesafe = new Vector3(cocuk_pozisyon.position.x, transform.position.y, cocuk_pozisyon.position.z - 8.4f);
        transform.position = Vector3.Lerp(transform.position, mesafe, hiz*Time.deltaTime);
 
    }


 
    
}
