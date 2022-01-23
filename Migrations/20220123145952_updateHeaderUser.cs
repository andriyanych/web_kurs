using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompany.Migrations
{
    public partial class updateHeaderUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("071d6f78-2f36-4a02-9bcd-4a885086997e"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("21f99726-2825-493f-a269-d950e2143b58"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("28885be8-1397-402e-add4-4d87c787fd5a"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bdd2d123-1f0f-4022-a032-b5609e50abc1"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d1812281-630c-498e-a73a-87134b363a54"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38546e06-8719-4ad8-b88a-f271ae9d6ecs",
                column: "ConcurrencyStamp",
                value: "05227b66-b780-4495-8982-7dabf2e020cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "25cc7b02-a7d2-420e-8dc4-19f7d425374b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c62472e-4f66-49fa-a20f-e7685b9565e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "912997b0-705b-4a3e-9145-b20adb3d043b", "AQAAAAEAACcQAAAAECaNLrsCXKZ7Amu4MZ2hcKpGwMzeKVxJlZUxuIkfuKZhtW1fNIrko3AnVZ2rDireJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "097b92b1-eaec-4dbb-8308-7a671ca25a1c", "AQAAAAEAACcQAAAAECjsaliX+onTlPdD5FL4Xv81Vb/MAIiWlCyC8ZmYnPfKGUbw/c/qXi6Hdi7ZxdK1LA==" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("f86a8c7c-eb4a-4a2b-8385-414d9cf0fca5"), "PageIndex", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(5504), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("b3f80e0e-9d09-42fb-86e7-22b804a88bc5"), "PageTargets", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(6482), null, null, null, null, "Содержание заполняется администратором", "Цели и задачи", null },
                    { new Guid("9b6c65ae-1b34-4c09-8f0d-1d352fc98509"), "PageSources", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(6525), null, null, null, null, "Содержание заполняется администратором", "Исходные данные", null },
                    { new Guid("69e55792-e895-4b9e-b5f2-7a24328e6e98"), "PagePlan", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(6546), null, null, null, null, "Содержание заполняется администратором", "План работы", null },
                    { new Guid("0730ca63-ee35-46d7-b290-38f539c6528b"), "PageTheory", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(6567), null, null, null, null, "Содержание заполняется администратором", "Теоретические и практические результаты", null },
                    { new Guid("a4c61202-34cc-4716-866c-9d6990b699cf"), "PageTests", new DateTime(2022, 1, 23, 14, 59, 52, 220, DateTimeKind.Utc).AddTicks(6590), null, null, null, null, "Содержание заполняется администратором", "Апробация результатов", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("0730ca63-ee35-46d7-b290-38f539c6528b"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("69e55792-e895-4b9e-b5f2-7a24328e6e98"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("9b6c65ae-1b34-4c09-8f0d-1d352fc98509"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a4c61202-34cc-4716-866c-9d6990b699cf"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b3f80e0e-9d09-42fb-86e7-22b804a88bc5"));

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("f86a8c7c-eb4a-4a2b-8385-414d9cf0fca5"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38546e06-8719-4ad8-b88a-f271ae9d6ecs",
                column: "ConcurrencyStamp",
                value: "d5294aca-f501-48be-bf85-2c8a4a7ab809");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "027496dc-19e9-4a4a-bff8-b2abe9d5d4fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c62472e-4f66-49fa-a20f-e7685b9565e9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84a39cc6-8c08-46d2-9b87-a2c133fda118", "AQAAAAEAACcQAAAAEA/gEzdNKK/13B48jxk5/HFUJWKpkSd+0EftmH6y62l09LuCEiNiul3XuxT6sRv/gA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "855d3332-369c-4f3c-a3b2-6ad1c25ffc8c", "AQAAAAEAACcQAAAAEIEZI6FHRLJxMxOPkGSwTDJNn0/ctE9Iqx1nJFiRsAXUSm/lE6GC1MfsY+hqm1x2Ig==" });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(6566), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("28885be8-1397-402e-add4-4d87c787fd5a"), "PagePlan", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(7519), null, null, null, null, "Содержание заполняется администратором", "Цели и задачи работы", null },
                    { new Guid("071d6f78-2f36-4a02-9bcd-4a885086997e"), "PageSources", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(7561), null, null, null, null, "Содержание заполняется администратором", "Исходные данные", null },
                    { new Guid("d1812281-630c-498e-a73a-87134b363a54"), "PageTargets", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(7582), null, null, null, null, "Содержание заполняется администратором", "Главная", null },
                    { new Guid("bdd2d123-1f0f-4022-a032-b5609e50abc1"), "PageServices", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(7601), null, null, null, null, "Содержание заполняется администратором", "Наши услуги", null },
                    { new Guid("21f99726-2825-493f-a269-d950e2143b58"), "PageContacts", new DateTime(2022, 1, 23, 14, 32, 19, 226, DateTimeKind.Utc).AddTicks(7623), null, null, null, null, "Содержание заполняется администратором", "Контакты", null }
                });
        }
    }
}
