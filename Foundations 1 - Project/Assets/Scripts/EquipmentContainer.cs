using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Equipable Item")]

public class EquipmentContainer : ScriptableObject {
    public GameObject Prefab;//attach model to the scripted object or scripted object to the model?
    public string ItemName;
    public string ItemDescription, ItemType;

    public float ItemDurability;
    public float ItemEnergy;
    public float ItemPower;

    public int ItemAmmunition;

    public bool PlayerHasItem = false; //by default the player won't have the item, load function will set bools

    public Sprite ItemArtwork;

}
