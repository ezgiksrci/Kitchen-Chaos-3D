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
            // If player is holding a Plate.
            else if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
            {
                if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                {
                    GetKitchenObject().DestroySelf();
                }
            }
            //If player is not holding Plate but something else.
            else if (GetKitchenObject().TryGetPlate(out plateKitchenObject))
            {
                if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO()))
                {
                    player.GetKitchenObject().DestroySelf();
                }
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
