using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebNotes.WebUI.Models;

namespace WebNotes.WebUI.Migrations.Note
{
    [DbContext(typeof(NoteContext))]
    [Migration("20160225212114_NewDatabase")]
    partial class NewDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebNotes.WebUI.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("NotebookId");

                    b.Property<bool>("Published");

                    b.Property<int?>("TagId");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebNotes.WebUI.Models.Notebook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("DefaultNotebook");

                    b.Property<string>("Name");

                    b.Property<bool>("Published");

                    b.Property<string>("ShareKey");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebNotes.WebUI.Models.NoteResources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("Duration");

                    b.Property<int>("Height");

                    b.Property<int>("NoteId");

                    b.Property<string>("UrlToData");

                    b.Property<int>("Width");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebNotes.WebUI.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HigherLevelId");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebNotes.WebUI.Models.Note", b =>
                {
                    b.HasOne("WebNotes.WebUI.Models.Notebook")
                        .WithMany()
                        .HasForeignKey("NotebookId");

                    b.HasOne("WebNotes.WebUI.Models.Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("WebNotes.WebUI.Models.NoteResources", b =>
                {
                    b.HasOne("WebNotes.WebUI.Models.Note")
                        .WithMany()
                        .HasForeignKey("NoteId");
                });
        }
    }
}
