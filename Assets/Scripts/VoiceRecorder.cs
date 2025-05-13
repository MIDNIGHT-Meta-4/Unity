using UnityEngine;

//마이크 녹음하는 클래스
using UnityEngine;

public class VoiceRecorder : MonoBehaviour
{
    public string microphoneName;
    public AudioClip recordedClip;
    public int sampleRate = 44100;
    public float maxRecordTime = 10f;

    public bool IsRecording => Microphone.IsRecording(microphoneName);

    public void StartRecording()
    {
        microphoneName = Microphone.devices[0];  // 첫 번째 마이크 사용
        recordedClip = Microphone.Start(microphoneName, false, (int)maxRecordTime, sampleRate);
        Debug.Log("🎤 녹음 시작");
    }

    public void StopRecording()
    {
        Microphone.End(microphoneName);
        Debug.Log("🛑 녹음 종료");
    }

    public AudioClip GetClip() => recordedClip;
}
