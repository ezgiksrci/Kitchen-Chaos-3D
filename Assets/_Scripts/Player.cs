using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;

    [SerializeField] LayerMask clearCounterLayer;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float turnSpeed = 20f;

    private Vector3 lastInteractDir;

    private bool isWalking;
    private bool canMove;


    private void Update()
    {
        HandleMovement();
        HandleInteractions();
    }

    private void HandleInteractions()
    {
        Vector2 inputVector = gameInput.GetInputVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        if (moveDir != Vector3.zero)
            lastInteractDir = moveDir;

        float interactDistance = 1.5f;
        if (Physics.Raycast(transform.position, lastInteractDir, out RaycastHit hitInfo, interactDistance, clearCounterLayer))
        {
            Debug.Log("Interact!");
        }

    }

    public bool IsWalking()
    {
        return isWalking;
    }

    private void HandleMovement()
    {
        float playerRadius = 0.7f;
        float playerHeight = 2f;

        Vector2 inputVector = gameInput.GetInputVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime;

        //Can move in the direction of the input?
        canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir, moveDistance);

        //If can't move in the direction of the input, try to move in the direction of the x axis
        if (!canMove)
        {
            Vector3 moveDirX = new Vector3(moveDir.x, 0, 0).normalized;
            canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirX, moveDistance);

            //If can move in the direction of the x axis, move in that direction
            if (canMove)
                moveDir = moveDirX;

            //If can't move in the direction of the x axis, try to move in the direction of the z axis
            else if (!canMove)
            {
                Vector3 moveDirZ = new Vector3(0, 0, moveDir.z).normalized;
                canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirZ, moveDistance);

                //If can move in the direction of the z axis, move in that direction
                if (canMove)
                    moveDir = moveDirZ;

                //Can't move in any direction
                else
                    moveDir = Vector3.zero;
            }
        }

        if (canMove)
        {
            transform.position += moveDir * moveDistance;
        }

        isWalking = moveDir != Vector3.zero;

        if (isWalking)
            transform.forward = Vector3.Slerp(transform.forward, moveDir, turnSpeed * Time.deltaTime);
    }
}
