using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class OnSelected : MonoBehaviour
{

    public bool tileActivatedForAnimation = false;
    private TilesAnimator animator;

    private bool tileMovingto1stMatch3Pos = false;
    private bool tileMovingto2ndMatch3Pos = false;
    private bool tileMovingto3rdMatch3Pos = false;

    // Update is called once per frame
    void Update()
    {

        if(tileActivatedForAnimation)
        {
            Debug.Log("tileActivatedForAnimation is true. Checking animator.");

            if (animator == null)
            {
                animator = TilesAnimator.instance;
                if (animator == null)
                {
                    Debug.LogError("TilesAnimator instance not found in Update!");
                    return;
                }
                else
                {
                    Debug.Log("TilesAnimator instance found in Update.");
                }
            }

            if (tileMovingto1stMatch3Pos)
            {
                animator.AnimateMatchPos1();
                TileAnimationPlayed();
                tileMovingto1stMatch3Pos = false;
                Debug.Log("Animation cycle finished.");
            } 
            if (tileMovingto2ndMatch3Pos)
            {
                animator.AnimateMatchPos2();
                TileAnimationPlayed();
                tileMovingto2ndMatch3Pos = false;
                Debug.Log("Animation cycle finished.");
            }
            if (tileMovingto3rdMatch3Pos)
            {
                animator.AnimateMatchPos3();
                TileAnimationPlayed();
                tileMovingto3rdMatch3Pos = false;
                Debug.Log("Animation cycle finished.");
            }
            
        }
        
    }

    public void TileOnSelected()
    {
        Debug.Log("TileOnSelected called. Activating tile for animation.");

        tileActivatedForAnimation = true;

        // Ensure the TilesAnimator is enabled
        GameObject tilesAnimatorObject = TilesAnimator.instance?.gameObject;
        
        if (tilesAnimatorObject != null)
        {
            if (!tilesAnimatorObject.activeSelf)
            {
                Debug.Log("Enabling TilesAnimator GameObject.");
                tilesAnimatorObject.SetActive(true);
            }

            animator = TilesAnimator.instance;

            if (animator != null)
            {
                Debug.Log("TilesAnimator instance found in TileOnSelected.");
            }
            else
            {
                Debug.LogError("TilesAnimator instance not found after enabling in TileOnSelected!");
            }
        }
        else
        {
            Debug.LogError("TilesAnimator GameObject not found in TileOnSelected!");
        }
    }
    public void TileAnimationPlayed()
    {
        tileActivatedForAnimation = false;
        Debug.Log("tileActivatedForAnimation = false");
    }

    public void FirstTilesClicked()
    {
        tileMovingto1stMatch3Pos = true;
    }
    public void SecondTilesClicked()
    {
        tileMovingto2ndMatch3Pos = true;
    }
    public void ThirdTilesClicked()
    {
        tileMovingto3rdMatch3Pos = true;
    }












}
