////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;

public class CameraZone : MonoBehaviour
{
    public Camera newCam;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerManager.Instance.cameraScript.ChangeCamera(new PlayerCamera.CameraEvent(newCam, 1f, 0f, false));
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerManager.Instance.cameraScript.ResetCamera();
        }
    }

}
