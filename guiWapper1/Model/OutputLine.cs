using Prism.Mvvm;
using System.Windows.Controls;

namespace guiWapper1.Model
{
    public enum colors { RED, GREEN, YELLOW, WHITE, BLACK }
    public class OutputLine:BindableBase
    {
        public colors Color { get; set; }
        public string LineText { get; set; }

    }
}