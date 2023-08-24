using Cinemachine;
using Movement;
using UnityEngine;

public class CameraShakeCineMachine : MonoBehaviour
{
    public VelocityController velocityController;
    public CinemachineVirtualCamera target;
    [SerializeField]bool isCritical;
    [SerializeField] private float amplitude;
    [SerializeField] private float frequencia;


    private void OnEnable()
    {
        velocityController.criticalVelocityReachedEvent.AddListener(Shake);
    }

    private void Shake(bool isCritical)
    {
        this.isCritical = isCritical;
        if (isCritical)
        {
            target.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
            target.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequencia;
        }
        else
        {
            target.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
            target.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
        }
        
    }

    private void OnDisable()
    {
        velocityController.criticalVelocityReachedEvent.RemoveListener(Shake);
    }
}