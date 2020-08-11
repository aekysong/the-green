using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNewStart : MonoBehaviour {

	public void ToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
