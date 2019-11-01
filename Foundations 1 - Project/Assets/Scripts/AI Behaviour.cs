using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviour : MonoBehaviour {
    public float agressionLevel;
    
	
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

    //roots
    public void Attacking()
    {

    }
    public void Defending()
    {

    }
    public void Evading()
    {

    }

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
    public void Throw(int i)
    {
        if (i == 1)//Throw Them Down
        {
            //do animation from throw
            //playerHP -= (damage - playerArmorValue);
        }
        if (i == 2)//Throw them away
        {

        }
       
    }
    public void Pummle()
    {
        //smack player to deal light damage that ignores armor 
    }

    public void CheckPlayerHP()
    {

    }
    // public void Throw() { }
    public void MoveBackward()
    {
     
    }
    public void MoveForward()
    {

    }
    public void MoveLeft()
    {

    }
    public void MoveRight()
    {

    }
    //Sequences
    public void BasicCombo()
    {
        LightAttack();
        LightAttack();
        HeavyAttack();
    }
    public void Grapple()

    {
        Pummle();
        Throw(1);
        //throw
    }
    public void ReturnToNeutral()
    {
        MoveBackward();
        CheckVisible();
        CheckPlayerHP();
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
