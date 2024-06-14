using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraAnimations : MonoBehaviour
{
    public Animator coinAdding;
    public Animator star1Animation;
    public Animator star2Animation;
    public Animator star3Animation;
    public ParticleSystem star1particle;
    public ParticleSystem star2particle;
    public ParticleSystem star3particle;
    public bool spaceKeyPressed = false;
    public bool sKeyPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceKeyPressed = true;
            Debug.Log("Space key Pressed");
            PlayCoinAddingAnimaation();
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            sKeyPressed = true;
            Debug.Log("S key Pressed");
            PlayStar1Animaation();
            PlayStar2Animaation();
            PlayStar3Animaation();
        }

    }

    public void PlayCoinAddingAnimaation()
    {
        coinAdding.SetTrigger("CoinAdded");
        coinAdding.SetTrigger("CoinIdle");
        spaceKeyPressed = false;
    }
    
    public void PlayStar1Animaation()
    {
        star1Animation.SetTrigger("StarAnimation");
        star1Animation.SetTrigger("StarIdle");
        star1particle.Play();
        sKeyPressed = false;
    }
    public void PlayStar2Animaation()
    {
        star2Animation.SetTrigger("StarAnimation");
        star2Animation.SetTrigger("StarIdle");
        star2particle.Play();
        sKeyPressed = false;
    }
    public void PlayStar3Animaation()
    {
        star3Animation.SetTrigger("StarAnimation");
        star3Animation.SetTrigger("StarIdle");
        star3particle.Play();
        sKeyPressed = false;
    }
}
