using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpIntermediateChallenges.InterfaceChalenges
{
    public class WorkflowEngine : ChallengeAppliication
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