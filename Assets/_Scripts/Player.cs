using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float turnSpeed = 20f;


    private bool isWalking;

    private void Update()
    {

        Vector2 inputVector = gameInput.GetInputVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;

        if (isWalking)
        {
            transform.forward = Vector3.Slerp(transform.forward, moveDir, turnSpeed * Time.deltaTime);
        }

    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
