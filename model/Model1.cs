using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Quanlyphongkham.model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model121")
        {
        }

        public virtual DbSet<BACSY> BACSies { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CT_CungCapThuoc> CT_CungCapThuoc { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_PHIEUNHAPTHUOC> CT_PHIEUNHAPTHUOC { get; set; }
        public virtual DbSet<CT_SDDV> CT_SDDV { get; set; }
        public virtual DbSet<CT_TOATHUOC> CT_TOATHUOC { get; set; }
        public virtual DbSet<DANTOC> DANTOCs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADONTHANHTOAN> HOADONTHANHTOANs { get; set; }
        public virtual DbSet<KHOADIEUTRI> KHOADIEUTRIs { get; set; }
        public virtual DbSet<LOAIKHAM> LOAIKHAMs { get; set; }
        public virtual DbSet<LOAITHUOC> LOAITHUOCs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NV> NVs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUCANLAMSANG> PHIEUCANLAMSANGs { get; set; }
        public virtual DbSet<PHIEUKETQUA> PHIEUKETQUAs { get; set; }
        public virtual DbSet<PHIEUKHAMBENH> PHIEUKHAMBENHs { get; set; }
        public virtual DbSet<PHIEUNHAPTHUOC> PHIEUNHAPTHUOCs { get; set; }
        public virtual DbSet<PHONGKHAM> PHONGKHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TAIKHOANB> TAIKHOANBS { get; set; }
        public virtual DbSet<TAIKHOANNV> TAIKHOANNVs { get; set; }
        public virtual DbSet<THUOC> THUOCs { get; set; }
        public virtual DbSet<TOATHUOC> TOATHUOCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BACSY>()
                .Property(e => e.MABS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSY>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSY>()
                .Property(e => e.MADT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSY>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSY>()
                .Property(e => e.MAPK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACSY>()
                .HasMany(e => e.PHIEUKETQUAs)
                .WithRequired(e => e.BACSY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .Property(e => e.MADT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.HOADONTHANHTOANs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.PHIEUCANLAMSANGs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BENHNHAN>()
                .HasMany(e => e.PHIEUKHAMBENHs)
                .WithRequired(e => e.BENHNHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NVs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_CungCapThuoc>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_CungCapThuoc>()
                .Property(e => e.MANCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_CungCapThuoc>()
                .HasMany(e => e.CT_PHIEUNHAPTHUOC)
                .WithRequired(e => e.CT_CungCapThuoc)
                .HasForeignKey(e => new { e.MATHUOC, e.MANCC })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MATOATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAPCLS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAPTHUOC>()
                .Property(e => e.MAPNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAPTHUOC>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAPTHUOC>()
                .Property(e => e.MANCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PHIEUNHAPTHUOC>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_SDDV>()
                .Property(e => e.MAPCLS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_SDDV>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TOATHUOC>()
                .Property(e => e.MATOATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TOATHUOC>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TOATHUOC>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TOATHUOC>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANTOC>()
                .Property(e => e.MADT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANTOC>()
                .HasMany(e => e.BACSies)
                .WithRequired(e => e.DANTOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANTOC>()
                .HasMany(e => e.BENHNHANs)
                .WithRequired(e => e.DANTOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CT_SDDV)
                .WithRequired(e => e.DICHVU)
                .HasForeignKey(e => e.MADV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CT_SDDV1)
                .WithRequired(e => e.DICHVU1)
                .HasForeignKey(e => e.MADV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOADIEUTRI>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOADIEUTRI>()
                .HasMany(e => e.BACSies)
                .WithRequired(e => e.KHOADIEUTRI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIKHAM>()
                .Property(e => e.MALOAIK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIKHAM>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LOAIKHAM>()
                .HasMany(e => e.PHIEUKHAMBENHs)
                .WithRequired(e => e.LOAIKHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITHUOC>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAITHUOC>()
                .HasMany(e => e.THUOCs)
                .WithRequired(e => e.LOAITHUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.MANCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<NV>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NV>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NV>()
                .Property(e => e.MADT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NV>()
                .Property(e => e.MACV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NV>()
                .HasMany(e => e.HOADONTHANHTOANs)
                .WithRequired(e => e.NV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NV>()
                .HasMany(e => e.PHIEUKHAMBENHs)
                .WithRequired(e => e.NV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NV>()
                .HasMany(e => e.PHIEUNHAPTHUOCs)
                .WithRequired(e => e.NV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.PHANQUYEN)
                .HasForeignKey(e => e.QUYENTK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.TAIKHOANs1)
                .WithRequired(e => e.PHANQUYEN1)
                .HasForeignKey(e => e.QUYENTK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.MAPCLS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.PHIEUCANLAMSANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_SDDV)
                .WithRequired(e => e.PHIEUCANLAMSANG)
                .HasForeignKey(e => e.MAPCLS);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_SDDV1)
                .WithRequired(e => e.PHIEUCANLAMSANG1)
                .HasForeignKey(e => e.MAPCLS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUKETQUA>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKETQUA>()
                .Property(e => e.MABS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKETQUA>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKETQUA>()
                .HasMany(e => e.TOATHUOCs)
                .WithRequired(e => e.PHIEUKETQUA)
                .HasForeignKey(e => new { e.MAPHIEUKQ, e.MAPHIEUKB })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.MAPK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.MALOAIK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUKHAMBENH>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAPTHUOC>()
                .Property(e => e.MAPNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAPTHUOC>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAPTHUOC>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHONGKHAM>()
                .Property(e => e.MAPK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONGKHAM>()
                .HasMany(e => e.BACSies)
                .WithRequired(e => e.PHONGKHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGKHAM>()
                .HasMany(e => e.PHIEUKHAMBENHs)
                .WithRequired(e => e.PHONGKHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOANB>()
                .Property(e => e.MABS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOANB>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOANNV>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOANNV>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.MATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<THUOC>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CT_TOATHUOC)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOATHUOC>()
                .Property(e => e.MATOATHUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOATHUOC>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOATHUOC>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOATHUOC>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TOATHUOC>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.TOATHUOC)
                .HasForeignKey(e => new { e.MATOATHUOC, e.MAPHIEUKQ, e.MAPHIEUKB })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOATHUOC>()
                .HasMany(e => e.CT_TOATHUOC)
                .WithRequired(e => e.TOATHUOC)
                .HasForeignKey(e => new { e.MATOATHUOC, e.MAPHIEUKQ, e.MAPHIEUKB });
        }
    }
}
