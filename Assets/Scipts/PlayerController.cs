using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //El coche avanza hacia delante
        transform.Translate(25*Time.deltaTime*Vector3.forward);
        //prueba finalizada
       
    }
}

