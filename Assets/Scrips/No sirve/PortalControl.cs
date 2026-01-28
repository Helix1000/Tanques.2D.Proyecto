using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PortalControl : MonoBehaviour
{
    public static PortalControl PortalControlInstance;

    [SerializeField]
    private GameObject bluePortal, orangePortal;

    [SerializeField]
    private Transform bluePortalSpawnPoint, orangePortalSpawnPoint;

    private Collider2D bluePortalcollider, orangePortalcollider;

    [SerializeField]
    private GameObject clone;

    private void Start()
    {
        PortalControlInstance = this;
        bluePortalcollider = bluePortal.GetComponent<Collider2D>();
        orangePortalcollider = orangePortal.GetComponent<Collider2D>();

    }
    public void CreateClone(string WhereToCreate)

    {
        if (WhereToCreate == "atBlue")
        {
            var instantiatedClone = Instantiate(clone, bluePortalSpawnPoint.position, Quaternion.identity);
            instantiatedClone.gameObject.name = "Clone";
        }
        else if (WhereToCreate == "atOrange")
        {
            var instantiatedClone = Instantiate(clone, orangePortalSpawnPoint.position, Quaternion.identity);
            instantiatedClone.gameObject.name = "Clone";
        }
    }
    public void DisableCollider(string colliderToDisable)
    {
        if (colliderToDisable == "orange")
        {
            orangePortalcollider.enabled = false;
        }
        if (colliderToDisable == "blue")
        {
            bluePortalcollider.enabled = false;
        }
       
    }
    public void EnableCollider()
    {
        orangePortalcollider.enabled=true;
        bluePortalcollider.enabled=true;

    }
}

