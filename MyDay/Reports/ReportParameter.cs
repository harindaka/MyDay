using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MyDay.Reports
{
    public class ReportParameter<T>
    {
        public ReportParameter()
        {
            
        }

        public string Name { get; set; }
                        
        public bool IsRequired { get; set; }

        public T Value { get; private set; }

        public T DefaultValue { get; set; }

        public Action<T> Validator { get; set; }

        internal bool Validate(string value, out string validationMessage)
        {
            if (this.IsRequired && String.IsNullOrEmpty(value))
            {
                this.Value = default(T);
                validationMessage = String.Empty;
                return false;
            }
            else if (!this.IsRequired && String.IsNullOrEmpty(value))
            {
                this.Value = this.DefaultValue;
                validationMessage = String.Empty;
                return false;
            }
            else
            {
                try
                {
                    TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                    T convertedVal = (T)conv.ConvertFrom(value);
                    this.Validator(convertedVal);
                    this.Value = convertedVal;

                    validationMessage = String.Empty;
                    return true;
                }
                catch (Exception ex)
                {
                    this.Value = default(T);
                    validationMessage = ex.Message;
                    return false;
                }
            }
        }
    }
}
