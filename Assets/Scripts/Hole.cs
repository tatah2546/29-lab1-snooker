using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.gameObject.GetComponent<Ball>();
        
        if (b != null)
        {
            
        }
        
    }
}
