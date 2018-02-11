using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleNumberDisplay : MonoBehaviour
{
    public Text nucleonNumberLabel, electronNumberLabel;
    private void Update()
    {
        nucleonNumberLabel.text = Spawner.NucleonNumber.ToString();
        electronNumberLabel.text = Spawner.ElectronNumber.ToString();
    }
}
