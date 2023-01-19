
namespace CSharpIntermediateChallenges.InterfaceChalenges
{
    public class WorkflowEngine : ChallengeApplication
    {

        List<Activity> activities = new List<Activity>();

        public WorkflowEngine()
        {
            activities.Add(new SayHello());
            activities.Add(new SpecificActivity());
            activities.Add(new SayGoodbye());
        }


        public void RunApplication()
        {
            foreach (var activity in activities){
                activity.Excecute();
            }
        }
    }
}