using System;

namespace Registration_EFC_MVC.Models
{
    internal class DispayNameAttribute : Attribute
    {
        private string v;

        public DispayNameAttribute(string v)
        {
            this.v = v;
        }
    }
}