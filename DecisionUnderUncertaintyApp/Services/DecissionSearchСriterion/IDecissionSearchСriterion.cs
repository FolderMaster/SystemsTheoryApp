using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Services.DecissionSearchСriterion
{
    public interface IDecissionSearchСriterion
    {
        double[] EvaluateDecissions(OptionsEnvironmentsTable table);

        int SearchBestDecission(double[] array);
    }
}