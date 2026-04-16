using UnityEngine;

[CreateAssetMenu(fileName = "SpeedUpgrade", menuName = "CarUpgrades/Speed")]
public class SpeedUpgrade : Upgrade, IDriveData
{
    [SerializeField] private uint _acceleration;
    [SerializeField] private uint _maxSpeed;
    [SerializeField] private uint _stopSpeed;

    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _maxAngle;
    [SerializeField] private float _ackermannMultiplier;

    public uint Acceleration => _acceleration;
    public uint MaxSpeed => _maxSpeed;

    public uint StopSpeed => _stopSpeed;

    public float RotationSpeed => _rotationSpeed;
    public float MaxAngle => _maxAngle;
    public float AckermannMultiplier => _ackermannMultiplier;
}