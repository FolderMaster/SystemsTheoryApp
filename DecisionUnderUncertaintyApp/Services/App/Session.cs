using DecisionUnderUncertaintyApp.Models;

namespace DecisionUnderUncertaintyApp.Services.App
{
    public class Session
    { 
        public OptionsEnvironmentsTable OptionsEnvironmentsTable { get; set; } = new
            OptionsEnvironmentsTable();

        public Session()
        {
        }

        public Session(OptionsEnvironmentsTable optionsEnvironmentsTable)
        {
            OptionsEnvironmentsTable = optionsEnvironmentsTable;
        }
    }
}