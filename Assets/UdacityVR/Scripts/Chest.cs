using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

  public bool opened = false;
  public void ChestClicked () {
    opened = true;
  }

}
