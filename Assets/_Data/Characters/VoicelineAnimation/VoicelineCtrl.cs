using com.cyborgAssets.inspectorButtonPro;
using System.Threading.Tasks;
using UnityEngine;



public enum VoiceType { 
    tutorial,
    idle,
    rightawnser,
    wrongawnser,   
    sugggetion,
    afk,
    loseDirection,
    tutorialAnswer,
}


public class VoicelineCtrl : SingletonCtrl<VoicelineCtrl>
{
    public VoicelineAnimation[] voicelines;
    public Animator animator;
    public AudioSource audioSource;

    [ProButton]
    public async Task PlayAnimation(VoiceType voiceType) {

        /*Debug.Log(voiceType.ToString());*/

        VoicelineAnimation playingVoiceline = GetVoiceline(voiceType);

        if (playingVoiceline != null)
        {
            await playingVoiceline.StartDialogue(audioSource, animator);
        }

    }

    protected virtual VoicelineAnimation GetVoiceline(VoiceType voiceType) {

        VoicelineAnimation item = null;


        foreach (VoicelineAnimation voiceline in voicelines) { 
            if(voiceline.voiceType == voiceType) item = voiceline ;
        }

        return item;
    }


}
