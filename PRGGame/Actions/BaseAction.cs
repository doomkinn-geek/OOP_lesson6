using PRGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Actions
{
    public abstract class BaseAction
    {
        protected readonly Item _itemInUse;

        public event EventHandler<string> OnActionPerformed;

        protected BaseAction(Item itemInUse)
        {
            _itemInUse = itemInUse;
        }

        protected void ReportResults(string result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}
