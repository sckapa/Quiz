using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickableImage : MonoBehaviour
{
    [SerializeField]
    private Animals animal;

    [SerializeField]
    private bool Flying;
    [SerializeField]
    private bool Insect;
    [SerializeField]
    private bool Omnivorous;
    [SerializeField]
    private bool LivesInGroup;
    [SerializeField]
    private bool LaysEggs;

    [SerializeField]
    private string Description;


    [SerializeField] 
    private GameObject popupPanel;

    private AnimalProperties animalProperties;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log("Clicked: " + gameObject.name);
            ShowPopup();
        });

        animalProperties.Flying = Flying;
        animalProperties.Insect = Insect;
        animalProperties.Omnivorous = Omnivorous;
        animalProperties.LivesInGroup = LivesInGroup;
        animalProperties.LaysEggs = LaysEggs;

        animalProperties.Description = Description;
    }

    private void ShowPopup()
    {
        popupPanel.SetActive(true);
        // Popup panel elements
    }

}