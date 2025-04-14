using UnityEngine;
using UnityEngine.Playables;

namespace GrabQuiz.Animals {
    public class TutorialCtrl : NewMonobehavior {
        public PlayableDirector playableDirector;

        protected override void LoadComponents() {
            base.LoadComponents();
            this.LoadPlayableDirector();
        }

        protected virtual void LoadPlayableDirector() { 
            if(this.playableDirector != null) return;
            this.playableDirector = this.GetComponent<PlayableDirector>();
            Debug.Log(transform.name + " LoadPlayableDirector: " + this.playableDirector);
        }

        public void StartTutorial() { 
            this.playableDirector.Play(); 
        }



    }
}
