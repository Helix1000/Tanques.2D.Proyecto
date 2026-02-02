using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    private HashSet<GameObject> portalObjects = new HashSet<GameObject>();

    [SerializeField]
    private Transform destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (!collision.CompareTag("Player"))
        //{
        //    return;
        //}
        //if (!collision.CompareTag("Bala"))
        //{
        //    return;
        //}
        if (portalObjects.Contains(collision.gameObject))
        {
            return;
        }
        if (destination.TryGetComponent(out Portals destinationPortal))
        {
            destinationPortal.portalObjects.Add(collision.gameObject);
        }

        collision.transform.position = destination.position;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        //if (!collision.CompareTag("Player"))
        //{
        //    return;
        //}
        //if  (!collision.CompareTag("Bala"))
        //{
        //    return;
        //}
        portalObjects.Remove(collision.gameObject);
    }
}
