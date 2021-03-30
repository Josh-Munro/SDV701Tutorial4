namespace ArtGallery.WinForm
{
    public sealed partial class PaintingForm : WorkForm
    {  
        //Singleton
        private static readonly PaintingForm _instance = new PaintingForm();

        static PaintingForm()
        {
        }

        private PaintingForm()
        {
            InitializeComponent();
        }

        public static void Run(Painting painting)
        {
            _instance.SetDetails(painting);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Painting work = (Painting)_work;
            width.Text = work.Width.ToString();
            height.Text = work.Height.ToString();
            type.Text = work.Type;
        }

        protected override void PushData()
        {
            base.PushData();
            Painting work = (Painting)_work;
            work.Width = float.Parse(width.Text);
            work.Height = float.Parse(height.Text);
            work.Type = type.Text;
        }
    }
}