namespace CodePaster {
  public class CodeType {
    private string displayString;
    private string language;

    public CodeType(string displayString, string language) {
      this.displayString = displayString;
      this.language = language;
    }

    public override string ToString() {
      return displayString;
    }

    public string Language {
      get { return language; }
    }
  }
}
