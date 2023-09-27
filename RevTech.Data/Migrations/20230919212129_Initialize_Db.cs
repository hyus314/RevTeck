using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class Initialize_Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    Torque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TCUTunings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCUTunings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ECUTunings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECUTunings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ECUTunings_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuelPumps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelPumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelPumps_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjectorKits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectorKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjectorKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OilCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilCoolers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OilCoolers_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SparkPlugsKits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparkPlugsKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SparkPlugsKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuperchargerKits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperchargerKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperchargerKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurboKits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    PressureBoost = table.Column<decimal>(type: "decimal(3,1)", precision: 3, scale: 1, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurboKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurboKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    YearCreated_Start = table.Column<int>(type: "int", nullable: false),
                    YearCreated_End = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModelsEngines",
                columns: table => new
                {
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelsEngines", x => new { x.CarModelId, x.EngineId });
                    table.ForeignKey(
                        name: "FK_CarModelsEngines_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModelsEngines_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExhaustKits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    HorsePowerBoost = table.Column<int>(type: "int", nullable: false),
                    TorqueBoost = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    CarModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExhaustKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExhaustKits_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExhaustKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    TurboKitId = table.Column<int>(type: "int", nullable: true),
                    ECUTuningId = table.Column<int>(type: "int", nullable: true),
                    ExhaustKitId = table.Column<int>(type: "int", nullable: true),
                    FuelPumpId = table.Column<int>(type: "int", nullable: true),
                    InjectorKitId = table.Column<int>(type: "int", nullable: true),
                    OilCoolerId = table.Column<int>(type: "int", nullable: true),
                    SparkPlugsId = table.Column<int>(type: "int", nullable: true),
                    SuperchargerKitId = table.Column<int>(type: "int", nullable: true),
                    TCUTuningId = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    HorsePowerBoostTotal = table.Column<int>(type: "int", nullable: false),
                    TorqueBoostTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configurations_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ECUTunings_ECUTuningId",
                        column: x => x.ECUTuningId,
                        principalTable: "ECUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ExhaustKits_ExhaustKitId",
                        column: x => x.ExhaustKitId,
                        principalTable: "ExhaustKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_FuelPumps_FuelPumpId",
                        column: x => x.FuelPumpId,
                        principalTable: "FuelPumps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_InjectorKits_InjectorKitId",
                        column: x => x.InjectorKitId,
                        principalTable: "InjectorKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_OilCoolers_OilCoolerId",
                        column: x => x.OilCoolerId,
                        principalTable: "OilCoolers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_SparkPlugsKits_SparkPlugsId",
                        column: x => x.SparkPlugsId,
                        principalTable: "SparkPlugsKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_SuperchargerKits_SuperchargerKitId",
                        column: x => x.SuperchargerKitId,
                        principalTable: "SuperchargerKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_TCUTunings_TCUTuningId",
                        column: x => x.TCUTuningId,
                        principalTable: "TCUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_TurboKits_TurboKitId",
                        column: x => x.TurboKitId,
                        principalTable: "TurboKits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Configurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersConfiguration",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersConfiguration", x => new { x.UserId, x.ConfigurationId });
                    table.ForeignKey(
                        name: "FK_UsersConfiguration_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersConfiguration_Configurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "HorsePower", "Name", "Torque" },
                values: new object[,]
                {
                    { 1, 150, "1.8t", 210 },
                    { 2, 163, "1.8t", 250 },
                    { 3, 180, "1.8t", 235 },
                    { 4, 265, "2.7tt", 362 },
                    { 5, 250, "2.7tt", 342 },
                    { 6, 450, "4.2 FSI", 430 },
                    { 7, 354, "4.2 FSI", 440 },
                    { 8, 350, "4.2 FSI", 440 },
                    { 9, 200, "2.0 TFSI", 280 },
                    { 10, 211, "2.0 TFSI", 350 },
                    { 11, 420, "4.0 TFSI", 600 },
                    { 12, 560, "4.0 TFSI", 700 },
                    { 13, 605, "4.0 TFSI", 700 },
                    { 14, 333, "3.0 TFSI", 440 },
                    { 15, 290, "3.0 TFSI", 420 },
                    { 16, 310, "3.0 TFSI", 440 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "https://www.freepnglogos.com/uploads/audi-logo-29.png", "Audi" },
                    { 2, "https://www.freepnglogos.com/uploads/mercedes-logo-png/mercedes-logo-world-car-mercedes-benz-class-cdi-1.png", "Mercedes-Benz" },
                    { 3, "https://cdn.freebiesupply.com/logos/large/2x/bmw-logo-png-transparent.png", "BMW" }
                });

            migrationBuilder.InsertData(
                table: "TCUTunings",
                columns: new[] { "Id", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "Once this selected TCU Option is installed, it will result in a higher Top Speed, but the acceleration rate will be reduced", "https://tuitionphysics.com/wp-content/uploads/2020/06/speed-velocity-and-acceleration-concepts-differences.jpg", "Increase Top Speed" },
                    { 2, "Once this selected TCU Option is installed, it will result in a faster Acceleration, but the Top Speed will be reduced", "https://grimmermotors.co.nz/wp-content/uploads/2018/03/high-rpm.jpg", "Increase Acceleration" },
                    { 3, "This TCU Option includes a balanced combination of both Acceleration and Top Speed", "https://cdn.hswstatic.com/gif/gears-1.jpg", "Balanced" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ImageURL", "ManufacturerId", "ModelName", "YearCreated_End", "YearCreated_Start" },
                values: new object[,]
                {
                    { 1, "https://img.favcars.com/audi/a6/photos_audi_a6_2001_2_b.jpg", 1, "A6 C5", 2004, 1997 },
                    { 2, "https://i.ytimg.com/vi/AAfmxSRncBU/maxresdefault.jpg", 1, "A4 B5", 2001, 1996 },
                    { 3, "https://stillrunningstrong.com/wp-content/uploads/2018/03/Audi-A4-b6-sport-model-S4-1024x466.jpg", 1, "A4 B6", 2004, 2002 },
                    { 4, "https://images.fitmentindustries.com/web-compressed/1740944-1-2001-s4-audi-base-bc-racing-coilovers-bbs-ch-r-silver.jpg", 1, "S4 B5", 2001, 1997 },
                    { 5, "https://media.evo.co.uk/image/private/s--zWq7JwVH--/v1556260759/evo/images/dir_688/car_photo_344347.jpg", 1, "RS4 B7", 2009, 2005 },
                    { 6, "https://www.ast-suspension.com/imager/common/10988/Audi-S5-B8-3_ccc647699d3b878f33fab0fc43e2f880.jpg", 1, "S5 B8", 2013, 2007 },
                    { 7, "https://en.audiclub.eu/graphics/gallery/full/2178_13237385133-509f54d839-b.jpg", 1, "S5 B8.5", 2017, 2013 },
                    { 8, "https://cimg7.ibsrv.net/gimg/www.audiworld.com-vbulletin/1200x837/audi_driveway_725b6dcf65369cb5d7d45810f3e5e8d8c487097a.jpg", 1, "RS5 B8.5", 2017, 2013 },
                    { 9, "https://cdn.shopify.com/s/files/1/0570/5518/3000/collections/a6_c6.jpg?v=1648793950", 1, "A6 C6", 2011, 2004 },
                    { 10, "https://i.pinimg.com/originals/e1/a2/32/e1a232889a2009dffca15f9b432ab3b8.jpg", 1, "A4 B7", 2008, 2004 },
                    { 11, "https://i.pinimg.com/originals/4f/54/ea/4f54ea4597e4fc876df08c49bad03992.jpg", 1, "A4 B8.5", 2015, 2012 },
                    { 12, "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg", 1, "S6 C7", 2018, 2011 },
                    { 13, "https://www.tuningblog.eu/wp-content/uploads/2022/08/Verrueckter-Stage-4-Audi-RS6-C7-Avant-1200-PS-1-e1661412369854.jpg", 1, "RS6 C7", 2018, 2011 },
                    { 14, "https://www.tuning.bg/public/upload/gallery/extended/normal/1358582002.jpg", 1, "S8 D4", 2015, 2012 },
                    { 15, "https://cdn-0.carsopedia.com/files/generations/Audi-D4-498.jpg", 1, "S8+ D4.5", 2018, 2015 },
                    { 16, "https://www.auto-data.net/images/f4/file3193601.jpg", 1, "S7 C7", 2017, 2012 },
                    { 17, "https://www.autocar.co.uk/sites/autocar.co.uk/files/audi-rs7_1.jpg", 1, "RS7 C7", 2019, 2013 },
                    { 18, "https://upload.wikimedia.org/wikipedia/commons/8/85/Audi_A6_S-line_%28C7%29_%E2%80%93_Frontansicht%2C_1._Mai_2012%2C_D%C3%BCsseldorf.jpg", 1, "A6 C7", 2018, 2011 },
                    { 19, "https://mir-s3-cdn-cf.behance.net/project_modules/fs/b2ebb974237045.5c27acde184ed.jpg", 1, "Q7 4L", 2015, 2005 }
                });

            migrationBuilder.InsertData(
                table: "ECUTunings",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Name", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 2, 2, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 3, 3, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 4, 4, 65, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp", "034Motorsport", "ECU Upgrade for 2.7t", 495.0m, 90 },
                    { 5, 5, 65, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp", "034Motorsport", "ECU Upgrade for 2.7t", 495.0m, 90 },
                    { 6, 6, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 7, 7, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 8, 8, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 9, 9, 55, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 2.0 TFSI", 399.95m, 70 },
                    { 10, 10, 55, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 2.0 TFSI", 399.95m, 70 },
                    { 11, 11, 130, "https://clptuning.co.uk/wp-content/uploads/2016/11/APR-Stage-1-300x300.jpg", "APR", "ECU Upgrade for 4.0 TFSI", 1200.00m, 180 },
                    { 12, 12, 80, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.0 TFSI", 800.00m, 130 },
                    { 13, 13, 80, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.0 TFSI", 800.00m, 130 },
                    { 14, 14, 120, "/img/apr-ecu-for-3.0-tfsi.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 },
                    { 15, 15, 120, "/img/apr-ecu-for-3.0-tfsi.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 },
                    { 16, 16, 120, "/img/apr-ecu-for-3.0-tfsi.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 }
                });

            migrationBuilder.InsertData(
                table: "FuelPumps",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 2, 2, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 3, 3, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 4, 4, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 5, 5, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 6, 11, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 7, 6, 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 }
                });

            migrationBuilder.InsertData(
                table: "FuelPumps",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 8, 7, 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 },
                    { 9, 9, 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 },
                    { 10, 10, 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 },
                    { 11, 11, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 12, 12, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 13, 13, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 14, 14, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 },
                    { 15, 15, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 },
                    { 16, 16, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 }
                });

            migrationBuilder.InsertData(
                table: "InjectorKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "Bosch", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 },
                    { 2, 2, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "Bosch", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 },
                    { 3, 3, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "Bosch", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 },
                    { 4, 1, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 },
                    { 5, 2, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 },
                    { 6, 3, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 },
                    { 7, 1, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 },
                    { 8, 2, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 },
                    { 9, 3, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 },
                    { 10, 4, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 },
                    { 11, 5, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 },
                    { 12, 4, 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 },
                    { 13, 5, 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 },
                    { 14, 6, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 15, 7, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 16, 8, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 17, 11, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 18, 12, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 19, 13, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 20, 9, 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 },
                    { 21, 10, 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 },
                    { 22, 14, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 },
                    { 23, 15, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 },
                    { 24, 16, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 }
                });

            migrationBuilder.InsertData(
                table: "OilCoolers",
                columns: new[] { "Id", "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[,]
                {
                    { 1, 1, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m },
                    { 2, 2, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m },
                    { 3, 3, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m },
                    { 4, 4, "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m },
                    { 5, 5, "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m },
                    { 6, 6, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 7, 7, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 8, 8, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 9, 9, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m }
                });

            migrationBuilder.InsertData(
                table: "OilCoolers",
                columns: new[] { "Id", "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[,]
                {
                    { 10, 10, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m },
                    { 11, 1, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 12, 2, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 13, 3, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 14, 4, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 15, 5, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 16, 6, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 17, 7, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 18, 8, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 19, 9, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 20, 10, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 21, 11, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 22, 12, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 23, 13, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 24, 14, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 25, 15, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 26, 16, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m }
                });

            migrationBuilder.InsertData(
                table: "SparkPlugsKits",
                columns: new[] { "Id", "EngineId", "ImageURL", "Manufacturer", "Price" },
                values: new object[,]
                {
                    { 1, 1, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", "NGK", 44.42m },
                    { 2, 2, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", "NGK", 44.42m },
                    { 3, 3, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", "NGK", 44.42m },
                    { 4, 4, "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", "NGK", 130.55m },
                    { 5, 5, "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", "NGK", 130.55m },
                    { 6, 6, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 7, 7, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 8, 8, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 9, 9, "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", "NGK", 87.03m },
                    { 10, 10, "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", "NGK", 87.03m },
                    { 11, 11, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 12, 12, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 13, 13, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 14, 14, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m },
                    { 15, 15, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m },
                    { 16, 16, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m }
                });

            migrationBuilder.InsertData(
                table: "SuperchargerKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "ModelName", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 6, 200, "/img/superchargerKitId1.jpg", "APR", "TVS1740 Stage 3+", 18000.99m, 210 },
                    { 2, 7, 180, "/img/superchargerKitId2.jpg", "APR", "95 RON", 17000.99m, 140 },
                    { 3, 8, 180, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "PES", "Whipple 140AX", 15000.99m, 140 },
                    { 4, 13, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 },
                    { 5, 14, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 },
                    { 6, 15, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 }
                });

            migrationBuilder.InsertData(
                table: "TurboKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "ModelName", "PressureBoost", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 200, "https://www.turbozentrum.de/media/image/product/826/lg/garrett-turbokit-vw-golf-bora-audi-a3-tt-18t-350ps.jpg", "Garrett", "GT2860RS", 1.8m, 2799.67m, 250 },
                    { 2, 1, 160, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1920/https://www.bar-tek-tuning.com/thumbnail/fe/88/79/1683873716/2218t03-1.8T%20Tuning-Kit%20STUFE%203_1920x1920.webp", "BAR-TEK", "Turbo-Total K04-001", 1.6m, 2115.26m, 200 },
                    { 3, 2, 280, "https://www.raimotorsport.com/v/vspfiles/photos/RAI_B6A4_1.8t_GTX-2.jpg", "RAI", "GTX B6A4", 2.0m, 2675.00m, 310 }
                });

            migrationBuilder.InsertData(
                table: "TurboKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "ModelName", "PressureBoost", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 4, 2, 210, "https://turboconcepts.net/wp-content/uploads/2019/11/A4_18t_long_blackfridaypackage.gif", "RAI", "Turbo Concepts", 1.9m, 1679.00m, 270 },
                    { 5, 3, 190, "https://www.turbo-parts.de/images/product_images/info_images/1.8T%20mit%20Downpipe.jpg", "Garrett", "GT2876R", 1.8m, 1851.98m, 250 },
                    { 6, 4, 400, "https://turboconcepts.net/wp-content/uploads/2019/11/DZX-274a.gif", "Turbo Concepts", "DZX-274", 2.2m, 1995.00m, 500 },
                    { 7, 4, 400, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/0/3/034Motorsport_B5_S4_RS4_K04_Stage_3_Turbo_Kit_1.webp", "034Motorsport", "K04 Twin Turbo", 2.3m, 3671.90m, 500 },
                    { 8, 5, 380, "https://www.tzr-motorsport.de/WebRoot/Store20/Shops/61911476/5F43/7DE0/D7D2/230B/A266/0A0C/6D10/D0F0/TTE380_Turbolader_Audi_A6_C5_TZR_Motorsport.jpg", "The Turbo Engineers", "TTE380+", 2.1m, 2723.50m, 450 },
                    { 9, 9, 250, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "GMC Racing", "GMC0501KT", 1.9m, 4182.85m, 300 },
                    { 10, 9, 180, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "BAR-TEK", "Tuning-Kit K04", 1.8m, 2733.32m, 250 },
                    { 11, 9, 150, "https://www.tte24.net/images/product_images/info_images/1130_0.JPG", "The Turbo Engineers", "TTE450", 1.8m, 1902.43m, 220 },
                    { 12, 10, 250, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "GMC Racing", "GMC0501KT", 1.9m, 4182.85m, 300 },
                    { 13, 10, 180, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/52/d0/2c/1652867184/1460914175-17347gcxpvr99dwrhl_1280x1280.webp", "BAR-TEK", "Tuning-Kit K04", 1.8m, 2733.32m, 250 },
                    { 14, 10, 150, "https://www.tte24.net/images/product_images/info_images/1130_0.JPG", "The Turbo Engineers", "TTE450", 1.8m, 1902.43m, 220 },
                    { 15, 11, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 16, 12, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 17, 13, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 18, 11, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 19, 12, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 20, 13, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 21, 11, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 22, 12, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 23, 13, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 24, 13, 395, "https://www.tte24.net/images/product_images/popup_images/1272_1.JPG", "The Turbo Engineers", "TTE1000+ Hybrid", 2.5m, 8745.71m, 450 }
                });

            migrationBuilder.InsertData(
                table: "CarModelsEngines",
                columns: new[] { "CarModelId", "EngineId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 6 },
                    { 6, 7 },
                    { 6, 14 },
                    { 7, 7 },
                    { 7, 14 },
                    { 8, 6 },
                    { 9, 8 },
                    { 9, 15 },
                    { 10, 9 },
                    { 11, 10 },
                    { 12, 11 },
                    { 13, 12 },
                    { 14, 12 },
                    { 15, 13 },
                    { 16, 11 },
                    { 17, 12 },
                    { 18, 16 },
                    { 19, 8 },
                    { 19, 15 },
                    { 19, 16 }
                });

            migrationBuilder.InsertData(
                table: "ExhaustKits",
                columns: new[] { "Id", "CarModelId", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg", "Jetex", "1.8t A6 C5 Exhaust Kit", 800.85m, 20 },
                    { 2, 1, 3, 10, "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg", "Jetex", "1.8t A6 C5 Exhaust Kit", 800.85m, 20 },
                    { 3, 1, 4, 15, "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg", "B&B", "2.7t A6 C5 Exhaust Kit", 1292.40m, 30 },
                    { 4, 1, 5, 15, "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg", "B&B", "2.7t A6 C5 Exhaust Kit", 1292.40m, 30 },
                    { 5, 1, 4, 17, "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp", "Milltek", "2.7t A6 C5 Exhaust Kit", 1800.00m, 35 },
                    { 6, 1, 5, 17, "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp", "Milltek", "2.7t A6 C5 Exhaust Kit", 1800.00m, 35 },
                    { 7, 2, 1, 10, "https://en.bsr.se/assets/images/products/big/737962_big.jpg", "Simons", "1.8t A4 B5 Exhaust Kit", 681.20m, 20 },
                    { 8, 2, 3, 10, "https://en.bsr.se/assets/images/products/big/737962_big.jpg", "Simons", "1.8t A4 B5 Exhaust Kit", 681.20m, 20 },
                    { 9, 2, 1, 10, "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg", "Jetex", "1.8t A4 B5 Exhaust Kit", 528.14m, 20 },
                    { 10, 2, 3, 10, "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg", "Jetex", "1.8t A4 B5 Exhaust Kit", 528.14m, 20 },
                    { 11, 3, 4, 10, "https://www.bbexhaust.com/wp-content/uploads/2016/05/FPIM-0530-2.jpg", "Billy Boat Exhaust", "2.7tt S4 B5 Exhaust Kit", 1579.93m, 20 },
                    { 12, 5, 6, 20, "https://cmwheels.com/wp-content/uploads/2018/01/products-SSXAU116.jpg", "Milltek", "4.2FSI RS4 B7 Exhaust Kit", 2234.31m, 40 },
                    { 13, 5, 6, 15, "https://media.vwpartsinternational.com/wp-content/uploads/2018/05/21162655/Audi-RS4-B7-4.2-V8-Saloon-Avant-Milltek-Sport-Performance-Non-Resonated-Cat-Back-Exhaust-System-Inc-Satin-Sheen-Black-Tips-SSXAU218.jpeg", "Milltek", "4.2FSI RS4 B7 Exhaust Kit", 1816.85m, 30 }
                });

            migrationBuilder.InsertData(
                table: "ExhaustKits",
                columns: new[] { "Id", "CarModelId", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 14, 6, 7, 15, "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg", "Milltek", "4.2FSI S5 B8 Exhaust Kit", 1105.44m, 30 },
                    { 15, 7, 7, 15, "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg", "Milltek", "4.2FSI S5 B8.5 Exhaust Kit", 1105.44m, 30 },
                    { 16, 7, 14, 15, "https://clptuning.co.uk/product/milltek-cat-back-exhaust-system-audi-s4-s5-b8-5-3-0tfsi/", "Milltek", "3.0TFSI S5 B8.5 Exhaust Kit", 2726.91m, 30 },
                    { 17, 8, 6, 13, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs5-b8/audi-rs5-v8-exhaust-16.jpg", "Armytrix", "4.2 FSI RS5 B8.5 VALVETRONIC Exhaust Kit", 5440.69m, 15 },
                    { 18, 8, 6, 13, "https://clptuning.co.uk/wp-content/uploads/2018/01/SSXAU261_1-300x300.jpg", "Milltek", "4.2 FSI RS5 B8.5 Exhaust Kit", 3341.50m, 15 },
                    { 19, 9, 8, 5, "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg", "SuperSprint", "4.2 FSI A6 C6 Centre Exhaust + X-Pipe", 1665.06m, 9 },
                    { 20, 9, 15, 5, "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg", "SuperSprint", "3.0 TFSI A6 C6 Centre Exhaust + X-Pipe", 1581.80m, 9 },
                    { 21, 9, 15, 7, "https://cdn11.bigcommerce.com/s-ov4aejck1y/images/stencil/1920w/products/296179/35616535/840756122694944651_jhm-c6a630tcbe-thmb__05028.1668196184.jpg?c=1", "JHM", "3.0 TFSI A6 C6 Cat Back Exhaust", 1750.59m, 10 },
                    { 22, 10, 9, 5, "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg", "Milltek", "2.0 TFSI A4 B7 Cat Back Exhaust", 1524.78m, 8 },
                    { 23, 10, 9, 5, "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg", "Jetex", "2.0 TFSI A4 B7 Half Exhaust Kit", 773.83m, 8 },
                    { 24, 10, 9, 7, "https://en.bsr.se/assets/images/products/big/4383_big.jpg", "Ferrita", "2.0 TFSI A4 B7 Exhaust Kit", 1144.67m, 11 },
                    { 25, 11, 10, 5, "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg", "Milltek", "2.0 TFSI A4 B7 Cat Back Exhaust", 1524.78m, 8 },
                    { 26, 11, 10, 5, "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg", "Jetex", "2.0 TFSI A4 B7 Half Exhaust Kit", 773.83m, 8 },
                    { 27, 11, 10, 7, "https://en.bsr.se/assets/images/products/big/4383_big.jpg", "Ferrita", "2.0 TFSI A4 B7 Exhaust Kit", 1144.67m, 11 },
                    { 28, 12, 11, 15, "https://cdn.shopify.com/s/files/1/0070/1779/1577/products/DSC01072_53eeb7bc-42ea-4166-837b-1b16ee4022d2_1200x1200.jpg?v=1590075728", "TNEER", "4.0 TFSI S6 C7 Exhaust Kit", 7513.22m, 20 },
                    { 29, 12, 11, 15, "https://cdn.shopify.com/s/files/1/2493/0960/products/a9f1f012a32f87a8ca5b762158af25b7.jpg?v=1610140343", "APR", "4.0 TFSI S6 C7 Cat Back Exhaust ", 3500.00m, 20 },
                    { 30, 13, 12, 20, "https://www.wrsauto.it/161-thickbox_default/akrapovic-evolution-exhaust-system-audi-rs6-avant-c7-2014-2018.jpg", "Akrapovic", "4.0 TFSI RS6 C7 Cat Back Exhaust", 10417.38m, 25 },
                    { 31, 13, 12, 15, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs6-rs7/audi-rs6-c7-armytrix-exhaust-1.jpg", "Armytrix", "4.0 TFSI RS6 C7 VALVETRONIC Exhaust Kit", 7604.22m, 25 },
                    { 32, 16, 11, 10, "https://germanmuscle.co/wp-content/uploads/2022/05/FI-Exhaust-2012-2017-Audi-S6-C7-4.0T-Valvetronic-Exhaust-System-1.jpg", "FI", "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit", 4500.99m, 15 },
                    { 33, 16, 11, 10, "https://www.futurez.fi/wp-content/uploads/76ae3060571a43ba82ef55d2f9617482-1.png", "Akrapovic", "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit", 10344.74m, 15 },
                    { 34, 17, 12, 10, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs7/audi-rs7-c7-armytrix-exhaust-9.jpg", "Armytrix", "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit", 7804.22m, 15 },
                    { 35, 17, 12, 10, "https://www.motorsport24.nl/wp-content/uploads/2022/04/SAUTI4H-1.png", "Akrapovic", "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit", 11042.88m, 15 },
                    { 36, 14, 12, 10, "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg", "Milltek", "4.0 TFSI S8 D4 Exhaust Kit", 11042.88m, 15 },
                    { 37, 14, 12, 10, "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg", "Capristo", "4.0 TFSI S8 D4 Cat Back Exhaust", 7300.00m, 15 },
                    { 38, 14, 12, 10, "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg", "Milltek", "4.0 TFSI S8 D4 Exhaust Kit", 11042.88m, 15 },
                    { 39, 15, 13, 10, "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg", "Capristo", "4.0 TFSI S8 D4 Cat Back Exhaust", 7300.00m, 15 },
                    { 40, 18, 16, 5, "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg", "Martellius", "3.0 TFSI A6 C7 Cat Back Exhaust", 1415.60m, 8 },
                    { 41, 18, 16, 5, "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg", "Milltek", "4.2 FSI Q7 4L Exhaust Kit", 2700.00m, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_ManufacturerId",
                table: "CarModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModelsEngines_EngineId",
                table: "CarModelsEngines",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_CarModelId",
                table: "Configurations",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ECUTuningId",
                table: "Configurations",
                column: "ECUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_EngineId",
                table: "Configurations",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ExhaustKitId",
                table: "Configurations",
                column: "ExhaustKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_FuelPumpId",
                table: "Configurations",
                column: "FuelPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_InjectorKitId",
                table: "Configurations",
                column: "InjectorKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_OilCoolerId",
                table: "Configurations",
                column: "OilCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_SparkPlugsId",
                table: "Configurations",
                column: "SparkPlugsId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_SuperchargerKitId",
                table: "Configurations",
                column: "SuperchargerKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_TCUTuningId",
                table: "Configurations",
                column: "TCUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_TurboKitId",
                table: "Configurations",
                column: "TurboKitId");

            migrationBuilder.CreateIndex(
                name: "IX_ECUTunings_EngineId",
                table: "ECUTunings",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_ExhaustKits_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ExhaustKits_EngineId",
                table: "ExhaustKits",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelPumps_EngineId",
                table: "FuelPumps",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectorKits_EngineId",
                table: "InjectorKits",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_OilCoolers_EngineId",
                table: "OilCoolers",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId",
                table: "Payments",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ConfigurationId",
                table: "Payments",
                column: "ConfigurationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SparkPlugsKits_EngineId",
                table: "SparkPlugsKits",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_SuperchargerKits_EngineId",
                table: "SuperchargerKits",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_TurboKits_EngineId",
                table: "TurboKits",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfiguration_ConfigurationId",
                table: "UsersConfiguration",
                column: "ConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarModelsEngines");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UsersConfiguration");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "ECUTunings");

            migrationBuilder.DropTable(
                name: "ExhaustKits");

            migrationBuilder.DropTable(
                name: "FuelPumps");

            migrationBuilder.DropTable(
                name: "InjectorKits");

            migrationBuilder.DropTable(
                name: "OilCoolers");

            migrationBuilder.DropTable(
                name: "SparkPlugsKits");

            migrationBuilder.DropTable(
                name: "SuperchargerKits");

            migrationBuilder.DropTable(
                name: "TCUTunings");

            migrationBuilder.DropTable(
                name: "TurboKits");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
