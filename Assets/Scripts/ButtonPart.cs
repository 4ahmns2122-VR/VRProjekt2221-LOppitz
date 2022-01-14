using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPart : MonoBehaviour
{
    
    public int id = -1;

    public ButtonManager bManager;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.name == "RightHandBaseController")
        {
            
           

            if (id == bManager.currentID)
           {
                Debug.Log(id + " " + bManager.currentID); 
                bManager.currentID += 1;
                
                if (bManager.currentID == 2)
                {
                    bManager.startAudio = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
