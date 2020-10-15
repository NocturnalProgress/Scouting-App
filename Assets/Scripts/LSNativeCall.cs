using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class LSNativeCall
{
    [DllImport("__Internal")]
    private static extern void UIActivityVC(TextAsset file);

    public static void ShowUIActivityVC(TextAsset file)
    {
#if UNITY_IPHONE
        UIActivityVC(file);
#endif
    }
}
