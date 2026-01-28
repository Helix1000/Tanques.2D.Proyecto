using UnityEngine;

public class Portal : MonoBehaviour
{
    private Rigidbody2D enteredRigybody;
    private float enterVelocity, exitVelocity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enteredRigybody = collision.gameObject.GetComponent<Rigidbody2D>();
        enterVelocity = enteredRigybody.linearVelocityX;

        if (gameObject.name == "BluePortal")
        {
            PortalControl.PortalControlInstance.DisableCollider("orange");
            PortalControl.PortalControlInstance.CreateClone("atOrange");
        }
        else if (gameObject.name == "OrangePortal")
        {
            PortalControl.PortalControlInstance.DisableCollider("blue");
            PortalControl.PortalControlInstance.CreateClone("atBlue");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        exitVelocity = enteredRigybody.linearVelocityX;

        if (enterVelocity != exitVelocity)
        {
            Destroy(GameObject.Find("Clone"));
        }
        else if (gameObject.name != "Clone")
        {
            Destroy(collision.gameObject);
            PortalControl.PortalControlInstance.EnableCollider();
            GameObject.Find("Clone").name = "Tank";
        }
    }
}
