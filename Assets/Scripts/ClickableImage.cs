using UnityEngine;
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

    private AnimalProperties animalProperties;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Debug.Log("Clicked: " + gameObject.name);
        });

        animalProperties.Flying = Flying;
        animalProperties.Insect = Insect;
        animalProperties.Omnivorous = Omnivorous;
        animalProperties.LivesInGroup = LivesInGroup;
        animalProperties.LaysEggs = LaysEggs;

        animalProperties.Description = Description;
    }
}