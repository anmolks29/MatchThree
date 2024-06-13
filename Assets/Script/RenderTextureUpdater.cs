using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTextureUpdater : MonoBehaviour
{
    public Camera renderTextureCamera;
    public RenderTexture renderTexture;

    void Start()
    {
        // Ensure the camera is set up to render to the texture
        if (renderTextureCamera != null && renderTexture != null)
        {
            renderTextureCamera.targetTexture = renderTexture;
        }
    }
}

