using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockUpravlenie : MonoBehaviour {

    Rigidbody rigidBody;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("a Pressed");
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("D Pressed");
            transform.Rotate(-Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            print("S Pressed");
        }
    }
}
