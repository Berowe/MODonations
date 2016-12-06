using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleOut
{
    /// <summary>
    /// The Reports class creates a report for the given user.
    /// </summary>
    internal class Reports
    {
        #region fields
        private List<Service> _listOfCompletedServices;
        private string _report;
        #endregion

        #region methods

        #region public methods

        public Reports(List<Service> theListOfCompletedServices)
        {
            SetListCompletedServices(theListOfCompletedServices);
            CreateReport();
        }

        #region Getters
        public string GetReport()
        {
            return _report;
        }
        #endregion
        #endregion

        #region private methods
        #region Setters
        private void SetListCompletedServices(List<Service> theListOfCompletedServices)
        {
            if (theListOfCompletedServices != null)
            {
                _listOfCompletedServices = theListOfCompletedServices;
            }
        }
        #endregion

        private void CreateReport()
        {
            if (_listOfCompletedServices != null)
            {
                var sb = new StringBuilder();
                var totalTaxCredit = 0.0;

                foreach (var service in _listOfCompletedServices)
                {
                    totalTaxCredit = totalTaxCredit + service.getTaxCredit();
                    sb.Append(service.ToString() + "\n\n");
                }
                sb.Append("Total Tax Credit: $" + totalTaxCredit);
                _report = sb.ToString();
            }
            else
            {
                _report = string.Empty;
            }
        }

        #endregion

        #endregion
    }
}
