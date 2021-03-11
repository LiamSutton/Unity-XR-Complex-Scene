using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
public class MovementOptionsManager : MonoBehaviour
{    
    Toggle m_MovementSelectionToggle;
    Toggle m_RotationSelectionToggle;
    TeleportationProvider m_TeleportationProvider;
    DeviceBasedSnapTurnProvider m_SnapTurnProvider;
    DeviceBasedContinuousTurnProvider m_ContinuousTurnProvider;
    DeviceBasedContinuousMoveProvider m_ContinuousMoveProvider;
    CharacterController m_CharacterController;
    void Awake() {

        m_TeleportationProvider = GetComponent<TeleportationProvider>();
        m_SnapTurnProvider = GetComponent<DeviceBasedSnapTurnProvider>();
        m_ContinuousTurnProvider = GetComponent<DeviceBasedContinuousTurnProvider>();
        m_ContinuousMoveProvider = GetComponent<DeviceBasedContinuousMoveProvider>();
        m_CharacterController = GetComponent<CharacterController>();
    }

    public void MovementSelectionChanged(bool isOn) {
        if (isOn) {
            UseTeleportation();
        } else {
            UseContinuousMove();
        }
    }

    public void RotationSelectionChanged(bool isOn) {
        if (isOn) {
            UseSnapTurn();
        } else {
            UseContinuousTurn();
        }
    }
    void UseTeleportation() {
        m_TeleportationProvider.enabled = true;
        m_CharacterController.enabled = false;
        m_ContinuousMoveProvider.enabled = false;
    }

    void UseContinuousMove() {
        m_ContinuousMoveProvider.enabled = true;
         m_CharacterController.enabled = true;
        m_TeleportationProvider.enabled = false;
    }

    void UseSnapTurn() {
        m_SnapTurnProvider.enabled = true;
        m_ContinuousTurnProvider.enabled = false;
    }

    void UseContinuousTurn() {
        m_ContinuousTurnProvider.enabled = true;
        m_SnapTurnProvider.enabled = false;
    }
}
