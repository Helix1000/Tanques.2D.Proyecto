using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetUiElementToSelectOnInteraction : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private Selectable elementToSelect;

    [Header("Visualization")]
    [SerializeField] private bool showVisualization;
    [SerializeField] private Color navigationColour = Color.cyan;

    private void OnDrawGizmos()
    {
        if (!showVisualization)
            return;

        if(elementToSelect == null)
            return;

        Gizmos.color = navigationColour;
        Gizmos.DrawLine(gameObject.transform.position, elementToSelect.gameObject.transform.position);
    }
    private void Reset()
    {
        eventSystem = FindFirstObjectByType<EventSystem>();

        if (elementToSelect == null)
            Debug.Log("Did not find event sistem in your scene", this);
    }
    public void JumpToElement()
    {
        if (eventSystem = null)
            Debug.Log("This item has no event sysyem reference yet", this);

        eventSystem.SetSelectedGameObject(elementToSelect.gameObject);
    }
}
