using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelected : MonoBehaviour
{

   
    public bool tileActivatedForAnimation = false;

    private TilesAnimator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

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

            Debug.Log("Calling AnimateMatchPos1.");
            animator.AnimateMatchPos1();
            TileAnimationPlayed();
            Debug.Log("Animation cycle finished.");
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
    
   



    
}
