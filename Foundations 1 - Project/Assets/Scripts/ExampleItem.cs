using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ExampleItem {

    public string ExampleName;
    public ItemType Type;
    public ItemSlot ItemSlot;
    public int ExampleInt;
    //public float damageModifier;
    public GameObject ExamplePrefab;
    

}
public enum ItemType { Armor, Weapon, Utility };
public enum ItemSlot { Body, RightH, LeftH, Utility };
// The enum is outside the class to avoid encapsulation from the ExampleItem Class
//, out here I can grab them from other scripts without making direct references
