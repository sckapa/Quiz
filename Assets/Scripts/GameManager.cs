using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text categoryTrueText;
    [SerializeField]
    private TMP_Text categoryFalseText;
    
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private GameObject scoreCard;

    static int category = -1;
    static int score = 0;
    static int count = 0;

    void Start()
    {
        category = Random.Range(1, 5);
        //category = 1;

        switch (category)
        {
            case 1:
                categoryTrueText.SetText("FLYING");
                categoryFalseText.SetText("DOES NOT FLY");
                break;

            case 2:
                categoryTrueText.SetText("INSECT");
                categoryFalseText.SetText("NOT INSECT");
                break;

            case 3:
                categoryTrueText.SetText("OMNIVOROUS");
                categoryFalseText.SetText("HERBIVOROUS");
                break;

            case 4:
                categoryTrueText.SetText("LIVES IN GROUPS");
                categoryFalseText.SetText("LIVES ALONE");
                break;

            case 5:
                categoryTrueText.SetText("LAYS EGGS");
                categoryFalseText.SetText("GIVES BIRTH");
                break;

        }
    }

    private void Update()
    {
        if (count >= 18)
        {
            DisplayScoreCard();
        }
    }

    void DisplayScoreCard()
    {
        scoreText.SetText("YOUR SCORE : " + score);
        scoreCard.SetActive(true);
    }

    public static void CheckIfCorrect(GameObject animal, int rb)
    {
        count++;

        switch (category)
        {
            case 1:
                if(rb==1 && animal.GetComponent<ClickableImage>().Flying)
                {
                    score++;
                }
                else if(rb == 0 && !animal.GetComponent<ClickableImage>().Flying)
                {
                    score++;
                }
                break;

            case 2:
                if (rb == 1 && animal.GetComponent<ClickableImage>().Insect)
                {
                    score++;
                }
                else if (rb == 0 && !animal.GetComponent<ClickableImage>().Insect)
                {
                    score++;
                }
                break;

            case 3:
                if (rb == 1 && animal.GetComponent<ClickableImage>().Omnivorous)
                {
                    score++;
                }
                else if (rb == 0 && !animal.GetComponent<ClickableImage>().Omnivorous)
                {
                    score++;
                }
                break;

            case 4:
                if (rb == 1 && animal.GetComponent<ClickableImage>().LivesInGroup)
                {
                    score++;
                }
                else if (rb == 0 && !animal.GetComponent<ClickableImage>().LivesInGroup)
                {
                    score++;
                }
                break;

            case 5:
                if (rb == 1 && animal.GetComponent<ClickableImage>().LaysEggs)
                {
                    score++;
                }
                else if (rb == 0 && !animal.GetComponent<ClickableImage>().LaysEggs)
                {
                    score++;
                }
                break;
        }
    }
}