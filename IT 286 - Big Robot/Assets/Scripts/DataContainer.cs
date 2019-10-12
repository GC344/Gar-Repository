using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class DataContainer : ScriptableObject {
    public new string name;
    public string description;
    public float durability;
    public float energy;
    public float damage;
    public int ammunition;

    public Sprite artwork;

}
