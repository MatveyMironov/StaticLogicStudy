using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private FormulaTab formulaTabPrefab;
    [SerializeField] private Transform content;

    private void Start()
    {
        FormulaController nuclearBindingEnergyController = new SingleVarFormulaController(StaticFormulas.NuclearBindingEnergy, "Mass Defect");
        FormulaTab nuclearBindingEnergyTab = Instantiate(formulaTabPrefab, content);
        FormulaTabController nuclearBindingEnergyTabController = new(nuclearBindingEnergyTab);
        nuclearBindingEnergyTabController.Setup(nuclearBindingEnergyController);

        FormulaController gravitationalForceController = new ThreeVarFormulaController(StaticFormulas.GravitationalForce, "First Body Mass", "Second Body Mass", "Distance Between Bodies");
        FormulaTab gravitationalForceTab = Instantiate(formulaTabPrefab, content);
        FormulaTabController gravitationalForceTabController = new(gravitationalForceTab);
        gravitationalForceTabController.Setup(gravitationalForceController);

        FormulaController gravitationalAccelerationOnTheSurfaceOfPlanetController = new TwoVarFormulaController(StaticFormulas.GravitationalAccelerationOnTheSurfaceOfPlanet, "Planet Mass", "Planet Radius");
        FormulaTab gravitationalAccelerationOnTheSurfaceOfPlanetTab = Instantiate(formulaTabPrefab, content);
        FormulaTabController gravitationalAccelerationOnTheSurfaceOfPlanetTabController = new(gravitationalAccelerationOnTheSurfaceOfPlanetTab);
        gravitationalAccelerationOnTheSurfaceOfPlanetTabController.Setup(gravitationalAccelerationOnTheSurfaceOfPlanetController);

        FormulaController forceImpulseController = new TwoVarFormulaController(StaticFormulas.ForceImpulse, "Force", "Time");
        FormulaTab forceImpulseTab = Instantiate(formulaTabPrefab, content);
        FormulaTabController forceImpulseTabController = new(forceImpulseTab);
        forceImpulseTabController.Setup(forceImpulseController);

        FormulaController MechanicalWorkController = new TwoVarFormulaController(StaticFormulas.MechanicalWork, "Force", "Distance");
        FormulaTab MechanicalWorkTab = Instantiate(formulaTabPrefab, content);
        FormulaTabController MechanicalWorkTabController = new(MechanicalWorkTab);
        MechanicalWorkTabController.Setup(MechanicalWorkController);
    }
}
