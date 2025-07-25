using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableImage : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 originalPosition;
    private bool isDragging;

    [SerializeField] 
    private float returnSpeed = 5f;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalPosition = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            rectTransform.anchoredPosition += eventData.delta / GetComponentInParent<Canvas>().scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        GameObject dropTarget = eventData.pointerCurrentRaycast.gameObject;
        if (dropTarget != null && dropTarget.CompareTag("Red"))
        {
            GameManager.CheckIfCorrect(gameObject, 0);
            Destroy(gameObject);
        }
        else if (dropTarget != null && dropTarget.CompareTag("Blue"))
        {
            GameManager.CheckIfCorrect(gameObject, 1);
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(SmoothReturn());
        }
    }

    private IEnumerator SmoothReturn()
    {
        float elapsedTime = 0f;
        Vector2 startPos = rectTransform.anchoredPosition;

        while (elapsedTime < 1f)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(startPos, originalPosition, elapsedTime);
            elapsedTime += Time.deltaTime * returnSpeed;
            yield return null;
        }

        rectTransform.anchoredPosition = originalPosition;
    }
}