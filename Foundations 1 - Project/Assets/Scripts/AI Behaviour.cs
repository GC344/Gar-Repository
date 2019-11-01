using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviour : MonoBehaviour {
    public float Agression;
    
	
	void Start () {
        // Use this for initialization
    }
    private void Awake()
    {
        
    }

    void Update () {
        // Update is called once per frame
    }

    /*
     * Root
     * Selector
     * sequence
     * leaf
     * 
     */


    public bool CheckVisible()
    {
        //raycast or nav mesh info?
        return true;
    }


    public void RootExample()
    {
        //Spawn
        // StartEncounter()
        //SELECTOR 
        //if PlayerHPisHigh == true do this or that

    }

    //Leafs
    public void LightAttack()
    {

    }
    public void HeavyAttack()
    {

    }
    public void SpecialAttack()
    {

    }
    public void Grapple()
    {

    }
    public void ReturnToNeutral()
    {

    }
    public void EngageCloseCombat()
    {
        /* Move toward the player to attack
         *  if option selected do so aggressively
         */

    }
    public void EngageRangedCombat()
    {

    }
    public void BeginDodging()
    {

    }
    public void HideBehindCover()
    {

    }

}
public enum AiType {CloseCombat,RangedAttacker, MixedFighter};
//Types of AI 

    // Mathf.Clamp(var - Time.deltatime * 5f, 0 , 100); // what does clamp do?
