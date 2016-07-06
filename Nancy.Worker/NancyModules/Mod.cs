namespace Nancy.Worker.NancyModules
{
    public class Mod : NancyModule
    {
        public Mod()
        {
            Get["/"] = x => "hi there, says Nancy";
        }
    }
}