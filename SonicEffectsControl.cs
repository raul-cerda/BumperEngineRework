using UnityEngine;
using System.Collections;

public class SonicEffectsControl : MonoBehaviour {

    public PlayerBhysics Player;
    public ParticleSystem RunningDust;
	public ParticleSystem SpeedLines;
    public ParticleSystem SpinDashDust;
    public float RunningDustThreshold;
	public float SpeedLinesThreshold;
	
	TrailRenderer SpeedTrail;
	
	void Start()
	{
		SpeedTrail = GetComponentInChildren<TrailRenderer>();
	}

	void FixedUpdate () {
		ActivateTrail();
		if(Player.rigidbody.velocity.sqrMagnitude > RunningDustThreshold && Player.Grounded && RunningDust != null)
        {
            RunningDust.Emit(Random.Range(0,20));
        }

		if (Player.rigidbody.velocity.sqrMagnitude > SpeedLinesThreshold && Player.Grounded && SpeedLines != null && SpeedLines.isPlaying == false) 
		{
			//SpeedLines.Play ();
		} 
		else if (Player.rigidbody.velocity.sqrMagnitude < SpeedLinesThreshold && SpeedLines.isPlaying == true || (!Player.Grounded)) 
		{
			//SpeedLines.Stop ();
		}

	}
    public void DoSpindashDust(int amm, float speed)
    {
        SpinDashDust.startSpeed = speed;
        SpinDashDust.Emit(amm);
    }
	void ActivateTrail()
	{
		if ( Player.SpeedMagnitude > 150)
			SpeedTrail.enabled = true;
		else
			SpeedTrail.enabled = false;
	}
}