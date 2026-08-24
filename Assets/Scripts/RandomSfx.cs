using System.Collections;
using UnityEngine;

public class RandomSfx : MonoBehaviour
{
    [SerializeField] AudioClip[] sfxList;
    [SerializeField] float sfxDelay = 10f;
    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlaySfxs());
    }

    IEnumerator PlaySfxs()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.value * sfxDelay);
            AudioClip audioClip = sfxList[Random.Range(0, sfxList.Length)];
            audioSource.PlayOneShot(audioClip);
            yield return new WaitForSeconds(audioClip.length);
        }
    }
}
