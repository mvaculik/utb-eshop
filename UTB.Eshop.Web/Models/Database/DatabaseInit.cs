using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Web.Models.Entities;
using UTB.Eshop.Web.Models.Identity;

namespace UTB.Eshop.Web.Models.Database
{
    public class DatabaseInit
    {
        public List<CarouselItem> CreateCarouselItems()
        {
            List<CarouselItem> carouselItems = new List<CarouselItem>();

            CarouselItem ci1 = new CarouselItem()
            {
                ID = 1,
                ImageSrc = "/img/carousel/95-954600_pokemon-card-wallpaper.jpg",
                ImageAlt = "First slide"
            };

            CarouselItem ci2 = new CarouselItem()
            {
                ID = 2,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Second slide"
            };


            carouselItems.Add(ci1);
            carouselItems.Add(ci2);

            return carouselItems;
        }

        public List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();


            Product cs1 = new Product()
            {
                ID = 1,
                Name = "Bulbasaur",
                Price = 150,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Bulbasaur"
            };

            Product cs2 = new Product()
            {
                ID = 2,
                Name = "Charmeleon",
                Price = 75,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Charmeleon"
            };

            Product cs3 = new Product()
            {
                ID = 3,
                Name = "Metapod",
                Price = 40,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Metapod"
            };

            Product cs4 = new Product()
            {
                ID = 4,
                Name = "Kakuna",
                Price = 10,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Kakuna"
            };

            Product cs5 = new Product()
            {
                ID = 5,
                Name = "Ekans",
                Price = 50,
                ImageSrc = "/img/carousel/wallpapersden.com_pokemon-4k-cool_3840x2400.jpg",
                ImageAlt = "Ekans"
            };

            products.Add(cs1);
            products.Add(cs2);
            products.Add(cs3);
            products.Add(cs4);
            products.Add(cs5);

            return products;
        }

        public List<Coupon> CreateCoupons()
        {
            List<Coupon> coupons = new List<Coupon>();


            Coupon coupon1 = new Coupon()
            {
                ID = 1,
                Name = "Black Friday",
                Sale = 50,
                Status = "0"
            };

            Coupon coupon2 = new Coupon()
            {
                ID = 2,
                Name = "Christmas",
                Sale = 25,
                Status = "0"
            };

            coupons.Add(coupon1);
            coupons.Add(coupon2);

            return coupons;
        }

        public List<Role> CreateRoles()
        {
            List<Role> roles = new List<Role>();

            Role roleAdmin = new Role()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "9cf14c2c-19e7-40d6-b744-8917505c3106"
            };

            Role roleManager = new Role()
            {
                Id = 2,
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "be0efcde-9d0a-461d-8eb6-444b043d6660"
            };

            Role roleCustomer = new Role()
            {
                Id = 3,
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee"
            };


            roles.Add(roleAdmin);
            roles.Add(roleManager);
            roles.Add(roleCustomer);

            return roles;
        }


        public (User, List<IdentityUserRole<int>>) CreateAdminWithRoles()
        {
            User admin = new User()
            {
                Id = 1,
                FirstName = "Adminek",
                LastName = "Adminovy",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.cz",
                NormalizedEmail = "ADMIN@ADMIN.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==",
                SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> adminUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 1
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 3
                }
            };

            return (admin, adminUserRoles);
        }


        public (User, List<IdentityUserRole<int>>) CreateManagerWithRoles()
        {
            User manager = new User()
            {
                Id = 2,
                FirstName = "Managerek",
                LastName = "Managerovy",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@manager.cz",
                NormalizedEmail = "MANAGER@MANAGER.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                ConcurrencyStamp = "7a8d96fd-5918-441b-b800-cbafa99de97b",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> managerUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 3
                }
            };

            return (manager, managerUserRoles);
        }


        public List<Group> CreateGroups()
        {
            List<Group> groups = new List<Group>();

            Group groupStandard = new Group()
            {
                Id = 1,
                Name = "Standard",
                Sale = 0
            };

            Group groupStudent = new Group()
            {
                Id = 2,
                Name = "Student",
                Sale = 10
            };

            Group groupVIP = new Group()
            {
                Id = 3,
                Name = "VIP",
                Sale = 50
            };


            groups.Add(groupStandard);
            groups.Add(groupStudent);
            groups.Add(groupVIP);

            return groups;
        }
    }
}
