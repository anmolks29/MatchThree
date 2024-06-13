using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Match3Animation : MonoBehaviour
{
    public Animator match3Pos1Anim, match3Pos2Anim, match3Pos3Anim, match3Pos4Anim, match3Pos5Anim, match3Pos6Anim;
    public GameObject match3Pos1, match3Pos2, match3Pos3, match3Pos4, match3Pos5, match3Pos6;
    //public VisualEffect match3Spark;
    public static Match3Animation instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void EnableMatch3Postion1()
    {
        match3Pos1.SetActive(true);
    }
    public void EnableMatch3Postion2()
    {
        match3Pos2.SetActive(true);
    }
    public void EnableMatch3Postion3()
    {
        match3Pos3.SetActive(true);
    }
    public void EnableMatch3Postion4()
    {
        match3Pos4.SetActive(true);
    }
    public void EnableMatch3Postion5()
    {
        match3Pos5.SetActive(true);
    }
    public void EnableMatch3Postion6()
    {
        match3Pos6.SetActive(true);
    }

    public void PlayMatch3Postion1()
    {
        match3Pos1Anim.SetBool("match3Anim", true);
    }
    public void PlayMatch3Postion2()
    {
        match3Pos2Anim.SetBool("match3Anim", true);
    }
    public void PlayMatch3Postion3()
    {
        match3Pos3Anim.SetBool("match3Anim", true);
    }
    public void PlayMatch3Postion4()
    {
        match3Pos4Anim.SetBool("match3Anim", true);
    }
    public void PlayMatch3Postion5()
    {
        match3Pos5Anim.SetBool("match3Anim", true);
    }
    public void PlayMatch3Postion6()
    {
        match3Pos6Anim.SetBool("match3Anim", true);
    }

}
