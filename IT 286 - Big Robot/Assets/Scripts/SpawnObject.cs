using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour {
    public Button Equip;
    public GameObject itemA;

    void Start()
    {
        Button btn = Equip.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void TaskOnClick() {
        Instantiate(itemA, new Vector3(2.0F, 0, 0), Quaternion.identity);
        //Transform t = placeToSpawn.transform;
        //Vector3 position = t.position;
        
        Debug.Log("Button Clicked");
	}
    
}
