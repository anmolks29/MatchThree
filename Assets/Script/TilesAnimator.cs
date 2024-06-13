using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class TilesAnimator : MonoBehaviour
{
    public Animator animator;

    public static TilesAnimator instance;
 
    private void OnEnable()
    {
        if (instance == null)
        {
            instance = this;
            animator = GetComponent<Animator>();
            if (animator == null)
            {
                Debug.LogError("Animator component not found on TilesAnimator GameObject!");
            }
            else
            {
                Debug.Log("TilesAnimator initialized with Animator.");
            }
        }
        else
        {
            Debug.LogWarning("Multiple instances of TilesAnimator detected! Destroying duplicate.");
            
        }
        
    }

    public void AnimateMatchPos1()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos1' to true.");
            animator.SetBool("FlytoMatchPos1", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos1'!");
        }
    }

    IEnumerator TurnAnimationFalse()
    {
        yield return new WaitForSeconds(0.4f);
        animator.SetBool("FlytoMatchPos1", false);
        
        Destroy(gameObject);
    }

   


}
