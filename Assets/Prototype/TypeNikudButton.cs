using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeNikudButton : MonoBehaviour
{
    public Button[] buttons;
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    Dictionary<Button, AudioClip> dict = new Dictionary<Button, AudioClip>();

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        for (int i = 0; i < buttons.Length; i++)
        {
            dict.Add(buttons[i], audioClips[i]);

            int back = i;
            buttons[i].onClick.AddListener(() => buttonCallBack(buttons[back], audioClips[back]));

        }



    }

    public void buttonCallBack(Button buttons, AudioClip audioClips)
    {
        Debug.Log(buttons);
        audioSource.clip = audioClips;
        audioSource.Play();

    }


}
