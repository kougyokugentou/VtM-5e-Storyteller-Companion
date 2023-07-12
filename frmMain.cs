using VtM_5e_Storyteller_Companion.Models.Data;

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
            SeedDB seedDb = new SeedDB();

            seedDb.ValidateDB();
        }
    }
}