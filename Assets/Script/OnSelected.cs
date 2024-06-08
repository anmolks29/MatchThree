using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelected : MonoBehaviour
{

    public Animator column1Pos1Animator, column1Pos2Animator,column1Pos3Animator,column1Pos4Animator,column1Pos5Animator,column1Pos6Animator,column1Pos7Animator,column1Pos8Animator;
    public Animator column2Pos1Animator,column2Pos2Animator,column2Pos3Animator,column2Pos4Animator,column2Pos5Animator,column2Pos6Animator,column2Pos7Animator,column2Pos8Animator;
    //public Animator column3Pos1Animator,column3Pos2Animator,column3Pos3Animator,column3Pos4Animator,column3Pos5Animator,column3Pos6Animator,column3Pos7Animator,column3Pos8Animator*/
    //public Animator fishAnimator;
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
            // StartCoroutine(DelayAfterSelection());
            SelectedTileFly();
        }
    }

    public void TileOnSelected()
    {
        tileActivatedForAnimation = true;

        Debug.Log("tileActivatedForAnimation is now true");

    }
    public void SelectedTileFly()
    {
        //StartCoroutine(DelayAfterSelection());
        // row1Pos1Animator.SetBool("FlytoMatchPos1", true);


       column1Pos1Animator.SetBool("FlytoMatchPos1", true);
       column1Pos2Animator.SetBool("FlytoMatchPos1", true);
    }

    IEnumerator DelayAfterSelection() 
    {
        //fishAnimator.SetBool("Selected", true);
        yield return new WaitForSeconds(0.1f);

        
    }

    
}
