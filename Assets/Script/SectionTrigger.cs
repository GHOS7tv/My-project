using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class SectionTrigger : MonoBehaviour
{

    public GameObject TunnelSection;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(TunnelSection, new Vector3(0,0,-57), Quaternion.identity);
        }
    }
}
