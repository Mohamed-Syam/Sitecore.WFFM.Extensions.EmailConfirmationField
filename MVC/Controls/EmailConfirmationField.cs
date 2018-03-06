using Sitecore.Forms.Mvc.Validators;
using Sitecore.Forms.Mvc.ViewModels.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFWebPortal.Foundation.MVCEmailConfirmation.MVC.Controls
{
    public class EmailConfirmationField : EmailField
    {
        [DataType(DataType.EmailAddress)]
        [DynamicCompare("Value", "EmailTitle", "ConfirmationTitle", ErrorMessage = "The {0} and {1} fields must be the same.")]
        public string Confirmation { get; set; }

        public string ConfirmationHelp { get; set; }

        public string EmailHelp { get; set; }

        public string EmailTitle { get; set; }

        public string ConfirmationTitle { get; set; }

        public EmailConfirmationField()
        {
            this.EmailTitle = "Email";
            this.ConfirmationTitle = "Confirmation";
        }
    }
}
