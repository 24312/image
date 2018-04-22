using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour {

    public void OnClick() {
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            
    }
}
