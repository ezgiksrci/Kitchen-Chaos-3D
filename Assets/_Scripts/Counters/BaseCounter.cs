using System;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    public static event EventHandler OnAnythingDrop;

    [SerializeField] private Transform kitchenObjectFollowTransform;
    private KitchenObject kitchenObject;

    public static void ResetStaticData()
    {
        OnAnythingDrop = null;
    }

    public virtual void Interact(Player player)
    {
        Debug.LogError("BaseCounter Interact() called. This should be overridden in a child class.");
    }

    public virtual void InteractAlternate(Player player)
    {
        Debug.LogError("BaseCounter InteractAlternate() called. This should be overridden in a child class.");
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return kitchenObjectFollowTransform;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;

        if (kitchenObject != null)
        {
            OnAnythingDrop?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
}
