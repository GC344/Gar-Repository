using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
//using UnityEngine.UI; //might need UI for giving info to the UI when acsessing this from another script

public class InfoManager : MonoBehaviour {
    // public List<ExampleData> Equipment;
    [SerializeField]
    private ExampleData ExampleData;

    public Text typeText,slotText,intText; // for the enums 
    public List<Text> texts = new List<Text>();
    public GameObject selector; //visual representation of the current index
    private GameObject currentObject;
    private int CurrentIndex = 0;
    private int selectorPos = 1;
    private int mod = 0;
    private bool atEndOfList, atStartOfList, selectorAtTop, selectorAtBot;
    
   
    private void Awake()
    {
        currentObject = Instantiate(ExampleData.exampleItems[CurrentIndex].ExamplePrefab, new Vector3(1.6f, 1, -3), Quaternion.identity);
        atStartOfList = true;
        selectorAtTop = true;
        selectorAtBot = false;
        
        //Load();

    }
    private void Start()
    {
  
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveExample();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ExampleData.exampleItems[CurrentIndex].ExampleInt += 1;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
            
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            LoadFromInspector2();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //ExampleData data = null;
            //LoadFromInspector();
        }
        if (Input.GetKeyDown(KeyCode.N))//forward
        {
            
            
        }
        if (Input.GetKeyDown(KeyCode.B))//back
        {
            
        
            

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!atStartOfList && selectorPos > 1)
            {
                Destroy(currentObject);
                selectorPos -= 1;
                selector.transform.localPosition += new Vector3(0, +30, 0);
                CurrentIndex -= 1;
                currentObject = Instantiate(ExampleData.exampleItems[CurrentIndex].ExamplePrefab, new Vector3(1.6f, 1, -3), Quaternion.identity);
                Debug.Log(selectorPos.ToString() + "!atStartOfList && selectorPos > 1");
            }
            else if (CurrentIndex == 0)
                atStartOfList = true;
            else if (!atStartOfList)
            {
                Destroy(currentObject);
                mod -= 1;
                //selectorPos
                CurrentIndex -= 1;
                currentObject = Instantiate(ExampleData.exampleItems[CurrentIndex].ExamplePrefab, new Vector3(1.6f, 1, -3), Quaternion.identity);
                Debug.Log(selectorPos.ToString() + "Else activated up");
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { //if the list is at the bottom or top move the selector
            if (!atEndOfList && selectorPos < 7)
            {

                Destroy(currentObject);
                selectorPos += 1;
                selector.transform.localPosition += new Vector3(0, -30, 0);
                CurrentIndex += 1;
                currentObject = Instantiate(ExampleData.exampleItems[CurrentIndex].ExamplePrefab, new Vector3(1.6f, 1, -3), Quaternion.identity);
                Debug.Log(selectorPos.ToString() + "!atEndOfList && selectorPos < 7");
            }
            else if (ExampleData.exampleItems.Count == CurrentIndex)
                atEndOfList = true;

            else if(!atEndOfList)
            {

                Destroy(currentObject);
                mod += 1;
                //selectorPos
                CurrentIndex += 1;
                currentObject = Instantiate(ExampleData.exampleItems[CurrentIndex].ExamplePrefab, new Vector3(1.6f, 1, -3), Quaternion.identity);
                Debug.Log(selectorPos.ToString() + "Else activated down");

            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ///Equip(CurrentIndex);
        }
       // PreviousName.text = SendToUI(CurrentIndex);
       // NameText.text = SendToUI(CurrentIndex +1 );
      //  NextName.text = SendToUI(CurrentIndex + 2);

       
        UpdateUI();
    }
    void UpdateUI()
    {
        if (selectorPos == 7)
            selectorAtBot = true;
        if (selectorPos == 1)
            selectorAtTop = true;

        for (int i =0; i < texts.Count;i++)
        texts[i].text = ExampleData.exampleItems[i + mod].ExampleName;

        if (CurrentIndex == 0)
            atStartOfList = true;
        else
            atStartOfList = false;

        if (CurrentIndex == ExampleData.exampleItems.Count - 1)
            atEndOfList = true;
        else
            atEndOfList = false;
        
        typeText.text = ExampleData.exampleItems[CurrentIndex].Type.ToString();
        slotText.text = ExampleData.exampleItems[CurrentIndex].ItemSlot.ToString();
        intText.text = ExampleData.exampleItems[CurrentIndex].ExampleInt.ToString();
        

    }
    void SaveExample()
    {
        string json = JsonUtility.ToJson(ExampleData);
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
            Debug.Log("Save Data Loaded From Inspector");

            ExampleData = data;
           
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
    ExampleData LoadFromInspector2()
    {
        ExampleData data = null;//clear current data
        ShowConsole();

        if (File.Exists(Application.persistentDataPath + Path.DirectorySeparatorChar + "GCExampleData.txt"))
        {

            data = ScriptableObject.CreateInstance<ExampleData>();
            string json = File.ReadAllText(Application.persistentDataPath + Path.DirectorySeparatorChar + "GCExampleData.txt");
            JsonUtility.FromJsonOverwrite(json, data);
            Debug.Log("Save Data Loaded From File");

            //ExampleData = data;

        }
        else
        {
            data = Resources.Load<ExampleData>("Example Data");
            Debug.Log("Save Could Not Be Found");
        }
        return data;

    }

    void ShowConsole()
    {
        for (int i = 0; i < ExampleData.exampleItems.Count; i++)
        {
            Debug.Log("Example Name: " + ExampleData.exampleItems[i].ExampleName);
            Debug.Log("Example Int: " + ExampleData.exampleItems[i].ExampleInt);
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
        return ExampleData.exampleItems[i].ExampleName;
    }
    void Upgrade()
    {
        //Change the bool of the item as needed to reflect the upgrade
    }
    void Equip(int i)
    {
        Instantiate(ExampleData.exampleItems[i].ExamplePrefab,transform.position,Quaternion.identity);
    }
}
