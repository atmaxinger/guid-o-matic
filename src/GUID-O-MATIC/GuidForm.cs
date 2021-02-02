using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUID_O_MATIC
{
    public partial class GuidForm : Form
    {
        private GuidOptions Options; 

        public GuidForm(GuidOptions options)
        {
            Options = options;
            Setup();
        }

        public GuidForm()
        {
            Options = new GuidOptions();
            Setup();
        }

        private void Setup()
        {
            InitializeComponent();

            SetUpRadioButtonDataBinding(rbNakedGuid, nameof(GuidOptions.Naked), nameof(GuidOptions.IsNakedSelected));
            SetUpRadioButtonDataBinding(rbQuotes, nameof(GuidOptions.Quotes), nameof(GuidOptions.IsQuotesSelected));
            SetUpRadioButtonDataBinding(rbCurlyBrackets, nameof(GuidOptions.CurlyBrackets), nameof(GuidOptions.IsCurlyBracketsSelected));
            SetUpRadioButtonDataBinding(rbCsharpGuid, nameof(GuidOptions.Csharp), nameof(GuidOptions.IsCsharpSelected));

            cbUppercaseGuid.DataBindings.Add(nameof(CheckBox.Checked), Options, nameof(GuidOptions.UpperCase));
            cbUppercaseGuid.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        private void SetUpRadioButtonDataBinding(RadioButton radioButton, string textProperty, string checkedProperty)
        {
            radioButton.DataBindings.Add(nameof(RadioButton.Text), Options, textProperty);
            radioButton.DataBindings.Add(nameof(RadioButton.Checked), Options, checkedProperty);
            radioButton.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        private void GuidForm_Load(object sender, EventArgs e)
        {
            Options.CurrentGuid = Guid.NewGuid();
        }

        private void btnNewGuid_Click(object sender, EventArgs e)
        {
            Options.CurrentGuid = Guid.NewGuid();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(Options.FormattedValue);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
