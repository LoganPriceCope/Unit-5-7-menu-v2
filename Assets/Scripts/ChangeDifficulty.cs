using UnityEngine;
using TMPro;

public class DropdownSaveManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        // Load saved selection when the scene starts
        if (PlayerPrefs.HasKey("DropdownSelection"))
        {
            int savedSelection = PlayerPrefs.GetInt("DropdownSelection");
            dropdown.value = savedSelection;
        }

        // Add listener for value changes
        dropdown.onValueChanged.AddListener(delegate {
            SaveDropdownSelection();
        });
    }

    // Method to save dropdown selection
    public void SaveDropdownSelection()
    {
        PlayerPrefs.SetInt("DropdownSelection", dropdown.value);
        PlayerPrefs.Save();
    }
}