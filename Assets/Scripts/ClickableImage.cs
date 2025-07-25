using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickableImage : MonoBehaviour
{
    public bool Flying;
    public bool Insect;
    public bool Omnivorous;
    public bool LivesInGroup;
    public bool LaysEggs;

    public string Description;

    [SerializeField]
    private TMP_Text descriptionText;
    [SerializeField]
    private TMP_Text nameText;

    [SerializeField] 
    private GameObject popupPanel;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            ShowPopup();
        });
    }

    private void ShowPopup()
    {
        nameText.SetText(gameObject.name);
        descriptionText.SetText(gameObject.GetComponent<ClickableImage>().Description);
        popupPanel.SetActive(true);
    }
}