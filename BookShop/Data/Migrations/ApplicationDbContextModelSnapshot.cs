// <auto-generated />
using System;
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Stephen King",
                            CategoryId = 1,
                            Date = new DateTime(1997, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg",
                            Name = "Batman: The Dark Knight Returns",
                            Price = 6399.0,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Author = "Stephen King",
                            CategoryId = 2,
                            Date = new DateTime(2013, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://img.thriftbooks.com/api/images/i/s/3775E4992634D153CA456BC6C572BA5138A1267D.jpg",
                            Name = "Doctor Sleep",
                            Price = 4499.0,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 3,
                            Author = "Stephen King",
                            CategoryId = 3,
                            Date = new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://m.media-amazon.com/images/I/51nh3JnQNsL.jpg",
                            Name = "From Blood and Ash",
                            Price = 7999.0,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stephen King",
                            CategoryId = 3,
                            Date = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://m.media-amazon.com/images/I/51XzxAUT5QS.jpg",
                            Name = "The Awakening",
                            Price = 1999.0,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 5,
                            Author = "Stephen King",
                            CategoryId = 4,
                            Date = new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images-na.ssl-images-amazon.com/images/I/81NygdDiGRL._AC_UL604_SR604,400_.jpg",
                            Name = "Breath: The New Science of a Lost Art",
                            Price = 1622.0,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 6,
                            Author = "Stephen King",
                            CategoryId = 4,
                            Date = new DateTime(2011, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images-na.ssl-images-amazon.com/images/I/81BAIsimy6L._AC_UL604_SR604,400_.jpg",
                            Name = "Born to Run",
                            Price = 999.0,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 7,
                            Author = "Stephen King",
                            CategoryId = 1,
                            Date = new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg",
                            Name = "All Star Superman",
                            Price = 8199.0,
                            Quantity = 35
                        },
                        new
                        {
                            Id = 8,
                            Author = "Stephen King",
                            CategoryId = 5,
                            Date = new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images-na.ssl-images-amazon.com/images/I/814dSvh3Q6L._AC_UL604_SR604,400_.jpg",
                            Name = "Overkill",
                            Price = 2610.0,
                            Quantity = 45
                        },
                        new
                        {
                            Id = 9,
                            Author = "Stephen King",
                            CategoryId = 2,
                            Date = new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://m.media-amazon.com/images/P/1501156705.01._SCLZZZZZZZ_SX500_.jpg",
                            Name = "Pet Sematary",
                            Price = 1021.0,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 10,
                            Author = "Stephen King",
                            CategoryId = 5,
                            Date = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images-na.ssl-images-amazon.com/images/I/912F2fID5XL._AC_UL604_SR604,400_.jpg",
                            Name = "The 6:20 Man: A Thriller",
                            Price = 1539.0,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetailedId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("DetailedId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DetailedId = 1,
                            Name = "Comics"
                        },
                        new
                        {
                            Id = 2,
                            DetailedId = 2,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            DetailedId = 3,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            DetailedId = 4,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 5,
                            DetailedId = 5,
                            Name = "Mystery"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Detailed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Detailed");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "DC Comics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Supernatural"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Extreme Sports"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Crime"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "44893a60-c39a-4650-8901-8205a4a3cd3b",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "d2976916-3f28-4fd5-a26a-7849233e0da7",
                            Name = "Customer",
                            NormalizedName = "Customer"
                        },
                        new
                        {
                            Id = "3",
                            ConcurrencyStamp = "150c2be2-d5db-4bf5-ac24-2baf8085aef9",
                            Name = "StoreOwner",
                            NormalizedName = "StoreOwner"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "04af858a-2f2d-40c3-a44f-9ab7a479064d",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAENUVKqHf3R9Vb5ZyWrHQ5i7cyv6R9xAvX3Nd0KEgap/VoH3ZHuq1PSYkv+wQBBFfVw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bc3bcc82-69b6-45f7-ab30-87bd0a794387",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5070984-a533-4ee5-9e56-4a91fd9080c9",
                            Email = "customer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEIBffqRPuzOwFlkWtIPxnRBhpVH3v6W/SBwpd1TD7hCZtgC9PAJlLyZIgiFRKWpQgg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "68798ef7-65cf-46f0-b163-445bdce48b32",
                            TwoFactorEnabled = false,
                            UserName = "customer@gmail.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "094180f0-5988-4158-ab83-b3b7037a84b0",
                            Email = "storeowner@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "storeowner@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEGZQsSvrHh8o/P88sosFIGhQlnjL4ictSB0KGB0zKTX6y5jUXgtlQmtn6Y6029tzqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "82981545-befb-4e89-b903-54050e579dd9",
                            TwoFactorEnabled = false,
                            UserName = "storeowner@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.HasOne("BookShop.Models.Detailed", "Detailed")
                        .WithMany("Categories")
                        .HasForeignKey("DetailedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany("Orders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
