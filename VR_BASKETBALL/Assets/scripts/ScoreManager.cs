using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textscore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Basketball")
        { 
            AddScore(); 
        }

        if (other.transform.root.name == "Player")
        {
          scoreIn = 3;
        }

    }
    private void OnTriggerExit(Collider other)

    { if (other.transform.root.name == "Player")
        
          scoreIn = 2;
        }

private void AddScore()
    {
        score += scoreIn;
        textscore.text = "分數:" + score;
        aud.PlayOneShot(soundIn, Random.Range(1, 2));
    }
}
