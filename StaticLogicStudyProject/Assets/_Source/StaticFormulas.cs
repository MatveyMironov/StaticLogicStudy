using UnityEngine;

public class StaticFormulas : MonoBehaviour
{
    public static float NuclearBindingEnergy(float massDefect)
    {
        return massDefect * ConstantDataHolder.ConstantData.SpeedOfLight * ConstantDataHolder.ConstantData.SpeedOfLight;
    }

    public static float GravitationalForce(float firstBodyMass, float secondBodyMass, float distanceBetweenBodies)
    {
        return ConstantDataHolder.ConstantData.GravitationalConstant * firstBodyMass * secondBodyMass / (distanceBetweenBodies * distanceBetweenBodies);
    }

    public static float GravitationalAccelerationOnTheSurfaceOfPlanet(float planetMass, float planetRadius)
    {
        return ConstantDataHolder.ConstantData.GravitationalConstant * planetMass / (planetRadius * planetRadius);
    }

    public static float ForceImpulse(float force, float time)
    {
        return force * time;
    }

    public static float MechanicalWork(float force, float distance)
    {
        return force * distance;
    }
}
