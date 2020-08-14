﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;
using hw.Models;

namespace hw.Models
{
    public partial class ContosouniversityContextProcedures
    {
        private readonly ContosouniversityContext _context;

        public ContosouniversityContextProcedures(ContosouniversityContext context)
        {
            _context = context;
        }

        public async Task<Department_InsertResult[]> Department_Insert(string Name,decimal? Budget,DateTime? StartDate,int? InstructorID)
        {
            var parameterName = new SqlParameter
            {
                ParameterName = "Name",
                Precision = 50,
                Size = 100,
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Name,
            };

            var parameterBudget = new SqlParameter
            {
                ParameterName = "Budget",
                Precision = 19,
                Scale = 4,
                Size = 8,
                SqlDbType = System.Data.SqlDbType.Money,
                Value = Budget,
            };

            var parameterStartDate = new SqlParameter
            {
                ParameterName = "StartDate",
                Precision = 23,
                Scale = 3,
                Size = 8,
                SqlDbType = System.Data.SqlDbType.DateTime,
                Value = StartDate,
            };

            var parameterInstructorID = new SqlParameter
            {
                ParameterName = "InstructorID",
                Precision = 10,
                Size = 4,
                SqlDbType = System.Data.SqlDbType.Int,
                Value = InstructorID,
            };

            var result = await _context.SqlQuery<Department_InsertResult>("EXEC [dbo].[Department_Insert] @Name,@Budget,@StartDate,@InstructorID  ",parameterName,parameterBudget,parameterStartDate,parameterInstructorID);

            return result;
        }

        public async Task<Department_UpdateResult[]> Department_Update(int? DepartmentID,string Name,decimal? Budget,DateTime? StartDate,int? InstructorID,byte[] RowVersion_Original)
        {
            var parameterDepartmentID = new SqlParameter
            {
                ParameterName = "DepartmentID",
                Precision = 10,
                Size = 4,
                SqlDbType = System.Data.SqlDbType.Int,
                Value = DepartmentID,
            };

            var parameterName = new SqlParameter
            {
                ParameterName = "Name",
                Precision = 50,
                Size = 100,
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = Name,
            };

            var parameterBudget = new SqlParameter
            {
                ParameterName = "Budget",
                Precision = 19,
                Scale = 4,
                Size = 8,
                SqlDbType = System.Data.SqlDbType.Money,
                Value = Budget,
            };

            var parameterStartDate = new SqlParameter
            {
                ParameterName = "StartDate",
                Precision = 23,
                Scale = 3,
                Size = 8,
                SqlDbType = System.Data.SqlDbType.DateTime,
                Value = StartDate,
            };

            var parameterInstructorID = new SqlParameter
            {
                ParameterName = "InstructorID",
                Precision = 10,
                Size = 4,
                SqlDbType = System.Data.SqlDbType.Int,
                Value = InstructorID,
            };

            var parameterRowVersion_Original = new SqlParameter
            {
                ParameterName = "RowVersion_Original",
                Precision = 8,
                Size = 8,
                SqlDbType = System.Data.SqlDbType.Timestamp,
                Value = RowVersion_Original,
            };

            var result = await _context.SqlQuery<Department_UpdateResult>("EXEC [dbo].[Department_Update] @DepartmentID,@Name,@Budget,@StartDate,@InstructorID,@RowVersion_Original  ",parameterDepartmentID,parameterName,parameterBudget,parameterStartDate,parameterInstructorID,parameterRowVersion_Original);

            return result;
        }
    }
}