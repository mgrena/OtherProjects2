using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Servier.Pressure.Migrations
{
    /// <inheritdoc />
    public partial class Questionnaires2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_info",
                table: "info");

            migrationBuilder.RenameTable(
                name: "info",
                newName: "infos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_infos",
                table: "infos",
                column: "id");

            migrationBuilder.CreateTable(
                name: "demographies",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    is_man = table.Column<bool>(type: "bit", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    smoker = table.Column<int>(type: "int", nullable: false),
                    education = table.Column<int>(type: "int", nullable: false),
                    diagnosis_year = table.Column<int>(type: "int", nullable: false),
                    diagnosis_year_unknown = table.Column<bool>(type: "bit", nullable: false),
                    treatment_year = table.Column<int>(type: "int", nullable: false),
                    treatment_year_unknown = table.Column<bool>(type: "bit", nullable: false),
                    diag_none = table.Column<bool>(type: "bit", nullable: false),
                    diag_diabetes = table.Column<bool>(type: "bit", nullable: false),
                    diag_diabetes_type = table.Column<int>(type: "int", nullable: false),
                    diag_dyslipidemia = table.Column<bool>(type: "bit", nullable: false),
                    diag_dyslipidemia_drug = table.Column<int>(type: "int", nullable: false),
                    diag_ICHS = table.Column<bool>(type: "bit", nullable: false),
                    diag_ICHS_infarction = table.Column<bool>(type: "bit", nullable: false),
                    diag_ICHS_angina = table.Column<bool>(type: "bit", nullable: false),
                    diag_ICHS_angiography = table.Column<bool>(type: "bit", nullable: false),
                    diag_ICHS_angiography_type = table.Column<int>(type: "int", nullable: false),
                    diag_ICHS_revascularization = table.Column<bool>(type: "bit", nullable: false),
                    diag_ICHS_revascularization_type = table.Column<int>(type: "int", nullable: false),
                    diag_failure = table.Column<bool>(type: "bit", nullable: false),
                    diag_fibrillation = table.Column<bool>(type: "bit", nullable: false),
                    diag_stroke = table.Column<bool>(type: "bit", nullable: false),
                    diag_arteriald = table.Column<bool>(type: "bit", nullable: false),
                    diag_insufficiency = table.Column<bool>(type: "bit", nullable: false),
                    diag_kidneyd = table.Column<bool>(type: "bit", nullable: false),
                    diag_kidneyd_type = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demographies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "laboratory_tests",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    cholesterol = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    cholesterol_unknown = table.Column<bool>(type: "bit", nullable: false),
                    ldl = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    ldl_unknown = table.Column<bool>(type: "bit", nullable: false),
                    hdl = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    hdl_unknown = table.Column<bool>(type: "bit", nullable: false),
                    non_hdl = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    non_hdl_unknown = table.Column<bool>(type: "bit", nullable: false),
                    triglycerides = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    triglycerides_unknown = table.Column<bool>(type: "bit", nullable: false),
                    albumin = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    albumin_unknown = table.Column<bool>(type: "bit", nullable: false),
                    creatinine = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    creatinine_unknown = table.Column<bool>(type: "bit", nullable: false),
                    glycemia = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    glycemia_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laboratory_tests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "list_dyslipidemia_drugs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_list_dyslipidemia_drugs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "list_treatment_monotherapy_drugs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monotherapy = table.Column<int>(type: "int", nullable: false),
                    is_aldosterone_antagonist = table.Column<bool>(type: "bit", nullable: false),
                    order_number = table.Column<int>(type: "int", nullable: false),
                    drug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_list_treatment_monotherapy_drugs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "list_treatment_multitherapy_drugs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    multitherapy = table.Column<int>(type: "int", nullable: false),
                    order_number = table.Column<int>(type: "int", nullable: false),
                    drug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_list_treatment_multitherapy_drugs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "physical_examinations_1",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    height = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    height_unknown = table.Column<bool>(type: "bit", nullable: false),
                    weight = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    weight_unknown = table.Column<bool>(type: "bit", nullable: false),
                    waist = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    waist_unknown = table.Column<bool>(type: "bit", nullable: false),
                    hand = table.Column<int>(type: "int", nullable: false),
                    measurement_1 = table.Column<bool>(type: "bit", nullable: false),
                    measurement_1_stk = table.Column<int>(type: "int", nullable: false),
                    measurement_1_dtk = table.Column<int>(type: "int", nullable: false),
                    measurement_1_sf = table.Column<int>(type: "int", nullable: false),
                    measurement_2 = table.Column<bool>(type: "bit", nullable: false),
                    measurement_2_stk = table.Column<int>(type: "int", nullable: false),
                    measurement_2_dtk = table.Column<int>(type: "int", nullable: false),
                    measurement_2_sf = table.Column<int>(type: "int", nullable: false),
                    measurement_3 = table.Column<bool>(type: "bit", nullable: false),
                    measurement_3_stk = table.Column<int>(type: "int", nullable: false),
                    measurement_3_dtk = table.Column<int>(type: "int", nullable: false),
                    measurement_3_sf = table.Column<int>(type: "int", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_physical_examinations_1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "treatment_monotherapies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    visit_number = table.Column<int>(type: "int", nullable: false),
                    id_drug = table.Column<int>(type: "int", nullable: false),
                    monotherapy = table.Column<int>(type: "int", nullable: false),
                    is_aldosterone_antagonist = table.Column<bool>(type: "bit", nullable: false),
                    dose = table.Column<int>(type: "int", nullable: false),
                    number_morning = table.Column<int>(type: "int", nullable: false),
                    number_noon = table.Column<int>(type: "int", nullable: false),
                    number_evening = table.Column<int>(type: "int", nullable: false),
                    is_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatment_monotherapies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "treatment_multitherapies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_patient = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    visit_number = table.Column<int>(type: "int", nullable: false),
                    id_drug = table.Column<int>(type: "int", nullable: false),
                    multitherapy = table.Column<int>(type: "int", nullable: false),
                    dose_1 = table.Column<int>(type: "int", nullable: false),
                    dose_2 = table.Column<int>(type: "int", nullable: false),
                    dose_3 = table.Column<int>(type: "int", nullable: false),
                    number_morning = table.Column<int>(type: "int", nullable: false),
                    number_noon = table.Column<int>(type: "int", nullable: false),
                    number_evening = table.Column<int>(type: "int", nullable: false),
                    is_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatment_multitherapies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "treatments_before",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    diag_dyslipidemia_drug = table.Column<int>(type: "int", nullable: false),
                    gp = table.Column<bool>(type: "bit", nullable: false),
                    diabetologist = table.Column<bool>(type: "bit", nullable: false),
                    geriatrician = table.Column<bool>(type: "bit", nullable: false),
                    internist = table.Column<bool>(type: "bit", nullable: false),
                    cardiologist = table.Column<bool>(type: "bit", nullable: false),
                    other = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    fix_combination_3_unknown = table.Column<bool>(type: "bit", nullable: false),
                    fix_combination_mix_unknown = table.Column<bool>(type: "bit", nullable: false),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatments_before", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "list_dyslipidemia_drugs",
                columns: new[] { "id", "created_at", "deleted_at", "modified_at", "drug" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "žiadna" },
                    { 2, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "statín" },
                    { 3, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "fibrát" },
                    { 4, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ezetimib" },
                    { 5, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "statín/ezetimib" },
                    { 6, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kys. bempedoová" },
                    { 7, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "kys. bempedoová / ezetimib" },
                    { 8, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "inhibítor PCSK9" },
                    { 9, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "inclisiran" },
                    { 10, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "„polypill“" },
                    { 11, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "výživový doplnok" },
                    { 12, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "neznáma" }
                });

            migrationBuilder.InsertData(
                table: "list_treatment_monotherapy_drugs",
                columns: new[] { "id", "created_at", "deleted_at", "is_aldosterone_antagonist", "modified_at", "monotherapy", "drug", "order_number" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "enalapril", 1 },
                    { 2, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fosinopril", 2 },
                    { 3, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "imidapril", 3 },
                    { 4, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "kaptopril", 4 },
                    { 5, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "lisinopril", 5 },
                    { 6, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "perindopril", 6 },
                    { 7, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "quinapril", 7 },
                    { 8, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ramipril", 8 },
                    { 9, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "trandolapril", 9 },
                    { 10, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "irbesartan", 1 },
                    { 11, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "kandesartan", 2 },
                    { 12, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "losartan", 3 },
                    { 13, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "telmisartan", 4 },
                    { 14, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "valsartan", 5 },
                    { 15, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "amlodipín", 1 },
                    { 16, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "felodipín", 2 },
                    { 17, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "isradipín", 3 },
                    { 18, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "lacidipín", 4 },
                    { 19, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "lercandipín", 5 },
                    { 20, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "nifedipín", 6 },
                    { 21, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "nitrendipín", 7 },
                    { 22, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "verapamil", 8 },
                    { 23, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "atenolol", 1 },
                    { 24, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "betaxolol", 2 },
                    { 25, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "bisoprolol", 3 },
                    { 26, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "celiprolol", 4 },
                    { 27, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "esmololol", 5 },
                    { 28, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "karvedilol", 6 },
                    { 29, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "labetalol", 7 },
                    { 30, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "metipranolol", 8 },
                    { 31, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "metoprolol", 9 },
                    { 32, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "nebivolol", 10 },
                    { 33, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "HCTZ", 1 },
                    { 34, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "indapamid", 2 },
                    { 35, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "metipamid", 3 },
                    { 36, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "antagonista aldosterónu", 4 },
                    { 37, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "eplerenón", 1 },
                    { 38, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "finerenón", 2 },
                    { 39, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "spironolaktón", 3 },
                    { 40, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "doxazosín", 1 },
                    { 41, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "metyldopa", 2 },
                    { 42, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "metipamid", 3 },
                    { 43, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "moxonidín", 4 },
                    { 44, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "rilmenidín", 5 },
                    { 45, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "urapidil", 6 }
                });

            migrationBuilder.InsertData(
                table: "list_treatment_multitherapy_drugs",
                columns: new[] { "id", "created_at", "deleted_at", "modified_at", "multitherapy", "drug", "order_number" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amilorid / HCTZ", 1 },
                    { 2, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amlodipín / bisoprolol", 2 },
                    { 3, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "bisoprolol / HCTZ", 3 },
                    { 4, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "bisoprolol / perindopril", 4 },
                    { 5, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fosinopril / HCTZ", 5 },
                    { 6, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "irbesartan / HCTZ", 6 },
                    { 7, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "kandesartan / HCTZ", 7 },
                    { 8, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "lisinopril / amlodipine", 8 },
                    { 9, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "lisinopril / HCTZ", 9 },
                    { 10, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "losartan/ amlodipín", 10 },
                    { 11, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "losartan / HCTZ", 11 },
                    { 12, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "nebivolol / HCTZ", 12 },
                    { 13, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "perindopril / indapamid", 13 },
                    { 14, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "perindopril / amlodipín", 14 },
                    { 15, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "quinapril / HCTZ", 15 },
                    { 16, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ramipril / amlodipín", 16 },
                    { 17, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ramipril / bisoprolol", 17 },
                    { 18, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ramipril / HCTZ", 18 },
                    { 19, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "telmisartan / amlodipín", 19 },
                    { 20, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "telmisartan/ HCTZ", 20 },
                    { 21, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "trandolapril / verapamil", 21 },
                    { 22, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "valsartan / amlodipín", 22 },
                    { 23, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "valsartan / HCTZ", 23 },
                    { 24, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "perindopril / amlodipín / indapamid", 1 },
                    { 25, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "perindopril / indapamid / amlodipín", 2 },
                    { 26, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "valsartan / amlodipín / HCTZ", 3 },
                    { 27, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "atorvastatín / amlodipín", 1 },
                    { 28, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "atorvastatín / perindopril / amlodipín", 2 },
                    { 29, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "rosuvastatín / perindopril / HCTZ", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "demographies");

            migrationBuilder.DropTable(
                name: "laboratory_tests");

            migrationBuilder.DropTable(
                name: "list_dyslipidemia_drugs");

            migrationBuilder.DropTable(
                name: "list_treatment_monotherapy_drugs");

            migrationBuilder.DropTable(
                name: "list_treatment_multitherapy_drugs");

            migrationBuilder.DropTable(
                name: "physical_examinations_1");

            migrationBuilder.DropTable(
                name: "treatment_monotherapies");

            migrationBuilder.DropTable(
                name: "treatment_multitherapies");

            migrationBuilder.DropTable(
                name: "treatments_before");

            migrationBuilder.DropPrimaryKey(
                name: "PK_infos",
                table: "infos");

            migrationBuilder.RenameTable(
                name: "infos",
                newName: "info");

            migrationBuilder.AddPrimaryKey(
                name: "PK_info",
                table: "info",
                column: "id");
        }
    }
}
