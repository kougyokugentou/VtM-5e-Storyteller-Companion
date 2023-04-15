using VtM_5e_Storyteller_Companion.Models;

namespace VtM_5e_Storyteller_Companion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FirstTimeLoad();
        }

        private void FirstTimeLoad()
        {
            using (var db = new VtMDbContext())
            {
                db.Database.EnsureCreated();

                try
                {
                    var query = from clan in db.Clans select clan;
                    Console.WriteLine("All clans in the database:");

                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Name);
                    }

                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
                catch //no clans means not first run
                {
                    var clan = new Clan
                    {
                        Name = "Brujah",
                        Description = "Rabble-rousers",
                        Bane = "Rage"
                    };

                    db.Clans.Add(clan);
                    db.SaveChanges();

                }
            } //end using
        }
    }
}