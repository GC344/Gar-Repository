using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrucible : MonoBehaviour {

    public GameObject destroyedProp;

    void OnMouseDown()
    {

        //Instantiate(destroyedProp, transform.position, Quaternion.identity);
        Instantiate(destroyedProp, transform.position, transform.rotation, transform.parent);
        //Instantiate(destroyedProp, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
    }
}

