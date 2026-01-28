using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ScreenBounds : MonoBehaviour
{
    public Camera mainCamera;
    BoxCollider2D boxCollider;

    public UnityEvent<Collider2D> ExitTriggerFired;

    [SerializeField]
    //private float teleportOffset = 0.2f;

    private void Awake()
    {
        this.mainCamera.transform.localScale = Vector3.one;
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
    }


    private void Start()
    {
        transform.position = Vector3.zero;
        UpdateBoundsSize();
    }

    private void UpdateBoundsSize()
    {
        float ySize = mainCamera.orthographicSize * 2;

        Vector2 boxCollidersSize = new Vector2(ySize * mainCamera.aspect, ySize);
        boxCollider.size = boxCollidersSize;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ExitTriggerFired?.Invoke(collision);
    }

    public bool AmIOutOfBounds(Vector3 worldPosition)
    {
        return
            Mathf.Abs(worldPosition.x) > Mathf.Abs(boxCollider.bounds.min.x) ||
            Mathf.Abs(worldPosition.y) > Mathf.Abs(boxCollider.bounds.min.y);
    }

    //public Vector2 CalculateWrappedPosition(Vector2 worldPosition)
    //{
    //    bool xBoundResult = 
    //        Mathf.Abs(worldPosition.x) > (Mathf.Sign(worldPosition.x));
    //    bool yBoundResult = 
    //        Mathf.Abs(worldPosition.y) > (Mathf.Sign(worldPosition.y));
    //    Vector2 signVector = 
    //        new Vector2(Mathf.Sign(worldPosition.x), Mathf.Sign(worldPosition.y));

    //    if (xBoundResult && yBoundResult)
    //    {
    //        return
    //    }

    //}
}
