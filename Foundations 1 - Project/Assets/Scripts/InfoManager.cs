using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI; //might need UI for giving info to the UI when acsessing this from another script

public class InfoManager : MonoBehaviour {
    public List<EquipmentContainer> Equipment;
	// Use this for initialization
	void Start () {
        for (int i = 0;i<= 2;i++) {
            Debug.Log("Item Name: " + Equipment[i].ItemName + "Desc: " + Equipment[i].ItemDescription);
        }
       }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Save()
    {
        //Save to text file all equipment with bool checked     
    }
    void Load()
    {
        //Load Data from text file
    }
    void ControlUI()
    {
        //Give The UI info as needed from the scriptable object
    }
    void Upgrade()
    {
        //Change the bool of the item as needed to reflect the upgrade
    }
}
