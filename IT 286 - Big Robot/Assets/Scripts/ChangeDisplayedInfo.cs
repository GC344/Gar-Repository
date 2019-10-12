using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeDisplayedInfo : MonoBehaviour {
    public Button Next;
    //public List<DataContainer> TheseAreItems;
    private int i = 0;
    // Use this for initialization
    void Start () {
        Button nextBtn = Next.GetComponent<Button>();
        nextBtn.onClick.AddListener(ChangeInfo);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void ChangeInfo()
    {
        //i += 1;
        //DisplayItem.ListIndex = i;
        //DisplayItem. = TheseAreItems[i];
        //DisplayItem.item = ItemList.ListOfItems[i];//did not work
    }
}
