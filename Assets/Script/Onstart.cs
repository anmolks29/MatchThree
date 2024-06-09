using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onstart : MonoBehaviour
{
    [SerializeField] Animator row1Transition;
    [SerializeField] Animator row2Transition;
    [SerializeField] Animator row3Transition;
    [SerializeField] Animator row4Transition;
    [SerializeField] Animator col1Transition;
    [SerializeField] Animator col2Transition;
    [SerializeField] Animator col3Transition;
    [SerializeField] Animator bgTransition;
    [SerializeField] Animator matchPanelTransition;
    [SerializeField] Animator progressBarTransition;
    // Start is called before the first frame update
    
     void Awake()
    {
       /* bgTransition.SetBool("BgTransition", true);
        row1Transition.SetBool("Transition", true);
        row4Transition.SetBool("Transition", true);
        row2Transition.SetBool("Transition", true);
        row3Transition.SetBool("Transition", true);
        col1Transition.SetBool("Col1Transition", true);
        col2Transition.SetBool("Col2Transition", true);
        col3Transition.SetBool("Col3Transition", true);
        matchPanelTransition.SetBool("Match3PanelTransition", true);
        progressBarTransition.SetBool("ProgressBarTransition", true); */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
