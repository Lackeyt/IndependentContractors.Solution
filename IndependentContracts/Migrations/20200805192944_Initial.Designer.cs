﻿// <auto-generated />
using System;
using IndependentContracts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IndependentContracts.Migrations
{
    [DbContext(typeof(IndependentContractsContext))]
    [Migration("20200805192944_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IndependentContracts.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<DateTime>("accountCreationDate");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("IndependentContracts.Models.ClientContractor", b =>
                {
                    b.Property<int>("ClientContractorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int>("ContractorId");

                    b.HasKey("ClientContractorId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ContractorId");

                    b.ToTable("ClientContractor");
                });

            modelBuilder.Entity("IndependentContracts.Models.Contractor", b =>
                {
                    b.Property<int>("ContractorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<string>("RegionOfOperation");

                    b.Property<string>("WeaponOfChoice");

                    b.HasKey("ContractorId");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("IndependentContracts.Models.ClientContractor", b =>
                {
                    b.HasOne("IndependentContracts.Models.Client", "Client")
                        .WithMany("Contractors")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IndependentContracts.Models.Contractor", "Contractor")
                        .WithMany("Clients")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
