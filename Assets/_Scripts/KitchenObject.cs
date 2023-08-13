using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private IKitchenObjectParent kitchenObjectParent;

    public void DestroySelf()
    {
        // Clear KitchenObject's parent and destroy the KitchenObject.
        kitchenObjectParent.ClearKitchenObject();
        Destroy(gameObject);
    }

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    // Sets the parent for the kitchen object and handles related actions.
    public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        if (this.kitchenObjectParent != null)
        {
            // Clears the previous kitchen object if one exists in the current parent.
            this.kitchenObjectParent.ClearKitchenObject();
        }

        // Set the new kitchen object parent.
        this.kitchenObjectParent = kitchenObjectParent;

        if (this.kitchenObjectParent.HasKitchenObject())
        {
            // Check if the new parent already has a kitchen object and if it's true display an error.
            Debug.LogError("Counter already has a Kitchen Object!");
        }

        // Set this KitchenObject as the Parent's KitchenObject.
        this.kitchenObjectParent.SetKitchenObject(this);

        // Update KitchenObject's position to Parent's given position.
        transform.parent = this.kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public IKitchenObjectParent GetKitchenObjectParent()
    {
        return this.kitchenObjectParent;
    }

    public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

        KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

        kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

        return kitchenObject;
    }
}
