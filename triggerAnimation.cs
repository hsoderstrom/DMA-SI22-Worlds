using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation : MonoBehaviour
{
    //drop the object you want to activate on Object To Activate in the editor
    public Animator ObjectToAnimate;

    //check Deactive On Exit in the editor if you want the object to deactivate when the player is not in the trigger
    public bool stopPlayingOnExit;
    
    void Start()
    {
        ObjectToAnimate.SetBool("animate", false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //when something enters the Trigger the object activates
    void OnTriggerEnter(Collider other) 
    {
    ObjectToAnimate.SetBool("animate", true);
    }

    //when something exits the Trigger the object deactivates
    //(if we have checked the Deactivate On Exit box in the editor)
    void OnTriggerExit(Collider other) 
    {
        if(stopPlayingOnExit)
        ObjectToAnimate.SetBool("animate", false);
    }
}