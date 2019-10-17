using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Example List of Data", menuName = "Create List of Example Items", order = 52)]
public class ExampleData : ScriptableObject {

    public List<ExampleItem> exampleItems = new List<ExampleItem>();
    //public List<ExampleItem> exampleItems;
}
