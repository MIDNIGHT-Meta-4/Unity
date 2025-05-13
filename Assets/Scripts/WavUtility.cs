using System.IO;
using UnityEngine;

//AudioClip → WAV 변환하는 클래스
// WavUtility.cs (간단 버전)
public static class WavUtility
{
    public static byte[] FromAudioClip(AudioClip clip)
    {
        MemoryStream stream = new MemoryStream();
        // 여기에 AudioClip 데이터를 WAV 형식으로 변환하는 로직 삽입
        // (링크된 GitHub에서 전체 코드 복붙 가능)
        return stream.ToArray();
    }
}

