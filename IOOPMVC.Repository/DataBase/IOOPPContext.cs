using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IOOPMVC.Repository.DataBase
{
    public partial class IOOPPContext : IdentityDbContext
    {
        public IOOPPContext()
        {
        }

        public IOOPPContext(DbContextOptions<IOOPPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Absence> Absence { get; set; }
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<AnneeScolaire> AnneeScolaire { get; set; }
        public virtual DbSet<Classe> Classe { get; set; }
        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Etablissement> Etablissement { get; set; }
        public virtual DbSet<Etudiant> Etudiant { get; set; }
        public virtual DbSet<Filiere> Filiere { get; set; }
        public virtual DbSet<Inscription> Inscription { get; set; }
        public virtual DbSet<Matiere> Matiere { get; set; }
        public virtual DbSet<MatiereEtudiant> MatiereEtudiant { get; set; }
        public virtual DbSet<ModePaiement> ModePaiement { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Paiement> Paiement { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=IOOPP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ApplicationUser>().ToTable("UserLogin").Property(p => p.Id).HasColumnName("UserEmail");
            //modelBuilder.Entity<ApplicationUser>().ToTable("UserLogin").Property(p => p.Id).HasColumnName("UserPassword");

            //modelBuilder.Entity<BaseProfile>(entity =>
            //{
            //    entity.ToTable("BaseProfile");
            //    entity.Ignore(e => e.LockoutEnd);
            //    entity.Ignore(e => e.ConcurrencyStamp);
            //    entity.Ignore(e => e.NormalizedEmail);
            //    entity.Ignore(e => e.NormalizedUserName);
            //    entity.Ignore(e => e.LockoutEnd);
            //});

            //modelBuilder.Ignore<IdentityUserLogin<string>>();
            //modelBuilder.Ignore<IdentityUserRole<string>>();
            //modelBuilder.Ignore<IdentityUserClaim<string>>();
            //modelBuilder.Ignore<IdentityUserToken<string>>();
            //modelBuilder.Ignore<IdentityUser<string>>();
            //modelBuilder.Ignore<ApplicationUser>();

            modelBuilder.Entity<Absence>(entity =>
            {
                entity.HasKey(e => e.IdAbsence);

                entity.Property(e => e.IdAbsence).HasColumnName("ID_Absence");

                entity.Property(e => e.DateDebut)
                    .HasColumnName("Date_Debut")
                    .HasColumnType("date");

                entity.Property(e => e.DateFin)
                    .HasColumnName("Date_Fin")
                    .HasColumnType("date");

                entity.Property(e => e.IdPersonne).HasColumnName("ID_Personne");

                entity.Property(e => e.Justification).HasMaxLength(50);
            });

            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.HasKey(e => e.IdAdresse)
                    .HasName("PK__Adresse__44E01E6E4A6E5BCC");

                entity.Property(e => e.IdAdresse).HasColumnName("ID_Adresse");

                entity.Property(e => e.Adresse1).HasMaxLength(50);

                entity.Property(e => e.Adresse2).HasMaxLength(50);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50);

                entity.Property(e => e.Pays).HasMaxLength(50);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.Région).HasMaxLength(50);

                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<AnneeScolaire>(entity =>
            {
                entity.HasKey(e => e.IdAnneeScolaire);

                entity.Property(e => e.IdAnneeScolaire).HasColumnName("ID_AnneeScolaire");

                entity.Property(e => e.NomAnneeScolaire)
                    .HasColumnName("Nom_AnneeScolaire")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.IdClasse);

                entity.Property(e => e.IdClasse).HasColumnName("ID_Classe");

                entity.Property(e => e.CodeClase)
                    .HasColumnName("Code_Clase")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NomClasse)
                    .HasColumnName("Nom_Classe")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cours>(entity =>
            {
                entity.HasKey(e => e.IdCours);

                entity.Property(e => e.IdCours).HasColumnName("ID_Cours");

                entity.Property(e => e.DateCours)
                    .HasColumnName("Date_Cours")
                    .HasColumnType("date");

                entity.Property(e => e.HeureCours)
                    .HasColumnName("Heure_Cours")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdClasse).HasColumnName("ID_Classe");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.IdMatiere).HasColumnName("ID_Matiere");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__D9EE4F361E0533CF");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.DateEmbauce)
                    .HasColumnName("Date_Embauce")
                    .HasColumnType("date");

                entity.Property(e => e.DateFinContrat)
                    .HasColumnName("Date_Fin_Contrat")
                    .HasColumnType("date");

                entity.Property(e => e.DiplômeMax)
                    .HasColumnName("Diplôme_Max")
                    .HasMaxLength(50);

                entity.Property(e => e.IdAdresse).HasColumnName("ID_Adresse");

                entity.Property(e => e.IdFiliere).HasColumnName("ID_Filiere");

                entity.Property(e => e.IdPersonne).HasColumnName("ID_Personne");

                entity.Property(e => e.IdProfession).HasColumnName("ID_Profession");

                entity.Property(e => e.NiveauEtude)
                    .HasColumnName("Niveau_Etude")
                    .HasMaxLength(50);

                entity.Property(e => e.Statut)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Etablissement>(entity =>
            {
                entity.HasKey(e => e.IdEtablissement)
                    .HasName("PK__Etabliss__89523A02222E4561");

                entity.Property(e => e.IdEtablissement).HasColumnName("ID_Etablissement");

                entity.Property(e => e.AvisCommission)
                    .HasColumnName("Avis_Commission")
                    .HasMaxLength(50);

                entity.Property(e => e.CadreRésponsable)
                    .HasColumnName("Cadre_Résponsable")
                    .HasMaxLength(50);

                entity.Property(e => e.DateAutorisation)
                    .HasColumnName("Date_Autorisation")
                    .HasMaxLength(50);

                entity.Property(e => e.DateAvis)
                    .HasColumnName("Date_Avis")
                    .HasColumnType("date");

                entity.Property(e => e.IdAdresse).HasColumnName("ID_Adresse");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");

                entity.Property(e => e.NomEtablissement)
                    .HasColumnName("Nom_Etablissement")
                    .HasMaxLength(50);

                entity.Property(e => e.NuméroAutorisation)
                    .HasColumnName("Numéro_Autorisation")
                    .HasMaxLength(50);

                entity.Property(e => e.Sigle).HasMaxLength(50);

                entity.HasOne(d => d.IdAdresseNavigation)
                    .WithMany(p => p.Etablissement)
                    .HasForeignKey(d => d.IdAdresse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdrsEtablissement");
            });

            modelBuilder.Entity<Etudiant>(entity =>
            {
                entity.HasKey(e => e.IdEtudiant)
                    .HasName("PK__Etudiant__635FC9BCB33D3D5A");

                entity.Property(e => e.IdEtudiant).HasColumnName("ID_Etudiant");

                entity.Property(e => e.IdAdresse).HasColumnName("ID_Adresse");

                entity.Property(e => e.IdFiliere).HasColumnName("ID_Filiere");

                entity.Property(e => e.IdPersonne).HasColumnName("ID_Personne");

                entity.Property(e => e.Matricule).HasMaxLength(50);

                entity.Property(e => e.NiveauEtudeMère)
                    .HasColumnName("Niveau_Etude_Mère")
                    .HasMaxLength(50);

                entity.Property(e => e.NiveauEtudePère)
                    .HasColumnName("Niveau_Etude_Père")
                    .HasMaxLength(50);

                entity.Property(e => e.NomMère)
                    .HasColumnName("Nom_Mère")
                    .HasMaxLength(50);

                entity.Property(e => e.NomPère)
                    .HasColumnName("Nom_Père")
                    .HasMaxLength(50);

                entity.Property(e => e.ProfessionMère)
                    .HasColumnName("Profession_Mère")
                    .HasMaxLength(50);

                entity.Property(e => e.ProfessionPère)
                    .HasColumnName("Profession_Père")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdAdresseNavigation)
                    .WithMany(p => p.Etudiant)
                    .HasForeignKey(d => d.IdAdresse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdrsEtudiant");

                entity.HasOne(d => d.IdFiliereNavigation)
                    .WithMany(p => p.Etudiant)
                    .HasForeignKey(d => d.IdFiliere)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FiliereEtudiant");

                entity.HasOne(d => d.IdPersonneNavigation)
                    .WithMany(p => p.Etudiant)
                    .HasForeignKey(d => d.IdPersonne)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersEtudiant");
            });

            modelBuilder.Entity<Filiere>(entity =>
            {
                entity.HasKey(e => e.IdFiliere)
                    .HasName("PK__Filiere__8DFF9D41FA51711F");

                entity.Property(e => e.IdFiliere).HasColumnName("ID_Filiere");

                entity.Property(e => e.CapacitéFiliere)
                    .HasColumnName("Capacité_Filiere")
                    .HasMaxLength(50);

                entity.Property(e => e.DateQualification)
                    .HasColumnName("Date_Qualification")
                    .HasMaxLength(50);

                entity.Property(e => e.DureEnAnnée)
                    .HasColumnName("Dure_En_Année")
                    .HasMaxLength(50);

                entity.Property(e => e.IdAdresse).HasColumnName("ID_Adresse");

                entity.Property(e => e.IdEtablissement).HasColumnName("ID_Etablissement");

                entity.Property(e => e.NiveauFiliere)
                    .HasColumnName("Niveau_Filiere")
                    .HasMaxLength(50);

                entity.Property(e => e.NomFiliere)
                    .HasColumnName("Nom_Filiere")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.Filiere)
                    .HasForeignKey(d => d.IdEtablissement)
                    .HasConstraintName("FK_EtabFiliere");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.IdInscription);

                entity.Property(e => e.IdInscription).HasColumnName("ID_Inscription");

                entity.Property(e => e.DateInscription)
                    .HasColumnName("Date_Inscription")
                    .HasColumnType("date");

                entity.Property(e => e.IdAnneeScolaire).HasColumnName("ID_AnneeScolaire");

                entity.Property(e => e.IdEtudiant).HasColumnName("ID_Etudiant");

                entity.Property(e => e.IdModule).HasColumnName("ID_Module");
            });

            modelBuilder.Entity<Matiere>(entity =>
            {
                entity.HasKey(e => e.IdMatiere);

                entity.Property(e => e.IdMatiere).HasColumnName("ID_Matiere");

                entity.Property(e => e.CodeMatiere)
                    .HasColumnName("Code_Matiere")
                    .HasMaxLength(50);

                entity.Property(e => e.IdModule).HasColumnName("ID_Module");

                entity.Property(e => e.NomMatiere)
                    .HasColumnName("Nom_matiere")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdModuleNavigation)
                    .WithMany(p => p.Matiere)
                    .HasForeignKey(d => d.IdModule)
                    .HasConstraintName("FK_ModuleMatiere");
            });

            modelBuilder.Entity<MatiereEtudiant>(entity =>
            {
                entity.HasKey(e => e.IdCoursEtudiant)
                    .HasName("PK_CoursEtudiant");

                entity.Property(e => e.IdCoursEtudiant).HasColumnName("ID_CoursEtudiant");

                entity.Property(e => e.IdEtudiant).HasColumnName("ID_Etudiant");

                entity.Property(e => e.IdMatiere).HasColumnName("ID_Matiere");

                entity.HasOne(d => d.IdEtudiantNavigation)
                    .WithMany(p => p.MatiereEtudiant)
                    .HasForeignKey(d => d.IdEtudiant)
                    .HasConstraintName("FK_MatiereEtudiant_Etudiant");

                entity.HasOne(d => d.IdMatiereNavigation)
                    .WithMany(p => p.MatiereEtudiant)
                    .HasForeignKey(d => d.IdMatiere)
                    .HasConstraintName("MatiereEtudiant_Matiere");
            });

            modelBuilder.Entity<ModePaiement>(entity =>
            {
                entity.HasKey(e => e.IdModePaiement);

                entity.Property(e => e.IdModePaiement).HasColumnName("ID_ModePaiement");

                entity.Property(e => e.NomModePaiement)
                    .HasColumnName("Nom_ModePaiement")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasKey(e => e.IdModule);

                entity.Property(e => e.IdModule).HasColumnName("ID_Module");

                entity.Property(e => e.NomModule)
                    .HasColumnName("Nom_Module")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => e.IdNote);

                entity.Property(e => e.IdNote).HasColumnName("ID_Note");

                entity.Property(e => e.IdAnneeScolaire).HasColumnName("ID_AnneeScolaire");

                entity.Property(e => e.IdEtudiant).HasColumnName("ID_Etudiant");

                entity.Property(e => e.IdMatiere).HasColumnName("ID_Matiere");
            });

            modelBuilder.Entity<Paiement>(entity =>
            {
                entity.HasKey(e => e.IdPaiement);

                entity.Property(e => e.IdPaiement).HasColumnName("ID_Paiement");

                entity.Property(e => e.DatePaiement)
                    .HasColumnName("Date_Paiement")
                    .HasColumnType("date");

                entity.Property(e => e.IdInscription).HasColumnName("ID_Inscription");

                entity.Property(e => e.IdModePaiement).HasColumnName("ID_ModePaiement");

                entity.HasOne(d => d.IdInscriptionNavigation)
                    .WithMany(p => p.Paiement)
                    .HasForeignKey(d => d.IdInscription)
                    .HasConstraintName("InscriptionPaiement");

                entity.HasOne(d => d.IdModePaiementNavigation)
                    .WithMany(p => p.Paiement)
                    .HasForeignKey(d => d.IdModePaiement)
                    .HasConstraintName("ModePaiementPaiement");
            });

            modelBuilder.Entity<Personne>(entity =>
            {
                entity.HasKey(e => e.IdPersonne)
                    .HasName("PK__Personne__11988C362E719AAA");

                entity.Property(e => e.IdPersonne).HasColumnName("ID_Personne");

                entity.Property(e => e.Cin)
                    .IsRequired()
                    .HasColumnName("CIN")
                    .HasMaxLength(50);

                entity.Property(e => e.DateNaissance)
                    .HasColumnName("Date_Naissance")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Gsm)
                    .HasColumnName("GSM")
                    .HasMaxLength(50);

                entity.Property(e => e.Nationalité).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Prénom).HasMaxLength(50);

                entity.Property(e => e.Sexe)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Téléphone).HasMaxLength(50);
            });

            modelBuilder.Entity<Profession>(entity =>
            {
                entity.HasKey(e => e.IdProfession)
                    .HasName("PK__Professi__9AA7A320BBCCE709");

                entity.Property(e => e.IdProfession).HasColumnName("ID_Profession");

                entity.Property(e => e.NomProfession)
                    .HasColumnName("Nom_Profession")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
