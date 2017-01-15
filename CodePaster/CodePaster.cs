using System;
using System.Text;
using System.Windows.Forms;
using OpenLiveWriter.Api;

namespace CodePaster {

  [WriterPlugin("1E253E02-1D86-4FF7-A1CF-04B1616CE7D5", "Paste Code")]
  [InsertableContentSource("Paste Code From Code Editor")]
  public class CodePaster : ContentSource {

    public static string ConvertEntity(char current) {
      switch (current) {
        case '&': return "&amp;";
        case '<': return "&lt;";
        case '>': return "&gt;";
        case '\t': return "  "; // convert tabs to 2 spaces
        default:
          return current.ToString();
      }
    }

    private string ConvertEntities(string s) {
      StringBuilder sb = new StringBuilder();
      foreach(char c in s) {
        sb.Append(ConvertEntity(c));
      }
      return sb.ToString();
    }

    private string GetCode() {
      if (Clipboard.ContainsText(TextDataFormat.Text)) {
        return ConvertEntities(Clipboard.GetText(TextDataFormat.Text));
      }
      return "placeholder text";
    }

    public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content) {
      string language = "";
      using (var mainForm = new MainForm()) {
        if (mainForm.ShowDialog(dialogOwner) == DialogResult.Cancel) {
          return DialogResult.Cancel;
        }

        language = mainForm.GetSelectedCodeType();
      }

      content = String.Format(
        "<div class=\"jmbcodeblock\">{0}<pre><code class=\"language-{1}\">{2}</code></pre>{0}</div>{0}", 
        Environment.NewLine, language, GetCode());

      return DialogResult.OK;
    }
  }
}