using System.Collections.Generic;

namespace Inflector.Tests
{
    public abstract class InflectorTestBase
    {
        public readonly Dictionary<string, string> TestData = new Dictionary<string, string>();

        public readonly Dictionary<string, string> SingularToPlural = new Dictionary<string, string>();
        public readonly Dictionary<string, string> PascalToUnderscore = new Dictionary<string, string>();
        public readonly Dictionary<string, string> UnderscoreToCamel = new Dictionary<string, string>();

        public readonly Dictionary<string, string> PascalToUnderscoreWithoutReverse =
            new Dictionary<string, string>();

        public readonly Dictionary<string, string> CamelWithModuleToUnderscoreWithSlash =
            new Dictionary<string, string>();

        public readonly Dictionary<string, string> UnderscoreToHuman = new Dictionary<string, string>();
        public readonly Dictionary<string, string> MixtureToTitleCase = new Dictionary<string, string>();
        public readonly Dictionary<string, string> OrdinalNumbers = new Dictionary<string, string>();
        public readonly Dictionary<string, string> UnderscoresToDashes = new Dictionary<string, string>();
        public readonly Dictionary<string, string> ClassNameToTableName = new Dictionary<string, string>();
        public readonly Dictionary<string, string> ClassNameToForeignKeyName = new Dictionary<string, string>();

        protected InflectorTestBase()
        {
            PascalToUnderscore.Add("Product", "product");
            PascalToUnderscore.Add("SpecialGuest", "special_guest");
            PascalToUnderscore.Add("ApplicationController", "application_controller");
            PascalToUnderscore.Add("Area51Controller", "area51_controller");

            UnderscoreToCamel.Add("product", "product");
            UnderscoreToCamel.Add("special_guest", "specialGuest");
            UnderscoreToCamel.Add("application_controller", "applicationController");
            UnderscoreToCamel.Add("area51_controller", "area51Controller");

            PascalToUnderscoreWithoutReverse.Add("HTMLTidy", "html_tidy");
            PascalToUnderscoreWithoutReverse.Add("HTMLTidyGenerator", "html_tidy_generator");
            PascalToUnderscoreWithoutReverse.Add("FreeBSD", "free_bsd");
            PascalToUnderscoreWithoutReverse.Add("HTML", "html");

            UnderscoreToHuman.Add("employee_salary", "Employee salary");
            UnderscoreToHuman.Add("employee_id", "Employee id");
            UnderscoreToHuman.Add("underground", "Underground");

            MixtureToTitleCase.Add("active_record", "Active Record");
            MixtureToTitleCase.Add("ActiveRecord", "Active Record");
            MixtureToTitleCase.Add("action web service", "Action Web Service");
            MixtureToTitleCase.Add("Action Web Service", "Action Web Service");
            MixtureToTitleCase.Add("Action web service", "Action Web Service");
            MixtureToTitleCase.Add("actionwebservice", "Actionwebservice");
            MixtureToTitleCase.Add("Actionwebservice", "Actionwebservice");

            OrdinalNumbers.Add("0", "0th");
            OrdinalNumbers.Add("1", "1st");
            OrdinalNumbers.Add("2", "2nd");
            OrdinalNumbers.Add("3", "3rd");
            OrdinalNumbers.Add("4", "4th");
            OrdinalNumbers.Add("5", "5th");
            OrdinalNumbers.Add("6", "6th");
            OrdinalNumbers.Add("7", "7th");
            OrdinalNumbers.Add("8", "8th");
            OrdinalNumbers.Add("9", "9th");
            OrdinalNumbers.Add("10", "10th");
            OrdinalNumbers.Add("11", "11th");
            OrdinalNumbers.Add("12", "12th");
            OrdinalNumbers.Add("13", "13th");
            OrdinalNumbers.Add("14", "14th");
            OrdinalNumbers.Add("20", "20th");
            OrdinalNumbers.Add("21", "21st");
            OrdinalNumbers.Add("22", "22nd");
            OrdinalNumbers.Add("23", "23rd");
            OrdinalNumbers.Add("24", "24th");
            OrdinalNumbers.Add("100", "100th");
            OrdinalNumbers.Add("101", "101st");
            OrdinalNumbers.Add("102", "102nd");
            OrdinalNumbers.Add("103", "103rd");
            OrdinalNumbers.Add("104", "104th");
            OrdinalNumbers.Add("110", "110th");
            OrdinalNumbers.Add("1000", "1000th");
            OrdinalNumbers.Add("1001", "1001st");

            UnderscoresToDashes.Add("street", "street");
            UnderscoresToDashes.Add("street_address", "street-address");
            UnderscoresToDashes.Add("person_street_address", "person-street-address");

            ClassNameToTableName.Add("CostomerOrders", "CostomerOrder");
            ClassNameToTableName.Add("Costomer_Orders", "Costomer_Order");

            ClassNameToForeignKeyName.Add("ProductId", "Product");
            ClassNameToForeignKeyName.Add("SpecialGuestId", "SpecialGuest");
            ClassNameToForeignKeyName.Add("ApplicationControllerId", "ApplicationController");
 
        }
    }
}