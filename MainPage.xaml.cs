using Dave.Objects;
using Dave.Objects.Agents;
using Dave.Objects.Factories;

namespace Dave
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string root = entry.Text;
                FileAgent<string> agent = AgentFactory<string>.GetFilebasedAgent(Strategies.Subject.FileSystem, root, new DateTime(2025, 2, 13, 11, 7, 0));

                agent.strategie.Bin.Add(root);
                agent.Crawl();

                feurfeur.Text = agent.fileFromRoot?.ToArray().Length.ToString() ?? "aucun element";
            }
            catch (Exception ex) 
            {
                Logger.Log(App.logDefault, ex.Message);
            }
        }
    }

}
