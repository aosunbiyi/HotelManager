using HMS.DATALAYER.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DATALAYER.Data
{
    public class HmsDbContext : DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }

        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<AmenityType> AmenityTypes { get; set; }
        public virtual DbSet<ApplicationConfiguration> ApplicationConfigurations { get; set; }
        public virtual DbSet<ArrivalDepartureLog> ArrivalDepartureLogs { get; set; }
        public virtual DbSet<BusinessSourceType> BusinessSourceTypes { get; set; }
        public virtual DbSet<BusinessSource> BusinessSources { get; set; }
        public virtual DbSet<DiscountPlan> DiscountPlans { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ExtraChargeCategory> ExtraChargeCategories { get; set; }
        public virtual DbSet<ExtraCharge> ExtraCharges { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<LaundryGuestTransactionItem> LaundryGuestTransactionItems { get; set; }
        public virtual DbSet<LaundryGuestTransaction> LaundryGuestTransactions { get; set; }
        public virtual DbSet<LaundryHotelTransationItem> LaundryHotelTransationItems { get; set; }
        public virtual DbSet<LaundryHotelTransation> LaundryHotelTransations { get; set; }
        public virtual DbSet<LaundryHotelService> LaundryHotelServices { get; set; }
        public virtual DbSet<LaundryItemCategory> LaundryItemCategories { get; set; }
        public virtual DbSet<LaundryItem> LaundryItems { get; set; }
        public virtual DbSet<LaundryItemService> LaundryItemServices { get; set; }
        public virtual DbSet<LaundryPackagingType> LaundryPackagingTypes { get; set; }
        public virtual DbSet<LaundryService> LaundryServices { get; set; }
        public virtual DbSet<RateType> RateTypes { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<RemarkCategory> remark_categories { get; set; }
        public virtual DbSet<Remark> remarks { get; set; }
        public virtual DbSet<ReservationPayment> ReservationPayments { get; set; }
        public virtual DbSet<ReservationTransaction> ReservationTransactions { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReserveRoom> ReserveRooms { get; set; }
        public virtual DbSet<RoomImage> RoomImages { get; set; }
        public virtual DbSet<RoomOwner> RoomOwners { get; set; }
        public virtual DbSet<RoomStatusColor> RoomStatusColors { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<RoomTypeRate> RoomTypeRates { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomAmenity> RoomAmenities { get; set; }
        public virtual DbSet<RoomWeekDay> RoomWeekDays { get; set; }
        public virtual DbSet<SeasonType> SeasonTypes { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<TaxSettingType> TaxSettingTypes { get; set; }
        public virtual DbSet<TaxSetting> TaxSettings { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<WeekDay> WeekDays { get; set; }
        public virtual DbSet<Wing> wings { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=hotelDB;Trusted_Connection=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AccountType>(entity => {
                entity.Property(e=>e.Name).IsRequired().HasMaxLength(200).IsUnicode(false);
                entity.Property(e => e.Alias).HasMaxLength(200).IsUnicode(false);
                entity.Property(e => e.UniqueIndentifier).HasMaxLength(350).IsUnicode(false);
            
            });

            builder.Entity<Account>(entity => { 
            
            });
        }
    }

}
