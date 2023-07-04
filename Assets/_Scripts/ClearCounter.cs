using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    [SerializeField] private ClearCounter secondClearCounter;

    private Transform kitchenObjectTransform;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            if (secondClearCounter.kitchenObjectTransform == null)
            {
                kitchenObjectTransform.GetComponent<KitchenObject>().ClearCounter = secondClearCounter;
                secondClearCounter.kitchenObjectTransform = kitchenObjectTransform;
                kitchenObjectTransform = null;
            }

        }
    }

    public void Interact()
    {
        Debug.Log("Interact!");

        if (kitchenObjectTransform == null)
        {
            kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().ClearCounter = this;
        }
        else
        {
            Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().ClearCounter);
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }
}
