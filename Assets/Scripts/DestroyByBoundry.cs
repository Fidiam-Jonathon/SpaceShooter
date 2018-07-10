using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundry : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject);
        Destroy(other.gameObject);
    }
}
