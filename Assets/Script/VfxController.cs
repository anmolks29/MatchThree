using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VfxController : MonoBehaviour
{
    public VisualEffect vfx;
    public bool spaceKeyPressed = false;
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
        }
        PlayAnimation();
    }
    public void AnimationCoroutine()
    {
        StartCoroutine(PlayAnimation());

    }
   

    IEnumerator PlayAnimation()
    {
        yield return new WaitForSeconds(0.3f);
        vfx.enabled = true;
        vfx.Play();
        spaceKeyPressed = false;
        Debug.Log("VFX Animation Played");
        
    }
}
