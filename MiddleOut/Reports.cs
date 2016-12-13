using System.Collections.Generic;
using System.Text;

namespace MiddleOut
{
    /// <summary>
    /// Author: Ameet Toor
    /// The Reports class creates a report for the given user.
    /// </summary>
    public class Reports
    {
        #region fields
        /// <summary>
        /// Author: Ameet Toor
        /// The list of services that the user has associated with their account.
        /// </summary>
        private List<Service> _listOfServices;

        /// <summary>
        /// Author: Ameet Toor
        /// The string that holds the report for the user.
        /// </summary>
        private string _report;
        #endregion

        #region methods

        #region public methods

        /// <summary>
        /// Author: Ameet Toor
        /// The constructor that initializes the fields.
        /// </summary>
        /// <param name="theListOfCompletedServices">The list of services that the user has associated with their account.</param>
        public Reports(List<Service> theListOfCompletedServices)
        {
            SetListCompletedServices(theListOfCompletedServices);
            CreateReport();
        }

        #region Getters
        /// <summary>
        /// Author: Ameet Toor
        /// Returns the report of the user.
        /// </summary>
        /// <returns>Report of the user as a string.</returns>
        public string GetReport()
        {
            return _report;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Returns the report of the user as a string.
        /// </summary>
        /// <returns>The report of the user as a string.</returns>
        override 
        public string ToString()
        {
            return _report;
        }

        #endregion
        #endregion

        #region private methods
        #region Setters
        /// <summary>
        /// Author: Ameet Toor
        /// Sets the list of completed services for this report.
        /// </summary>
        /// <param name="theListOfCompletedServices">The list of the services associated with the user account.</param>
        private void SetListCompletedServices(List<Service> theListOfCompletedServices)
        {
            if (theListOfCompletedServices != null)
            {
                _listOfServices = theListOfCompletedServices;
            }
        }
        #endregion

        /// <summary>
        /// Author: Ameet Toor
        /// Creates the report for the user using each service in the list of services.
        /// </summary>
        private void CreateReport()
        {
            if (_listOfServices != null)
            {
                var sb = new StringBuilder();
                var totalTaxCredit = 0.0;
                var serviceNum = 1;
                sb.Append("Report: \n\n");
                foreach (var service in _listOfServices)
                {
                    sb.Append("Service " + serviceNum + ":\n");
                    totalTaxCredit = totalTaxCredit + service.getTaxCredit();
                    sb.Append(service + "\n\n");
                    serviceNum++;
                }
                sb.Append("Number of Services: " + _listOfServices.Count + "\n");
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
