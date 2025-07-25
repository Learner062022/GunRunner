using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    CharacterController characterController;

    [Header("Camera & Looking")]
    public Transform lookCamera;
    public float sensitivityX = 15f;
    public float sensitivityY = 15f;
    public float minY = -90f;
    public float maxY = 90f;
    float currentYRotation;
    //Quaternion yawRotation;
    //Quaternion pitchRotation;

    [Header("Movement")]
    public float moveSpeed = 8f;
    public float gravity = -20f;

    [Header("Shooting")]
    public float shootRange = 500f;
    public LayerMask shootMask;
    public float fireRate = 0.5f;
    bool firing = false;

    Vector2 aimVector;
    Vector3 inputVector;
    bool fire;

    void Start() {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        GetInput();
        Move();
        Look();
        Shoot();
    }

    public void Shoot() {
        if (firing) return;

        if (Physics.Raycast(lookCamera.position, lookCamera.forward, out RaycastHit hit, shootRange, shootMask))
        {
            //Debug.DrawLine(lookCamera.position, hit.point, Color.red, 2);
            //Debug.Log("Hit: " + hit.collider.name);
        }

        StartCoroutine(FireRoutine());
    }

    IEnumerator FireRoutine() {
        firing = true;
        yield return new WaitForSeconds(fireRate);
        firing = false;
    }

    void GetInput() {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.z = Input.GetAxis("Vertical"); 

        if (inputVector.magnitude > 1) {
            inputVector.Normalize();
        }

        aimVector.x = Input.GetAxis("Mouse X");
        aimVector.y = Input.GetAxis("Mouse Y");

        fire = Input.GetButtonDown("Fire1");
    }

    public void Move() {
        Vector3 moveVector = transform.TransformDirection(inputVector.normalized);
        moveVector *= moveSpeed;
        moveVector.y = gravity;
        moveVector *= Time.deltaTime;
        characterController.Move(moveVector);
    }

    void Look() {
        transform.Rotate(transform.up, aimVector.x * sensitivityX);
        currentYRotation += aimVector.y * sensitivityY;
        currentYRotation = Mathf.Clamp(currentYRotation, minY, maxY);
        lookCamera.eulerAngles = new Vector3(-currentYRotation, lookCamera.eulerAngles.y, lookCamera.eulerAngles.z);
        //yawRotation = Quaternion.Euler(0f, aimVector.x * sensitivityX, 0f);
        //transform.rotation *= yawRotation;
        //currentYRotation += aimVector.y * sensitivityY;
        //currentYRotation = Mathf.Clamp(currentYRotation, minY, maxY);
        //pitchRotation = Quaternion.Euler(-currentYRotation, 0f, 0f);
        //lookCamera.localRotation = pitchRotation;

        // understand why no longer needed before deleting
    }
}