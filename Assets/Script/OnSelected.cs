using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelected : MonoBehaviour
{

    public Animator row1Pos1Animator;
    public Animator fishAnimator;
    public bool tileActivatedForAnimation = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tileActivatedForAnimation == true)
        {
            AnimateSelectedTile();
            SelectedTileFly();
            tileActivatedForAnimation = false;
            Debug.Log("Animation run");
        }
    }

    public void TileOnSelected()
    {
        tileActivatedForAnimation = true;
        
    }
    public void SelectedTileFly()
    {
        //StartCoroutine(DelayAfterSelection());
        row1Pos1Animator.SetBool("FlytoMatchPos1", true);
    }

    IEnumerator DelayAfterSelection() 
    {
        yield return new WaitForSeconds(0.15f);


        row1Pos1Animator.SetBool("FlytoMatchPos1", true);
    }

    private void AnimateSelectedTile()
    {
        fishAnimator.SetBool("Selected", true);
    }
}
