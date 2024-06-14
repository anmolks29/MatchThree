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
            Debug.LogWarning("Multiple instances of TilesAnimator detected! ");
            
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
    public void AnimateMatchPos2()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos2' to true.");
            animator.SetBool("FlytoMatchPos2", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos2'!");
        }
    }
    public void AnimateMatchPos3()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos3' to true.");
            animator.SetBool("FlytoMatchPos3", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos3'!");
        }
    }
    public void AnimateMatchPos4()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos4' to true.");
            animator.SetBool("FlytoMatchPos4", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos4'!");
        }
    } 
    public void AnimateMatchPos5()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos5' to true.");
            animator.SetBool("FlytoMatchPos5", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos5'!");
        }
    }
    public void AnimateMatchPos6()
    {
        if (animator != null)
        {
            Debug.Log("Setting 'FlytoMatchPos6' to true.");
            animator.SetBool("FlytoMatchPos6", true);
            StartCoroutine(TurnAnimationFalse());
        }
        else
        {
            Debug.LogError("Animator is null when trying to set 'FlytoMatchPos6'!");
        }
    }

    IEnumerator TurnAnimationFalse()
    {
        yield return new WaitForSeconds(0.4f);
        animator.SetBool("FlytoMatchPos1", false);
        
        Destroy(gameObject);
    }

   


}
