using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag=="snow")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadSpace",.4f);
        }
    }
    void ReloadSpace()
    {
        SceneManager.LoadScene(0);
    }
}
