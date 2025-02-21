using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] TMP_Text descriptionText;

    public void SetValues(string nameString, string descriptionString) {
        nameText.text = nameString;
        descriptionText.text = descriptionString;
    }
}
