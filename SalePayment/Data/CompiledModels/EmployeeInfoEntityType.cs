﻿// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
using N8T.Core.Domain;
using SalePayment.Domain;

#pragma warning disable 219, 612, 618
#nullable enable

namespace SalePayment
{
    internal partial class EmployeeInfoEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "SalePayment.Domain.EmployeeInfo",
                typeof(EmployeeInfo),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(Guid),
                propertyInfo: typeof(EntityBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            id.AddAnnotation("Relational:ColumnName", "id");
            id.AddAnnotation("Relational:ColumnType", "uuid");
            id.AddAnnotation("Relational:DefaultValueSql", "uuid_generate_v4()");

            var created = runtimeEntityType.AddProperty(
                "Created",
                typeof(DateTime),
                propertyInfo: typeof(EntityBase).GetProperty("Created", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Created>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            created.AddAnnotation("Relational:ColumnName", "created");

            var employeeId = runtimeEntityType.AddProperty(
                "EmployeeId",
                typeof(Guid),
                propertyInfo: typeof(EmployeeInfo).GetProperty("EmployeeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EmployeeInfo).GetField("<EmployeeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            employeeId.AddAnnotation("Relational:ColumnName", "employee_id");

            var updated = runtimeEntityType.AddProperty(
                "Updated",
                typeof(DateTime?),
                propertyInfo: typeof(EntityBase).GetProperty("Updated", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EntityBase).GetField("<Updated>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            updated.AddAnnotation("Relational:ColumnName", "updated");

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "pk_employees_info");

            var index = runtimeEntityType.AddIndex(
                new[] { id },
                unique: true);
            index.AddAnnotation("Relational:Name", "ix_employees_info_id");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "sale_payment");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "employees_info");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}