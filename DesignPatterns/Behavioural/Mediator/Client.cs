namespace DesignPatterns.Behavioural.Mediator
{
    class Client
    {
        public void FacilitateBeeveeConversation()
        {
            var beevee = new Beevee();

            var jarek = new JarekReen(beevee);
            var minister = new Minister(beevee);

            beevee.Jarek = jarek;
            beevee.Minister = minister;

            jarek.Send("We got the beacon and we are calling from Serenein!");
        }
    }
}
