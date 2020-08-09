using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleNeckCut : MonoBehaviour
{

    public Animator AnimCOntroller;
    public Animator AnimController2;
    public Animator AnimController3;
    public GameObject position2,position3;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Making Animator Controller Respond To Touch and pause when not touching
        AnimCOntroller.enabled = false;

        if (Input.touchCount > 0)
        {
            AnimCOntroller.enabled = true;
        }
        else if (Input.touchCount == 0)
        {
            AnimCOntroller.enabled = false;
        }
        //Making Animator Controller Respond To Touch and pause when not touching




        // Changing Camera Position and rotation when Animation finish
        if (AnimCOntroller.GetCurrentAnimatorStateInfo(0).IsName("Bell_Paper_Cutout_Knife_Stop"))
        {
            transform.position = Vector3.Lerp(transform.position, position2.transform.position,Time.deltaTime * speed);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(new Vector3(38.8f,-61.404f,0)),Time.deltaTime * speed);
        }
        else if (AnimCOntroller.GetCurrentAnimatorStateInfo(0).IsName("Bell_Paper_Cutout_Knife_Stop_2"))
        {
            transform.position = Vector3.Lerp(transform.position, position3.transform.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(45f, -90f, 0)), Time.deltaTime * speed);
        }
        // Changing Camera Position and rotation when Animation finish



        // Setting The Current Object On Scene as object we want to Control animaton
        if (this.gameObject.transform.position == position2.transform.position)
        {
            AnimCOntroller = AnimController2;
            AnimCOntroller.SetBool("Start", true);
        }
        else if(this.gameObject.transform.position == position3.transform.position)
        {
            AnimCOntroller = AnimController3;
            AnimCOntroller.SetBool("Start2", true);
        }
        // Setting The Current Object On Scene as object we want to Control animaton
    }
}
