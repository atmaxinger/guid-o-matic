using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID_O_MATIC
{
    public enum Format
    {
        Naked,
        Quotes,
        CurlyBrackets,
        Csharp
    }

    public class GuidOptions : INotifyPropertyChanged
    {
        private Guid _currentGuid;
        public Guid CurrentGuid
        {
            get => _currentGuid;
            set
            {
                _currentGuid = value;
                NotifyAllPropertiesChanged();
            }
        }

        private Format _format;
        public Format Format
        {
            get => _format;
            set
            {
                _format = value;
                NotifyAllPropertiesChanged();
            }
        }

        private bool _upperCase;
        public bool UpperCase
        {
            get => _upperCase;
            set
            {
                _upperCase = value;
                NotifyAllPropertiesChanged();
            }
        }

        private string GetCorrectCaseGuid()
        {
            var str = CurrentGuid.ToString();
            if(UpperCase)
            {
                return str.ToUpper();
            }

            return str;
        }

        public String Naked => GetCorrectCaseGuid();
        public string Quotes => $"\"{GetCorrectCaseGuid()}\"";
        public String CurlyBrackets => $"{{{GetCorrectCaseGuid()}}}";
        public String Csharp => $"new Guid(\"{GetCorrectCaseGuid()}\")";
       
        public bool IsNakedSelected
        {
            get => Format == Format.Naked;
            set
            {
                Format = Format.Naked;
                NotifyAllPropertiesChanged();
            }
        }

        public bool IsQuotesSelected
        {
            get => Format == Format.Quotes;
            set
            {
                Format = Format.Quotes;
                NotifyAllPropertiesChanged();
            }
        }

        public bool IsCurlyBracketsSelected
        {
            get => Format == Format.CurlyBrackets;
            set
            {
                Format = Format.CurlyBrackets;
                NotifyAllPropertiesChanged();
            }
        }

        public bool IsCsharpSelected
        {
            get => Format == Format.Csharp;
            set
            {
                Format = Format.Csharp;
                NotifyAllPropertiesChanged();
            }
        }



        public string FormattedValue
        {
            get
            {
                switch(Format)
                {
                    case Format.Naked:
                        return Naked;
                    case Format.Quotes:
                        return Quotes;
                    case Format.CurlyBrackets:
                        return CurlyBrackets;
                    case Format.Csharp:
                        return Csharp;
                }

                return "";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyAllPropertiesChanged()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop.Name));
            }
        }
    }
}
