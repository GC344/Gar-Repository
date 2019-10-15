using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShield : MonoBehaviour {
    public GameObject ShieldTile, ShieldParent;

    public float ShieldEnergy, RelativePosition;
    public float DistX = 1.12f; //1.12f ref
    public float DistY = 2.35f; // 2.2ref

    public Vector3 Placement;

    public bool IsShieldOn = false;

    public Transform doodad;//knows it is the transform coordinates
    //private Vector3[] offsets;
    [SerializeField]
    private int NumShieldRows;
    private Vector3 ParentPosition;
    private Quaternion ParentRotation;
   
	
	void Start () {
		ParentPosition = ShieldParent.transform.position;
        ParentRotation = ShieldParent.transform.rotation;
        Debug.Log("Parent Position: " + ParentPosition);
        Debug.Log("Parent Rotation: " + ParentRotation);
        // offsets = { Vector3.zero, new Vector3(DistX, 0, 0), new Vector3(-DistX, 0, 0), new Vector3(DistX / 2, DistY, 0), new Vector3(DistX / 2, -DistY, 0) };
       // offsets = { Vector3.zero, new Vector3(DistX, 0, 0), new Vector3(-DistX, 0, 0), new Vector3(DistX / 2, DistY, 0), new Vector3(DistX / 2, -DistY, 0)};
        
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
            Invoke("GenerateShield", 0.5f);
            IsShieldOn = true;
            //(e => Debug.Log(e));
            //GenerateShield();

        }

        
	}

    private void GenerateShield()
    {
       Vector3[] offsets = { Vector3.zero, new Vector3(DistX, 0, 0), new Vector3(-DistX, 0, 0), new Vector3(DistX / 2, DistY, 0), new Vector3(DistX / 2, -DistY, 0),
            new Vector3(-(DistX / 2), DistY, 0 ), new Vector3(-(DistX / 2), -DistY, 0 )};
        for (int i = 0;i < offsets.Length;i++)
            Instantiate(ShieldTile,ShieldParent.transform.position + offsets[i], ParentRotation, ShieldParent.transform); //Initial Shield Tile
        // yield return new WaitForSeconds(1);
        //Time.deltaTime(6);
    }

    
}
