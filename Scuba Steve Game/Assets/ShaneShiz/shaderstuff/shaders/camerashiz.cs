﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashiz : MonoBehaviour
{
    public Material Mat;

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, Mat);
    }
}
