using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{

    public Button playButton;
    public Button stopButton;
    public Slider timeline;

    [SerializeField]
    Animator animator = default;

    [SerializeField]
    bool playing = false;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        playButton = root.Q<Button>("play-button");
        stopButton = root.Q<Button>("stop-button");
        timeline = root.Q<Slider>();
        
        playButton.clicked += PlayButtonPressed;
        //stopButton.clicked += StopButtonPressed;
        

        timeline.value = 0;
        timeline.highValue = animator.GetCurrentAnimatorStateInfo(0).length;
        timeline.label = timeline.value.ToString() + " / " + timeline.highValue.ToString();
        Time.timeScale = 0;
    }

    private void Update()
    {
        timeline.value = animator.GetCurrentAnimatorStateInfo(0).normalizedTime * timeline.highValue;
        timeline.label = timeline.value.ToString() + " / " + timeline.highValue.ToString();
        
    }

    void PlayButtonPressed ()
    {
        animator.SetBool("isMacing", true);
        switch (playing)
        {
            case true:
                Time.timeScale = 0;
                playing = false;
                playButton.text = "play";
                break;
            case false:
                Time.timeScale = 1;
                playing = true;
                playButton.text = "pause";
                break;
        }
        
    }

    /*
    void StopButtonPressed ()
    {s
        animator.SetBool("isMacing", false);
        Time.timeScale = 1;
        playing = false;
        playButton.text = "play";
    }

    /*
    void TimelinePressed ()
    {
        float normTime = timeline.value / timeline.highValue;
        animator.Play("Macarena Dance", 0, normTime);
    }
    */
}
