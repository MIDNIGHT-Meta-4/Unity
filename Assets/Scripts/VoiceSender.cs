using UnityEngine;

//서버로 전송해주는 클래스
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class VoiceSender : MonoBehaviour
{
    public VoiceRecorder recorder;
    public string serverURL = "http://your-server-address/upload"; // <- API 주소 대입

    public void SendAudio()
    {
        AudioClip clip = recorder.GetClip();
        byte[] wavData = WavUtility.FromAudioClip(clip);
        StartCoroutine(SendToServer(wavData));
    }

    IEnumerator SendToServer(byte[] wavBytes)
    {
        WWWForm form = new WWWForm();
        form.AddBinaryData("file", wavBytes, "voice.wav", "audio/wav");

        using (UnityWebRequest www = UnityWebRequest.Post(serverURL, form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
                Debug.Log("✅ 서버 전송 성공!");
            else
                Debug.LogError("❌ 서버 전송 실패: " + www.error);
        }
    }
}

