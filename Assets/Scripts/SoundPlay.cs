
using UnityEngine;

using System.Collections;
public class SoundPlay : MonoBehaviour
{
    //将准备好的MP3格式的背景声音文件拖入此处
    public AudioClip backgroundMusic;
    //用于控制声音的AudioSource组件
    private AudioSource _audioSource;
    //是否播放游戏背景音乐
    private bool isPlayMusic;
    //字体
    public Font customFont;
    void Awake()
    {
        //在添加此脚本的对象中添加AudioSource组件，此处为摄像机
        _audioSource = this.gameObject.AddComponent<AudioSource>();
        //设置循环播放
        _audioSource.loop = true;
        //设置音量为最大，区间在0-1之间
        _audioSource.volume = 1.0f;
        //设置audioClip
        _audioSource.clip = backgroundMusic;
    }
    void Update()
    {
        //如果isPlayMusic为false,则暂停播放背景音乐
        if (isPlayMusic == false) _audioSource.Pause();
    }
    void OnGUI()
    {
        //设置字体
        GUI.skin.label.font = customFont;
        //绘制播放按钮并设置其点击后的处理
        if (GUI.Button(new Rect(10, 10, 80, 30), "Play"))
        {
            //播放声音
            if (isPlayMusic) _audioSource.Play();
        }
        //绘制暂停按钮并设置其点击后的处理
        if (GUI.Button(new Rect(10, 50, 80, 30), "Pause"))
        {
            //暂停声音，暂停后再播放，则声音为继续播放
            _audioSource.Pause();
        }
        //绘制停止按钮并设置其点击后的处理
        if (GUI.Button(new Rect(10, 90, 80, 30), "Stop"))
        {
            //停止播放，停止后再播放，则声音为从头播放
            _audioSource.Stop();
        }
        //音量控制Label
        GUI.Label(new Rect(10, 130, 100, 30), "音量大小调节");
        //音量控制slider
        _audioSource.volume = GUI.HorizontalSlider(new Rect(120, 130, 100, 20), _audioSource.volume, 0.0f, 1.0f);
        //选择是否播放背景音乐
        isPlayMusic = GUI.Toggle(new Rect(10, 170, 100, 20), isPlayMusic, "BGM");
    }
}