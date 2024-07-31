using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]public float xValue = .0f;
    [SerializeField]float yValue = .0f;
    [SerializeField]float zValue = .0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(xValue,yValue,zValue); 
    }

}
