using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioPeer : MonoBehaviour {
    AudioSource _audioSource;
    public static float[] _samples = new float[512];
	
	void Start () {
        _audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
        GetspectrumAudioSource();
	}

    void GetspectrumAudioSource() {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
}
