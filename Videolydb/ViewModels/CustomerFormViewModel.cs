using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videolydb.Migrations;
using Videolydb.Models;

namespace Videolydb.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}