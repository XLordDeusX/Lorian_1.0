using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    private Animator buttonAnimation;

    void Start()
    {
        buttonAnimation = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D pushing)
    {
        MovableObject statueOnButton = pushing.GetComponent<MovableObject>();

        if(statueOnButton != null)
        {
            buttonAnimation.SetBool("Pushed", true);
            GameManager.instance.buttons.Add(this);
            GameManager.instance.StateOn();
        }
    }

    private void OnTriggerExit2D(Collider2D notPushing)
    {
        MovableObject statueAway = notPushing.GetComponent<MovableObject>();

        if(statueAway != null)
        {
            buttonAnimation.SetBool("Pushed", false);
            GameManager.instance.buttons.Remove(this);
            GameManager.instance.StateOff();
        }

        
    }
}
