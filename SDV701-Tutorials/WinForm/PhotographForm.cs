
namespace ArtGallery.WinForm
{
    public sealed partial class PhotographForm : WorkForm
    {   
        //Singleton
        private static readonly PhotographForm _instance = new PhotographForm();

        static PhotographForm()
        {
        }

        private PhotographForm()
        {
            InitializeComponent();
        }

        public static void Run(Photograph photograph)
        {
            _instance.SetDetails(photograph);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Photograph work = (Photograph)_work;
            width.Text = work.Width.ToString();
            height.Text = work.Height.ToString();
            type.Text = work.Type;
        }

        protected override void PushData()
        {
            base.PushData();
            Photograph work = (Photograph)_work;
            work.Width = float.Parse(width.Text);
            work.Height = float.Parse(height.Text);    
            work.Type = type.Text;
        }
    }
}

