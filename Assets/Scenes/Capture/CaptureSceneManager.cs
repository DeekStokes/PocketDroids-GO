using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManager : PocketDroidsSceneManager
{
    public override void PlayerTapped()
    {
        print("CaptureSceneManager.PlayerTapped activated");
    }
    public override void droidTapped(GameObject droid)
    {
        print("CaptureSceneManager.droidTapped activated");
    }


}
