using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Equipment List", menuName = "Create List of Equipment", order = 51)]
public class EquipmentList : ScriptableObject {

    public List<EquipmentContainer> equipment = new List<EquipmentContainer>();

}
