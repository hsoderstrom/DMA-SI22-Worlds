using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTrigger : MonoBehaviour
{
    //drop the object you want to activate on Object To Activate in the editor
    public GameObject ObjectToActivate;

    //check Deactive On Exit in the editor if you want the object to deactivate when the player is not in the trigger
    public bool deactivateOnExit;
    
    void Start()
    {
    ObjectToActivate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //when something enters the Trigger the object activates
    void OnTriggerEnter(Collider other) 
    {
    ObjectToActivate.SetActive(true);
    }

    //when something exits the Trigger the object deactivates
    //(if we have checked the Deactivate On Exit box in the editor)
    void OnTriggerExit(Collider other) 
    {
    if(deactivateOnExit)
    ObjectToActivate.SetActive(false);
    }
}
