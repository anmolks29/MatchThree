using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VfxController : MonoBehaviour
{
    public VisualEffect vfx;
    public bool spaceKeyPressed = false;
    public Animator match3Pos1, match3Pos2, match3Pos3;
    // Start is called before the first frame update
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
        if (vfx == null)
        {
            Debug.LogError("Visual Effect component not found on this GameObject.");
            return;
        }
    }

    private void Awake()
    {
        vfx.enabled = true;
        vfx.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceKeyPressed = true;
            Debug.Log("Space key Pressed");
            AnimationCoroutine();
        }
        
    }
    public void AnimationCoroutine()
    {
        StartCoroutine(PlayAnimation());

    }
   

    IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(0.0f);
        vfx.enabled = true;
        vfx.Play();
        match3Pos1.SetBool("match3Anim", true);
        match3Pos2.SetBool("match3Anim", true);
        match3Pos3.SetBool("match3Anim", true);
        spaceKeyPressed = false;
        Debug.Log("VFX Animation Played");
        
    }
}
