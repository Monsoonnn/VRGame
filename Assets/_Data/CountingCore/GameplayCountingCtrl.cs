using com.cyborgAssets.inspectorButtonPro;
using System.Collections;
using UnityEngine;

namespace CountingCore {
    public class GameplayCountingCtrl : NewMonobehavior {

        public GameObject corePrefab;
        public GameObject activeCorePrefab;

        protected override void LoadComponents() {
            base.LoadComponents();
            this.LoadCorePrefab();
        }


        protected virtual void LoadCorePrefab() {
            if (corePrefab != null) return;
            this.corePrefab = this.transform.Find("CorePrefab").gameObject;
            Debug.Log(transform.name + ": LoadCorePrefab: ", gameObject);
        }

        [ProButton]
        public virtual void StartGame() {
            if (activeCorePrefab != null) Destroy(activeCorePrefab);
            StartCoroutine(DelayedInstantiate());
        }

        [ProButton]
        public virtual void Restart() {
            if (activeCorePrefab == null) return;

            Destroy(activeCorePrefab);
            StartGame();
        }

        private IEnumerator DelayedInstantiate() {
            yield return new WaitForSeconds(1f); // 1 second delay

            GameObject newCore = Instantiate(corePrefab, this.transform);
            newCore.SetActive(true);
            activeCorePrefab = newCore;
        }

    }
}
