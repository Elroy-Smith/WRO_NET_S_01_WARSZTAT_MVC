using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Helpers;

namespace PhoneBook.Models
{
	public class SourceManager
	{
		public int Add(PersonModel personModel)
		{
			using (var connection = SqlHelper.GetConnection())
			{
				var sqlCommand = new SqlCommand();
				sqlCommand.Connection = connection;
				sqlCommand.CommandText = @"Insert INTO People (FirstName, LastName, Phone, Email, Created, Updated)
				VALUES (@FirstName,@LastName,@Phone, @Email, @Created, @Updated);";

				//var sqlFirstNameParam = new SqlParameter
				//{
				//	DbType = System.Data.DbType.AnsiString,
				//	Value = rentier.FirstName,
				//	ParameterName = "@FirstName"
				//};
			}



			return 0;
		}

	}

	
}

