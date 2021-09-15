using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour
{
    private const string horiz = "Horizontal";
    private const string ver = "Vertical";

    private float boostTimer;
    private bool isBoosting;
    private float stopTimer;
    private bool isStoping;
    public float mass = -0.9f;

    private float horizInput;
    private float verInput;
    private float curSteerAngle;
    private float curBreakForce;

    private bool isBreaking;
    //
    public Vector3 checkPoint;



    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform frontRightWheeTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;
    // removed private
     void Start()
    {
        boostTimer = 0;
        isBoosting = false;

        stopTimer = 0;
        isStoping = false;

        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, mass, 0f);
    }

    //
    void Awake()
    {
       

        checkPoint = transform.position;
        
    }
    // removed private
    void FixedUpdate()
    {
        getInput();
        handleMotor();
        handleSteering();
        updateWheels();

        if (isBoosting)
        {
            boostTimer += Time.deltaTime;
            if (boostTimer >= 3)
            {
                motorForce = 1000;
                boostTimer = 0;
                isBoosting = false;
            }
        }
        if (isStoping)
        {
            stopTimer += Time.deltaTime;
            if (stopTimer >= 3)
            {
                motorForce = 1000;
                stopTimer = 0;
                isStoping = false;
                GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
    //
    public void LoadCheckPoint()
    {
        transform.position = checkPoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpeedBoost")
        {
            isBoosting = true;
            motorForce = 3000;
            Destroy(other.gameObject);
        }
        if (other.tag == "Freeze")
        {
            isStoping = true;
            GetComponent<Rigidbody>().isKinematic = true;
            Destroy(other.gameObject);
        }
    }

  

    private void getInput()
    {
        horizInput = Input.GetAxis(horiz);
        verInput = Input.GetAxis(ver);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void handleMotor()
    {
        frontLeftWheelCollider.motorTorque = verInput * motorForce;

        frontRightWheelCollider.motorTorque = verInput * motorForce;

        curBreakForce = isBreaking ? breakForce : 0f;

        applyBreaking();
    }

    private void applyBreaking()
    {
        frontRightWheelCollider.brakeTorque = curBreakForce;

        frontLeftWheelCollider.brakeTorque = curBreakForce;

        rearLeftWheelCollider.brakeTorque = curBreakForce;

        rearRightWheelCollider.brakeTorque = curBreakForce;
    }

    private void handleSteering()
    {
        curSteerAngle = maxSteerAngle * horizInput;

        frontLeftWheelCollider.steerAngle = curSteerAngle;

        frontRightWheelCollider.steerAngle = curSteerAngle;
    }

    private void updateWheels()
    {
        updateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);

        updateSingleWheel(frontRightWheelCollider, frontRightWheeTransform);

        updateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);

        updateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void updateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot
;
        wheelCollider.GetWorldPose(out pos, out rot);

        wheelTransform.rotation = rot;

        wheelTransform.position = pos;
    }
}
