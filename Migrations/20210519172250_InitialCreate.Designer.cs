﻿// <auto-generated />
using AutoSeed.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoSeed.Migrations
{
    [DbContext(typeof(AutoSeedDbContext))]
    [Migration("20210519172250_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("AutoSeed.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "962.587.170-55",
                            Email = "MaiteMelo_Xavier@bol.com.br",
                            Nome = "Maitê Melo"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "070.664.115-95",
                            Email = "JoaoCarvalho.Souza99@gmail.com",
                            Nome = "João Carvalho"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "883.395.307-63",
                            Email = "YasminXavier14@hotmail.com",
                            Nome = "Yasmin Xavier"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "708.212.258-63",
                            Email = "CarlaFranco98@hotmail.com",
                            Nome = "Carla Franco"
                        },
                        new
                        {
                            Id = 5,
                            Cpf = "345.448.357-39",
                            Email = "NorbertoPereira14@gmail.com",
                            Nome = "Norberto Pereira"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
