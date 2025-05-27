using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class revivir : MonoBehaviour
{

    public void revivirJugador ()
    {
        SceneManager.LoadScene("Level_1");
    }
    private void Start()
    {
        Cursor.visible = true;
    }


}
