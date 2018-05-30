﻿// <auto-generated />
using ApiSoftfinc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ApiSoftfinc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180526091940_v15")]
    partial class v15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cls_Softfinc.CambioMovil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ejecutado");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Fechaejecutado")
                        .HasColumnType("datetime");

                    b.Property<string>("Idregistro")
                        .HasMaxLength(50);

                    b.Property<string>("Imei")
                        .HasMaxLength(20);

                    b.Property<string>("Nota")
                        .HasMaxLength(50);

                    b.Property<string>("Notaejecucion")
                        .HasMaxLength(50);

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(300);

                    b.Property<string>("Uidapp")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TbCambiomovil");
                });

            modelBuilder.Entity("Cls_Softfinc.Configuracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion")
                        .HasMaxLength(100);

                    b.Property<string>("Idempresa")
                        .HasMaxLength(100);

                    b.Property<string>("Ncorto")
                        .HasMaxLength(100);

                    b.Property<string>("Nlargo")
                        .HasMaxLength(100);

                    b.Property<string>("Slogan");

                    b.Property<int>("Status");

                    b.Property<string>("Telefono")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("TbConfiEmp");
                });

            modelBuilder.Entity("Cls_Softfinc.EmpActualizarapp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Actualizar");

                    b.Property<string>("Appidupdate")
                        .HasMaxLength(100);

                    b.Property<string>("Idempresa")
                        .HasMaxLength(50);

                    b.Property<string>("Nota")
                        .HasMaxLength(200);

                    b.Property<string>("Urlapp")
                        .HasMaxLength(100);

                    b.Property<string>("Version")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TbActualizarAppEmpr");
                });

            modelBuilder.Entity("Cls_Softfinc.Moviles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cambios");

                    b.Property<string>("Clave")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("F_registro")
                        .HasColumnType("datetime");

                    b.Property<string>("Idempresa")
                        .HasMaxLength(50);

                    b.Property<string>("Idusuario")
                        .HasMaxLength(50);

                    b.Property<string>("Imei")
                        .HasMaxLength(20);

                    b.Property<string>("Nota")
                        .HasMaxLength(200);

                    b.Property<int>("Status");

                    b.Property<int>("Tprinter");

                    b.Property<string>("Uidapp")
                        .HasMaxLength(50);

                    b.Property<string>("Ultip")
                        .HasMaxLength(50);

                    b.Property<string>("Version")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("TbMoviles");
                });
#pragma warning restore 612, 618
        }
    }
}
