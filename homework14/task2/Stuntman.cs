using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Stuntman : Actor
    {
        LeadingActor LeadingActor;
        public override void Act()
        {
            if(LeadingActor == null)
            {
                LeadingActor = new LeadingActor();
            }
            LeadingActor.Act();
            playInDangerousEpisodes();
        }

        private void playInDangerousEpisodes() 
        {
            Console.WriteLine("I am a stuntman! I play in dangerous episodes of movies replacing leading actors");
        }
    }
}
