// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Powers.HappyEvent.WebApi.Data;

#nullable disable

namespace Powers.HappyEvent.WebApi.Migrations
{
    [DbContext(typeof(HappyEventDbContext))]
    partial class HappyEventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Powers.HappyEvent.Shared.Gift", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateUserName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("HappyActiveEventId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifyUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PickCount")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HappyActiveEventId");

                    b.ToTable("Gift");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.HappyActiveEvent", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateUserName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifyUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HappyActiveEvent");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.PickRecord", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateUserName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("GiftId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifyUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.ToTable("PickRecord");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreateUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreateUserName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EnableMark")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ModifyUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifyUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.Gift", b =>
                {
                    b.HasOne("Powers.HappyEvent.Shared.HappyActiveEvent", "HappyActiveEvent")
                        .WithMany("Gifts")
                        .HasForeignKey("HappyActiveEventId");

                    b.Navigation("HappyActiveEvent");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.PickRecord", b =>
                {
                    b.HasOne("Powers.HappyEvent.Shared.Gift", "Gift")
                        .WithMany("PickRecords")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gift");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.Gift", b =>
                {
                    b.Navigation("PickRecords");
                });

            modelBuilder.Entity("Powers.HappyEvent.Shared.HappyActiveEvent", b =>
                {
                    b.Navigation("Gifts");
                });
#pragma warning restore 612, 618
        }
    }
}
