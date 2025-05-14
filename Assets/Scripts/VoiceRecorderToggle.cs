using UnityEngine;

public class VoiceRecorderToggle : MonoBehaviour
{
    private bool isRecording = false;

    [SerializeField] private VoiceRecorder recorder;   // 녹음 담당
    [SerializeField] private VoiceSender sender;       // 전송 담당

    public void ToggleRecording()
    {
        if (!isRecording)
        {
            recorder.StartRecording();
            isRecording = true;
        }
        else
        {
            recorder.StopRecording();
            sender.SendAudio(); // 전송 시작
            isRecording = false;
        }
    }
}
