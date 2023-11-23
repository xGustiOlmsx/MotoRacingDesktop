﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotoRacingDesktop.Data;

#nullable disable

namespace MotoRacingDesktop.Migrations
{
    [DbContext(typeof(MotoRacingDesktopContext))]
    [Migration("20231122162214_agregoCorredorAActividad")]
    partial class agregoCorredorAActividad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MotoRacingDesktop.Models.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CorredorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Horarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CorredorId");

                    b.ToTable("Actividades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Costo = 25000m,
                            Horarios = "Lunes y miércoles 20hs",
                            Nombre = "Moto GP"
                        },
                        new
                        {
                            Id = 2,
                            Costo = 25000m,
                            Horarios = "Martes y Jueves 20hs",
                            Nombre = "Moto Cross"
                        },
                        new
                        {
                            Id = 3,
                            Costo = 20000m,
                            Horarios = "Lunes y miércoles 16hs",
                            Nombre = "Karting GP"
                        },
                        new
                        {
                            Id = 4,
                            Costo = 20000m,
                            Horarios = "Martes y Jueves 16hs",
                            Nombre = "Moto Enduro"
                        });
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Cobrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cobradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Rodrigo Palacio"
                        });
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Corredor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PistaId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PistaId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Corredores");
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Cuota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<bool>("Cobrada")
                        .HasColumnType("bit");

                    b.Property<int?>("CobradorId")
                        .HasColumnType("int");

                    b.Property<int>("CorredorId")
                        .HasColumnType("int");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("CobradorId");

                    b.HasIndex("CorredorId");

                    b.ToTable("Cuotas");
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Pista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pistas");
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Moto Deportiva"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Moto Cross"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Karting"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Moto Enduro"
                        });
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Actividad", b =>
                {
                    b.HasOne("MotoRacingDesktop.Models.Corredor", "Corredores")
                        .WithMany()
                        .HasForeignKey("CorredorId");

                    b.Navigation("Corredores");
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Corredor", b =>
                {
                    b.HasOne("MotoRacingDesktop.Models.Pista", "Pista")
                        .WithMany()
                        .HasForeignKey("PistaId");

                    b.HasOne("MotoRacingDesktop.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");

                    b.Navigation("Pista");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("MotoRacingDesktop.Models.Cuota", b =>
                {
                    b.HasOne("MotoRacingDesktop.Models.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotoRacingDesktop.Models.Cobrador", "Cobrador")
                        .WithMany()
                        .HasForeignKey("CobradorId");

                    b.HasOne("MotoRacingDesktop.Models.Corredor", "corredor")
                        .WithMany()
                        .HasForeignKey("CorredorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("Cobrador");

                    b.Navigation("corredor");
                });
#pragma warning restore 612, 618
        }
    }
}
