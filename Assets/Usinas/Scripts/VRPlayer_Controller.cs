﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class VRPlayer_Controller : MonoBehaviour {

    public float speed = 2f;
    public float rotSpeed = 20f;
    public bool canMove;
    private Vector3 playerVelocity = Vector3.zero;
    private CharacterController playerController;

    public VRWand_Controller rightWand, leftWand;    

	void Start () {
        canMove = true;
        playerController = GetComponent<CharacterController>();
	}
	
    void FixedUpdate()
    {
        float rotFromRight = rightWand.rotInput;
        float rotFromLeft = leftWand.rotInput;

        transform.Rotate(Vector3.up * Time.fixedDeltaTime * rotSpeed* ((rotFromRight==0)?rotFromLeft:rotFromRight));
    }

}
