namespace ArtGallery.WinForm
{
    public sealed partial class SculptureForm : WorkForm
    {   
        //Singleton
        private static readonly SculptureForm _instance = new SculptureForm();

        static SculptureForm()
        {
        }

        private SculptureForm()
        {
            InitializeComponent();
        }

        public static void Run(Sculpture sculpture)
        {
            _instance.SetDetails(sculpture);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Sculpture work = (Sculpture)_work;
            weight.Text = work.Weight.ToString();
            material.Text = work.Material;
        }

        protected override void PushData()
        {
            base.PushData();
            Sculpture work = (Sculpture)_work;
            work.Weight = float.Parse(weight.Text);
            work.Material = material.Text;
        }
    }
}

