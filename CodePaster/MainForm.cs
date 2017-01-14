using System.Windows.Forms;

namespace CodePaster {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      InitializeCodeTypes();
      CodeTypes.SelectedIndex = 0;
    }

    private void InitializeCodeTypes() {
      CodeTypes.Items.AddRange(new object[] {
        new CodeType("JavaScript", "javascript"),
        new CodeType("TypeScript", "typescript"),
        new CodeType("React JSX", "jsx"),
        new CodeType("JSON", "json"),
        new CodeType("HTML", "markup"),
        new CodeType("Markdown", "markdown"),
        new CodeType("CSS", "css"),
        new CodeType("C#", "csharp"),
        new CodeType("ASP.NET", "aspnet"),
        new CodeType("Pascal/Delphi", "pascal")
      });
    }

    public string GetSelectedCodeType() {
      return (CodeTypes.SelectedItem as CodeType).Language;
    }
  }

}
