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
            //Ensure the database is created and seeded with data.
            using (var db = new VtMDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}