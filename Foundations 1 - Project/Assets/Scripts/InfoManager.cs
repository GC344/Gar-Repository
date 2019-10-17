using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
//using UnityEngine.UI; //might need UI for giving info to the UI when acsessing this from another script

public class InfoManager : MonoBehaviour {
    // public List<ExampleData> Equipment;
    [SerializeField]
    private ExampleData exampleData;

    public Text NameText,PreviousName;
    private int CurrentIndex = 0;
    // Use this for initialization
    /*
        void Start () {
            for (int i = 0;i<= 2;i++) {
                Debug.Log("Item Name: " + Equipment[i].ItemName + "Desc: " + Equipment[i].ItemDescription);
            }
           }
        */
    private void Awake()
    {
        // exampleData = Load();
        //Debug.Log("Load Ran at Awake");
        PreviousName.text = "";
        NameText.text = SendToUI(0);
    }
    private void Start()
    {
        for (int i = 0; i < exampleData.exampleItems.Count; i++)
        {
            Debug.Log("Example Name: " + exampleData.exampleItems[i].ExampleName);
            Debug.Log("Example Int: " + exampleData.exampleItems[i].ExampleInt);
        }
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveExample();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            LoadFromInspector();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            PreviousName.text = SendToUI(CurrentIndex);
            CurrentIndex++;
            NameText.text = SendToUI(CurrentIndex);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Equip(CurrentIndex);
        }
    }
    void SaveExample()
    {
        string json = JsonUtility.ToJson(exampleData);
        File.WriteAllText(Application.persistentDataPath + Path.DirectorySeparatorChar + "GCExampleData.txt", json);
        Debug.Log("Data saved to:" + Application.persistentDataPath);//Where Data has been saved to
        
    }
    /*
    void Save(string path)
    {
        Debug.LogFormat("Saving inventory to {0}", path);
        System.IO.File.WriteAllText(path, JsonUtility.ToJson(Equipment, true));
        //Save to text file all equipment with bool checked     
    }
    */
    ExampleData Load()
    {//Load Data from text file
        ExampleData data = null;//clear current data
        ShowConsole();

        if (File.Exists(Application.persistentDataPath + Path.DirectorySeparatorChar + "GCExampleData.txt")) {

            data = ScriptableObject.CreateInstance<ExampleData>();
            string json = File.ReadAllText(Application.persistentDataPath + Path.DirectorySeparatorChar + "GCExampleData.txt");
            JsonUtility.FromJsonOverwrite(json, data);
            Debug.Log("Save Data Loaded");
           
        }
        else
        {
            data = Resources.Load<ExampleData>("Example Data");
            Debug.Log("Save Could Not Be Found");
        }
        return data;
    }
    ExampleData LoadFromInspector()
    {
        ExampleData data = null;
        data = Resources.Load<ExampleData>("Example Data");
        Debug.Log("Loaded Data From Inspector");
        ShowConsole();
        return data;
        
    }
    
    void ShowConsole()
    {
        for (int i = 0; i < exampleData.exampleItems.Count; i++)
        {
            Debug.Log("Example Name: " + exampleData.exampleItems[i].ExampleName);
            Debug.Log("Example Int: " + exampleData.exampleItems[i].ExampleInt);
        }
    }

    private void OnDisable()
    {
       // SaveExample();
    }
    
    string SendToUI(int i)
    {
        //Give The UI info as needed from the scriptable object
        //return exampleData.exampleItems[i].ExampleName;
        //NameText.text = exampleData.exampleItems[1].ExampleName;
        return exampleData.exampleItems[i].ExampleName;
    }
    void Upgrade()
    {
        //Change the bool of the item as needed to reflect the upgrade
    }
    void Equip(int i)
    {
        Instantiate(exampleData.exampleItems[i].ExamplePrefab,transform.position,Quaternion.identity);
    }
}
