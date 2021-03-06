﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public GameObject door_axis;
    public bool isOpen;
    AudioSource audioSource;
    public AudioClip aClip;

    // Start is called before the first frame update
    void Start()
    {
 //       animator = GetComponent<Animator>();
        animator = door_axis.GetComponent<Animator>();
        isOpen = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "RedKnight")
        {
            // update hp info
            ShowInfo.hp--;
            animator.SetTrigger("Open");
            isOpen = true;
 //           audioSource.Play();
            audioSource.PlayDelayed(0.5f);
            audioSource.PlayOneShot(aClip);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen && other.gameObject.tag == "RedKnight")
        {
            animator.SetTrigger("Close");
            isOpen = false;
            //           audioSource.Play();
            audioSource.PlayDelayed(0.5f);
            audioSource.PlayOneShot(aClip);
        }
    }
}
