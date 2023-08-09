using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        // Check if this ClearCounter has a kitchen object placed on it.
        if (HasKitchenObject())
        {
            // If the player doesn't have a kitchen object, place the ClearCounter's kitchen object onto the player.
            if (!player.HasKitchenObject())
            {
                // Set the parent of the kitchen object to the player.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
        // If this ClearCounter doesn't have a kitchen object placed on it.
        else if (!HasKitchenObject())
        {
            // Check if the player has a kitchen object.
            if (player.HasKitchenObject())
            {
                // Place the player's kitchen object onto this ClearCounter.
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
        }
    }
}
