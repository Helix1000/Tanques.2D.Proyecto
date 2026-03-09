using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RememberCurrentSetGameObject : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private EventSystem eventSystem;

    [Tooltip("Arrastra aquí los objetos en orden de prioridad. Si el 1 está desactivado, elegirá el 2.")]
    [SerializeField] private List<GameObject> selectionPriority;

    private GameObject lastValidSelection;

    private void Awake()
    {
        if (eventSystem == null) eventSystem = EventSystem.current;
    }

    private void Update()
    {
        if (eventSystem == null) return;

        GameObject current = eventSystem.currentSelectedGameObject;

        // 1. Si hay algo seleccionado y está activo, lo recordamos como el último válido
        if (current != null && current.activeInHierarchy)
        {
            lastValidSelection = current;
        }
        // 2. Si NO hay nada seleccionado o lo que estaba seleccionado se desactivó
        else
        {
            TrySelectNextValid();
        }
    }

    private void TrySelectNextValid()
    {
        // Primero intentamos volver al último que funcionó (si sigue activo)
        if (lastValidSelection != null && lastValidSelection.activeInHierarchy)
        {
            eventSystem.SetSelectedGameObject(lastValidSelection);
            return;
        }

        // Si el último válido falló, recorremos la lista de prioridad
        foreach (GameObject obj in selectionPriority)
        {
            if (obj != null && obj.activeInHierarchy)
            {
                eventSystem.SetSelectedGameObject(obj);
                lastValidSelection = obj;
                return; // Salimos en cuanto encontramos uno válido
            }
        }
    }

    // Se ejecuta cada vez que el menú se activa
    private void OnEnable()
    {
        TrySelectNextValid();
    }
}
