using System.Windows.Forms;

namespace Rater
{
    class NumericalTextbox : TextBox
    {


        public NumericalTextbox()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // NumericalTextbox
            // 
            KeyPress += new KeyPressEventHandler( Me_KeyPress );
            ResumeLayout( false );

        }


        //On Key Press
        private void Me_KeyPress( object sender , KeyPressEventArgs e )
        {

            //If the input character is not a control or a digit it is ignored
            if ( !char.IsControl( e.KeyChar ) && !char.IsDigit( e.KeyChar ) )
                e.Handled = true;

        }


    }
}
