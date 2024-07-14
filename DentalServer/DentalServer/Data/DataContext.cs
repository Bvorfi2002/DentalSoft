using DentalServer.Models;
using Microsoft.EntityFrameworkCore;

namespace DentalServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentResult> AppointmentResults { get; set; }
        public DbSet<AppointmentResultServices> AppointmentResultServices { get; set; }
        public DbSet<AppointmentServices> AppointmentServices { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BuyingBill> BuyingBills { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<MedicalForm> MedicalForms { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProdUsage> ProdUsages { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<PaymentData> PaymentDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Appointment
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Clinic)
                .WithMany()
                .HasForeignKey(a => a.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany()
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasMany(a => a.Services)
                .WithOne(s => s.Appointment)
                .HasForeignKey(s => s.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // AppointmentResult
            modelBuilder.Entity<AppointmentResult>()
                .HasOne(ar => ar.Clinic)
                .WithMany()
                .HasForeignKey(ar => ar.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppointmentResult>()
                .HasOne(ar => ar.Appointment)
                .WithMany()
                .HasForeignKey(ar => ar.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppointmentResult>()
                .HasMany(ar => ar.Services)
                .WithOne(s => s.AppointmentResult)
                .HasForeignKey(s => s.AppointmentResultId)
                .OnDelete(DeleteBehavior.Restrict);

            // AppointmentResultServices
            modelBuilder.Entity<AppointmentResultServices>()
                .HasKey(ars => new { ars.AppointmentResultId, ars.ServiceId });

            modelBuilder.Entity<AppointmentResultServices>()
                .HasOne(ars => ars.AppointmentResult)
                .WithMany(ar => ar.Services)
                .HasForeignKey(ars => ars.AppointmentResultId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppointmentResultServices>()
                .HasOne(ars => ars.Service)
                .WithMany()
                .HasForeignKey(ars => ars.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // AppointmentServices
            modelBuilder.Entity<AppointmentServices>()
                .HasKey(aps => new { aps.AppointmentId, aps.ServiceId });

            modelBuilder.Entity<AppointmentServices>()
                .HasOne(aps => aps.Appointment)
                .WithMany(a => a.Services)
                .HasForeignKey(aps => aps.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppointmentServices>()
                .HasOne(aps => aps.Service)
                .WithMany()
                .HasForeignKey(aps => aps.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Bill
            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Clinic)
                .WithMany()
                .HasForeignKey(b => b.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Patient)
                .WithMany()
                .HasForeignKey(b => b.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Appointment)
                .WithMany()
                .HasForeignKey(b => b.AppointmentResultId)
                .OnDelete(DeleteBehavior.Restrict);

            // BuyingBill
            modelBuilder.Entity<BuyingBill>()
                .HasOne(bb => bb.Clinic)
                .WithMany()
                .HasForeignKey(bb => bb.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BuyingBill>()
                .HasOne(bb => bb.Product)
                .WithMany()
                .HasForeignKey(bb => bb.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BuyingBill>()
                .HasOne(bb => bb.Supplier)
                .WithMany()
                .HasForeignKey(bb => bb.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            // Clinic
            modelBuilder.Entity<Clinic>()
                .HasOne(c => c.inventory)
                .WithOne(i => i.Clinic)
                .HasForeignKey<Inventory>(i => i.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Clinic>()
                .HasMany(c => c.suppliers)
                .WithMany();

            modelBuilder.Entity<Clinic>()
                .HasMany(c => c.bills)
                .WithOne(b => b.Clinic)
                .HasForeignKey(b => b.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Clinic>()
                .HasMany(c => c.buyingBills)
                .WithOne(bb => bb.Clinic)
                .HasForeignKey(bb => bb.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            // History
            modelBuilder.Entity<History>()
                .HasKey(h => new { h.PatientId, h.ServiceId });

            modelBuilder.Entity<History>()
                .HasOne(h => h.Patient)
                .WithMany(p => p.Historic)
                .HasForeignKey(h => h.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<History>()
                .HasOne(h => h.Service)
                .WithMany()
                .HasForeignKey(h => h.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Inventory
            modelBuilder.Entity<Inventory>()
                .HasMany(i => i.Products)
                .WithOne(p => p.Inventory)
                .HasForeignKey(p => p.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Invoice
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Clinic)
                .WithMany()
                .HasForeignKey(i => i.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            // MedicalForm
            modelBuilder.Entity<MedicalForm>()
                .HasOne(mf => mf.Clinic)
                .WithMany()
                .HasForeignKey(mf => mf.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MedicalForm>()
                .HasMany(mf => mf.Questions)
                .WithOne()
                .HasForeignKey(q => q.MedicalFormId)
                .OnDelete(DeleteBehavior.Restrict);

            // Patient
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Pictures)
                .WithOne()
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Historic)
                .WithOne(h => h.Patient)
                .HasForeignKey(h => h.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.MedicalForm)
                .WithOne()
                .HasForeignKey<MedicalForm>(mf => mf.ClinicId)
                .OnDelete(DeleteBehavior.Restrict);

            // Picture
            modelBuilder.Entity<Picture>()
                .HasKey(p => new { p.PatientId, p.PicturePath });

            // Product
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Inventory)
                .WithMany(i => i.Products)
                .HasForeignKey(p => p.InventoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.supplier)
                .WithMany()
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            // ProdUsage
            modelBuilder.Entity<ProdUsage>()
                .HasKey(pu => new { pu.ProductId, pu.ServiceId });

            modelBuilder.Entity<ProdUsage>()
                .HasOne(pu => pu.Product)
                .WithMany()
                .HasForeignKey(pu => pu.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProdUsage>()
                .HasOne(pu => pu.Service)
                .WithMany(s => s.ProdUsage)
                .HasForeignKey(pu => pu.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question
            modelBuilder.Entity<Question>()
                .HasKey(q => q.QuestionId);

            // Service
            modelBuilder.Entity<Service>()
                .HasKey(s => s.ServiceId);

            modelBuilder.Entity<Service>()
                .HasMany(s => s.ProdUsage)
                .WithOne(pu => pu.Service)
                .HasForeignKey(pu => pu.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Supplier
            modelBuilder.Entity<Supplier>()
                .HasKey(s => s.SupplierId);


            // User - Payment Relationship
            modelBuilder.Entity<User>()
            .HasOne<PaymentData>(u => u.PaymentData)
            .WithOne(pd => pd.User)
            .HasForeignKey<PaymentData>(pd => pd.UserId);
        }

    }
}
