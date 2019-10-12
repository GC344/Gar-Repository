using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayItem : MonoBehaviour {
    public Button next;
    public List<DataContainer> item;
    public int listIndex = 0;

    public Text nameText;
    public Text durabilityText;
    public Text energyText;
    public Text ammunitionText;
    public Text damageText;
    public Text descriptionText;

    public Image artworkImage;
    // Use this for initialization
    void Start () {
        nameText.text = "Name: " + item[listIndex].name;
        durabilityText.text = "Durability: " + item[listIndex].durability.ToString();//is a conversion to string neccisary?
        descriptionText.text = "Description: " + item[listIndex].description;
        damageText.text = "Damage: " + item[listIndex].damage;

        artworkImage.sprite = item[listIndex].artwork;

        Button nextBtn = next.GetComponent<Button>();
        nextBtn.onClick.AddListener(NextClicked);

    }
    private void Update()
    {
        nameText.text = "Name: " + item[listIndex].name;
        durabilityText.text = "Durability: " + item[listIndex].durability.ToString();//is a conversion to string neccisary?
        descriptionText.text = "Description: " + item[listIndex].description;
        damageText.text = "Damage: " + item[listIndex].damage;

        artworkImage.sprite = item[listIndex].artwork;
    }
    void NextClicked()
    {
        listIndex += 1;
        Debug.Log("Next was Clicked Index Changed to: " + listIndex);
    }
	
}
