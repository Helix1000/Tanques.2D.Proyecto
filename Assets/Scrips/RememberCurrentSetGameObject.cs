using UnityEngine;
using UnityEngine.EventSystems;

public class RememberCurrentSetGameObject : MonoBehaviour
{
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private GameObject lastSelectedElement;

    private void Reset()
    {
        eventSystem = FindFirstObjectByType<EventSystem>();

        if (!eventSystem)
        {
            Debug.Log("Did not find event sistem in your scene", this);
            return;
        }

        lastSelectedElement = eventSystem.firstSelectedGameObject;
    }

    private void Update()
    {
        if(!eventSystem)
            return;

        if(eventSystem.currentSelectedGameObject && 
            lastSelectedElement != eventSystem.currentSelectedGameObject)
            lastSelectedElement = eventSystem.currentSelectedGameObject;

        if(!eventSystem.currentSelectedGameObject && lastSelectedElement)
            eventSystem.SetSelectedGameObject(lastSelectedElement);
    }
}
