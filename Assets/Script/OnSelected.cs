using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelected : MonoBehaviour
{

    public Animator row1Pos1Animator;
    public Animator fishAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TileOnSelected()
    {
        fishAnimator.SetBool("Selected", true);
    }
    public void SelectedTileFly()
    {
        StartCoroutine(DelayAfterSelection());
    }

    IEnumerator DelayAfterSelection() 
    {
        yield return new WaitForSeconds(0.15f);


        row1Pos1Animator.SetBool("FlytoMatchPos1", true);
    }
}
