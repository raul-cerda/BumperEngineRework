using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SonicSoundsControl : MonoBehaviour {

    public PlayerBhysics Player;

    AudioSource Source;
    public AudioSource Source2;
    public AudioSource Source3;
	public AudioSource Source4;
	public AudioSource Source5;
    public AudioClip[] FootSteps;
    public AudioClip Jumping;
    public AudioClip AirDash;
    public AudioClip HomingAttack;
    public AudioClip Skidding;
    public AudioClip Spin;
    public AudioClip SpinDash;
    public AudioClip SpinDashRelease;
	public AudioClip BounceStart;
	public AudioClip BounceImpact;
	public AudioClip StompImpact;
    public AudioClip RingLoss;
    public AudioClip Die;
    public AudioClip Spiked;

	public AudioClip[] CombatVoiceClips;
	public AudioClip[] JumpingVoiceClips;
	public AudioClip[] PainVoiceClips;

    public float pitchBendingRate = 1;

    public void Test(string i)
    {

    }

    void Start()
    {
        Source = GetComponent<AudioSource>();
    }
	
	public void WindPlay()
	{
		Source5.clip = FootSteps[4];
		float vol = Player.SpeedMagnitude;
		vol /= 100f;
		vol = Mathf.Clamp(vol, 0f, 1f);
		if (vol <= 0.25f)
			vol = 0;
		else if (vol <= 0.75f)
			vol /= 3;
		else
			vol /= 2;
		Source5.volume = vol;
		if (Player.SpeedMagnitude <= 120)
			Source5.pitch = 1;
		else
		{
			float x = (1f/50 * (Player.SpeedMagnitude-120f) + 1);
			Source5.pitch = Mathf.Clamp(x, 1f, 2.5f);
		}
		if (!Source5.isPlaying)
		{
			Source5.Play();
		}
	}

	public void CombatVoicePlay()
	{
		int rand = Random.Range(0, CombatVoiceClips.Length);
		Source4.clip = CombatVoiceClips[rand];
		Source4.Play();
	}
	public void JumpingVoicePlay()
	{
		int rand = Random.Range(0, JumpingVoiceClips.Length);
		Source4.clip = JumpingVoiceClips[rand];
		Source4.Play();
	}
	public void PainVoicePlay()
	{
		int rand = Random.Range(0, PainVoiceClips.Length);
		Source4.clip = PainVoiceClips[rand];
		Source4.Play();
	}
    public void FootStepSoundPlay()
    {
		if (FootSteps.Length > 0) {
			int rand = Random.Range (0, FootSteps.Length-1);
			Source.clip = FootSteps [rand];
			Source.Play ();
		}
    }
    public void JumpSound()
    {
		if (JumpingVoiceClips.Length > 0) {
			JumpingVoicePlay ();
		}
        Source2.clip = Jumping;
        Source2.Play();
    }
    public void SkiddingSound()
    {
        Source2.clip = Skidding;
        Source2.Play();
    }
    public void HomingAttackSound()
    {
        Source2.clip = HomingAttack;
        Source2.Play();
		if (CombatVoiceClips.Length > 0) {
			CombatVoicePlay ();
		}
    }
    public void AirDashSound()
    {
        Source2.clip = AirDash;
        Source2.Play();
    }
    public void SpinningSound()
    {
        Source2.clip = Spin;
        Source2.Play();
    }
    public void SpinDashSound()
    {
        Source2.clip = SpinDash;
        Source2.Play();
    }
	public void BounceStartSound()
	{
		Source2.clip = BounceStart;
		Source2.Play();
	}
	public void BounceImpactSound()
	{
		Source2.clip = BounceImpact;
		Source2.Play();
	}
	public void StompImpactSound()
	{
		Source2.clip = StompImpact;
		Source2.Play();
	}
    public void SpinDashReleaseSound()
    {
        Source2.clip = SpinDashRelease;
        Source2.Play();
    }
    public void RingLossSound()
    {
        Source3.clip = RingLoss;
		if (PainVoiceClips.Length > 0) {
			PainVoicePlay ();
		}
        Source3.Play();
    }
    public void DieSound()
    {
        Source3.clip = Die;
		if (PainVoiceClips.Length > 0) {
			PainVoicePlay ();
		}
        Source3.Play();
    }
    public void SpikedSound()
    {
        Source3.clip = Spiked;
        Source3.Play();
    }

}
