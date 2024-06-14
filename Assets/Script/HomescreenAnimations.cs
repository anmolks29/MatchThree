using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomescreenAnimations : MonoBehaviour
{
    public Animator cardAnimator;
    public Animator coinAnimator;
    public Animator homeIconAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(HomeCoinAnimation());
        StartCoroutine(HomeCardAnimation());
        StartCoroutine(HomeIconAnimator());
    }



    IEnumerator HomeCoinAnimation () 
    {
        yield return new WaitForSeconds(10);
        CoinAnimating();
        
    }
    IEnumerator HomeCardAnimation () 
    {
        yield return new WaitForSeconds(5);
        CardAnimating();


    }
    
    IEnumerator HomeIconAnimator () 
    {
        yield return new WaitForSeconds(5);
        HomeIconAnimating();


    }

    private void CoinAnimating()
    {
        coinAnimator.SetTrigger("Coin");
        coinAnimator.SetTrigger("Idle");
    } 
    private void CardAnimating()
    {
        cardAnimator.SetTrigger("Card");
        coinAnimator.SetTrigger("Idle");
    } 
    private void HomeIconAnimating()
    {
        homeIconAnimator.SetTrigger("HomeBg");
        coinAnimator.SetTrigger("Idle");
    }


}
