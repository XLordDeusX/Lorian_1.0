using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject bridgeActive, 
                      bridgeInactive,
                      lightActive,
                      lightInactive;

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
            bridgeInactive.SetActive(false);
            lightInactive.SetActive(false);
            bridgeActive.SetActive(true);
            lightActive.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D notPushing)
    {
        MovableObject statueAway = notPushing.GetComponent<MovableObject>();

        if(statueAway != null)
        {
            buttonAnimation.SetBool("Pushed", false);
            bridgeInactive.SetActive(true);
            lightInactive.SetActive(true);
            bridgeActive.SetActive(false);
            lightActive.SetActive(false);
        }
    }
}
