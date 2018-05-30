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
    [Migration("20180521131322_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Cls_Softfinc.Usuariosapi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clave")
                        .HasMaxLength(100);

                    b.Property<string>("Idusuario")
                        .HasMaxLength(100);

                    b.Property<string>("Usuario")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("DBUsuariosapi");
                });
#pragma warning restore 612, 618
        }
    }
}
