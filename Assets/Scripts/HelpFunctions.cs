using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HelpFunctions
{
    public static void MoveTheThing(Rigidbody2D rb, float X, float Y, float speed) {
        Vector2 dir = new Vector2(X,Y);
        dir.Normalize();
        rb.velocity = dir * speed;
    }

    public static void CrashTheGame() { CrashTheGame("Message"); }

    public static void CrashTheGame(string str) {
        if(str == "OS") {
            UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.AccessViolation); //Error box + OS error
        }
        if(str == "Message") {
            UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.FatalError); //Error message
        }
        if(str == "Simple") {
            UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.Abort); //Error box
        }
        if(str == "BlackSheep") {
            UnityEngine.Diagnostics.Utils.ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory.PureVirtualFunction); //Error box
        }
    }
}
