using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{

    public Button playButton;
    public Button stopButton;
    public Slider timeline;

    private float oldTime;

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

        // TODO add slowmo

        timeline.RegisterCallback<ClickEvent>(TimelinePressed);
        

        timeline.value = 0;
        timeline.highValue = animator.GetCurrentAnimatorStateInfo(0).length;
        timeline.label = timeline.value.ToString() + " / " + timeline.highValue.ToString();
        Time.timeScale = 0;
    }

    private void TimelinePressed(ClickEvent evt)
    {
        Debug.Log("TimelinePressed");
    }

    private void Update()
    {
        if (oldTime != timeline.value)
        {
            float normTime = timeline.value / timeline.highValue;
            animator.Play("Macarena Dance", 0, normTime);
        } else
        {
            timeline.value = animator.GetCurrentAnimatorStateInfo(0).normalizedTime * timeline.highValue;
        }
        timeline.label = convertToTimestamp(timeline.value.ToString()) + " / " + convertToTimestamp(timeline.highValue.ToString());
        
        oldTime = timeline.value;
    }

    private string convertToTimestamp (string timeValue)
    {
        string timeStamp = "";
        string[] values = timeValue.Split(',', 2);

        int min, sec;
        if (System.Int32.TryParse(values[0], out sec))
        {
            min = sec / 60;
            sec = sec % 60;
            if (min > 9 && sec > 9)
                timeStamp += min + ":" + sec;
            if (min > 9)
                timeStamp += min + ":0" + sec;
            if (sec > 9)
                timeStamp += "0" + min + ":" + sec;
            else
                timeStamp += "0" + min + ":0" + sec;

        } else
        {
            timeStamp += "00:" + values[0];
        }


        /* // wie detailiert sollte der timestamp sein ?
         * 
         * int milsec;
         * System.Int32.TryParse(values[1], out milsec);
         */

        return timeStamp;
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
    */

    void TimelinePressed ()
    {
        float normTime = timeline.value / timeline.highValue;
        animator.Play("Macarena Dance", 0, normTime);
    }
}
