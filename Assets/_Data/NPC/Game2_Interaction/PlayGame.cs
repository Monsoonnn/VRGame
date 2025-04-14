using GrabQuiz.Animals;
using UnityEngine;

public class PlayGame : ButtonAbstact {

    public GameplayCtrl gamePlayCtrl;

    protected override void LoadComponents() {
        base.LoadComponents();
        this.LoadGameplayCtrl();
    }

    protected virtual void LoadGameplayCtrl() { 
        if(this.gamePlayCtrl != null) return;
        this.gamePlayCtrl = GameObject.FindAnyObjectByType<GameplayCtrl>();
        Debug.Log(transform.name + ": LoadGameplayCtrl ", gameObject);
    }


    protected override void OnClick() {
        Debug.Log(transform.name + ": OnClick ", gameObject);
        gamePlayCtrl.StartGameplay();
    }
}
