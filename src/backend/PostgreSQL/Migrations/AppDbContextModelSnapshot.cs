﻿// <auto-generated />
using Anticafe.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(PgSQLDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.BookingDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountPeople")
                        .HasColumnType("integer")
                        .HasColumnName("amount_of_people");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("end_time");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer")
                        .HasColumnName("room_id");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("start_time");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.BookingStatisticsDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("AvgDuration")
                        .HasColumnType("double precision")
                        .HasColumnName("avg_duration");

                    b.Property<double>("MaxDuration")
                        .HasColumnType("double precision")
                        .HasColumnName("max_duration");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer")
                        .HasColumnName("room_id");

                    b.Property<int>("TotalCount")
                        .HasColumnType("integer")
                        .HasColumnName("total_count");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("BookingStatistics");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.FeedbackDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("date");

                    b.Property<int>("Mark")
                        .HasColumnType("integer")
                        .HasColumnName("mark");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.Property<int>("RoomId")
                        .HasColumnType("integer")
                        .HasColumnName("room_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.InventoryDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.MenuDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.RoomDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<double>("Rating")
                        .HasColumnType("numeric")
                        .HasColumnName("Raiting");

                    b.Property<int>("Size")
                        .HasColumnType("integer")
                        .HasColumnName("size");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.UserDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("phone");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("role");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("varchar(64)")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InventoryDbModelRoomDbModel", b =>
                {
                    b.Property<int>("InventoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomsId")
                        .HasColumnType("integer");

                    b.HasKey("InventoriesId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("InventoryDbModelRoomDbModel");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.BookingDbModel", b =>
                {
                    b.HasOne("Anticafe.DataAccess.DBModels.RoomDbModel", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Anticafe.DataAccess.DBModels.UserDbModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.BookingStatisticsDbModel", b =>
                {
                    b.HasOne("Anticafe.DataAccess.DBModels.RoomDbModel", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Anticafe.DataAccess.DBModels.FeedbackDbModel", b =>
                {
                    b.HasOne("Anticafe.DataAccess.DBModels.RoomDbModel", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Anticafe.DataAccess.DBModels.UserDbModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InventoryDbModelRoomDbModel", b =>
                {
                    b.HasOne("Anticafe.DataAccess.DBModels.InventoryDbModel", null)
                        .WithMany()
                        .HasForeignKey("InventoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Anticafe.DataAccess.DBModels.RoomDbModel", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
