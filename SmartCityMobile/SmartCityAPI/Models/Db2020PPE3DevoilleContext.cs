using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartCityApi.Models
{
    public partial class Db2020PPE3DevoilleContext : DbContext
    {
        public Db2020PPE3DevoilleContext()
        {
        }

        public Db2020PPE3DevoilleContext(DbContextOptions<Db2020PPE3DevoilleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Appartenir> Appartenirs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Jeu> Jeus { get; set; }
        public virtual DbSet<Jouer> Jouers { get; set; }
        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<Organisateur> Organisateurs { get; set; }
        public virtual DbSet<ParcoursEquipe> ParcoursEquipes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Reponse> Reponses { get; set; }
        public virtual DbSet<ReponseJoueur> ReponseJoueurs { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
        public virtual DbSet<Steproutereport> Steproutereports { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Taggedreport> Taggedreports { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Goodie> Goodies { get; set; }
        public virtual DbSet<EquipeGoodie> EquipeGoodies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=srvantonine4.database.windows.net,1433;Initial Catalog=E4Antonin;Persist Security Info=True;User ID=antoninE4;Password=Azerty@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Administrateur>(entity =>
            {
                entity.ToTable("ADMINISTRATEUR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Login).HasColumnName("LOGIN");

                entity.Property(e => e.Nom).HasColumnName("NOM");

                entity.Property(e => e.Password).HasColumnName("PASSWORD");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Prenom).HasColumnName("PRENOM");
            });

            modelBuilder.Entity<Appartenir>(entity =>
            {
                entity.HasKey(e => new { e.IdEquipe, e.IdJoueur });

                entity.ToTable("APPARTENIR");

                entity.Property(e => e.IdEquipe).HasColumnName("ID_EQUIPE");

                entity.Property(e => e.IdJoueur).HasColumnName("ID_JOUEUR");

                entity.HasOne(d => d.Equipe)
                    .WithMany(p => p.Appartenirs)
                    .HasForeignKey(d => d.IdEquipe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPARTENIR_EQUIPE");

                entity.HasOne(d => d.Joueur)
                    .WithMany(p => p.Appartenirs)
                    .HasForeignKey(d => d.IdJoueur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPARTENIR_JOUEUR");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("CONTACT");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Equipe>(entity =>
            {
                entity.ToTable("EQUIPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdCapitaine).HasColumnName("ID_CAPITAINE");

                entity.Property(e => e.IdCreator).HasColumnName("ID_CREATOR");

                entity.Property(e => e.Image).HasColumnName("IMAGE");

                entity.Property(e => e.Nom)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("NOM")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Organisateur)
                    .WithMany(p => p.Equipes)
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("FK_EQUIPE_ORGANISATEUR");

            });

            modelBuilder.Entity<Jeu>(entity =>
            {
                entity.ToTable("JEU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datecreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATECREATION");

                entity.Property(e => e.IdRoute).HasColumnName("ID_ROUTE");

                entity.Property(e => e.Scorefinal).HasColumnName("SCOREFINAL");

                entity.Property(e => e.Tempsfinal)
                    .HasColumnType("datetime")
                    .HasColumnName("TEMPSFINAL");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Jeus)
                    .HasForeignKey(d => d.IdRoute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JEUX_ROUTE");
            });

            modelBuilder.Entity<Jouer>(entity =>
            {
                entity.HasKey(e => new { e.IdJeux, e.IdEquipe });

                entity.ToTable("JOUER");

                entity.Property(e => e.IdJeux).HasColumnName("ID_JEUX");

                entity.Property(e => e.IdEquipe).HasColumnName("ID_EQUIPE");

                entity.Property(e => e.Datedebut)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEDEBUT");

                entity.Property(e => e.Datefin)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEFIN");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.HasOne(d => d.Equipe)
                    .WithMany(p => p.Jouers)
                    .HasForeignKey(d => d.IdEquipe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JOUER_EQUIPE");

                entity.HasOne(d => d.Jeux)
                    .WithMany(p => p.Jouers)
                    .HasForeignKey(d => d.IdJeux)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JOUER_JEU");
            });

            modelBuilder.Entity<Joueur>(entity =>
            {
                entity.ToTable("JOUEUR");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Nom).HasColumnName("NOM");

                entity.Property(e => e.Password).HasColumnName("PASSWORD");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Prenom).HasColumnName("PRENOM");

                entity.Property(e => e.Username).HasColumnName("USERNAME");

                entity.HasOne(d => d.Contact)
                    .WithOne(p => p.Joueur)
                    .HasForeignKey<Joueur>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JOUEUR_CONTACT");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("MESSAGE");

                entity.Property(e => e.IdEmetteur).HasColumnName("ID_EMETTEUR");

                entity.Property(e => e.IdRecepteur).HasColumnName("ID_RECEPTEUR");

                entity.HasOne(d => d.Emetteur)
                    .WithMany(p => p.MessageEmetteur)
                    .HasForeignKey(d => d.IdEmetteur)
                    .HasConstraintName("FK_MESSAGE_CONTACT");

                entity.HasOne(d => d.Recepteur)
                    .WithMany(p => p.MessageRecepteur)
                    .HasForeignKey(d => d.IdRecepteur)
                    .HasConstraintName("FK_MESSAGE_CONTACT1");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("MISSION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.Property(e => e.Time).HasColumnName("TIME");
            });

            modelBuilder.Entity<Organisateur>(entity =>
            {
                entity.ToTable("ORGANISATEUR");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Login).HasColumnName("LOGIN");

                entity.Property(e => e.Nom).HasColumnName("NOM");

                entity.Property(e => e.Password).HasColumnName("PASSWORD");

                entity.Property(e => e.Picture).HasColumnName("PICTURE");

                entity.Property(e => e.Prenom).HasColumnName("PRENOM");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Organisateur)
                    .HasForeignKey<Organisateur>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORGANISATEUR_CONTACT");
            });

            modelBuilder.Entity<ParcoursEquipe>(entity =>
            {
                entity.HasKey(e => new { e.IdJeu, e.IdEquipe, e.Ordre });

                entity.ToTable("PARCOURS_EQUIPE");

                entity.Property(e => e.IdJeu).HasColumnName("ID_JEU");

                entity.Property(e => e.IdEquipe).HasColumnName("ID_EQUIPE");

                entity.Property(e => e.Ordre).HasColumnName("ORDRE");

                entity.Property(e => e.Datevalidation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEVALIDATION");

                entity.Property(e => e.IdRoute).HasColumnName("ID_ROUTE");

                entity.Property(e => e.IdStep).HasColumnName("ID_STEP");

                entity.HasOne(d => d.Jouer)
                    .WithMany(p => p.ParcoursEquipes)
                    .HasForeignKey(d => new { d.IdJeu, d.IdEquipe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PARCOURS_EQUIPE_JOUER");

                entity.HasOne(d => d.Steproutereport)
                    .WithMany(p => p.ParcoursEquipes)
                    .HasForeignKey(d => new { d.IdRoute, d.IdStep })
                    .HasConstraintName("FK_PARCOURS_EQUIPE_STEPROUTEREPORT");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("QUESTION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdBonneReponse).HasColumnName("ID_BONNE_REPONSE");

                entity.Property(e => e.IdMission).HasColumnName("ID_MISSION");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.Property(e => e.Intitule).HasColumnName("INTITULE");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.HasOne(d => d.BonneReponse)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.IdBonneReponse)
                    .HasConstraintName("FK_QUESTION_REPONSE");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.IdMission)
                    .HasConstraintName("FK_QUESTION_MISSION");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.IdType)
                    .HasConstraintName("FK_QUESTION_TYPE");
            });

            modelBuilder.Entity<Reponse>(entity =>
            {
                entity.ToTable("REPONSE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdQuestion).HasColumnName("ID_QUESTION");

                entity.Property(e => e.Intitule).HasColumnName("INTITULE");

                entity.Property(e => e.Photo).HasColumnName("PHOTO");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Reponses)
                    .HasForeignKey(d => d.IdQuestion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_QUESTION");
            });

            modelBuilder.Entity<ReponseJoueur>(entity =>
            {
                entity.HasKey(e => new { e.IdJoueur, e.IdEquipe, e.IdJeu, e.IdMission, e.IdQuestion });

                entity.ToTable("REPONSE_JOUEUR");

                entity.Property(e => e.IdJoueur).HasColumnName("ID_JOUEUR");

                entity.Property(e => e.IdEquipe).HasColumnName("ID_EQUIPE");

                entity.Property(e => e.IdJeu).HasColumnName("ID_JEU");

                entity.Property(e => e.IdMission).HasColumnName("ID_MISSION");

                entity.Property(e => e.IdQuestion).HasColumnName("ID_QUESTION");

                entity.Property(e => e.Bonne).HasColumnName("BONNE");

                entity.Property(e => e.Date).HasColumnName("DATE");

                entity.Property(e => e.IdReponse).HasColumnName("ID_REPONSE");

                entity.Property(e => e.Lat).HasColumnName("LAT");

                entity.Property(e => e.Lng).HasColumnName("LNG");

                entity.Property(e => e.Text).HasColumnName("TEXT");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.Equipe)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdEquipe)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_JOUEUR_EQUIPE");

                entity.HasOne(d => d.Jeu)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdJeu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_JOUEUR_JEU");

                entity.HasOne(d => d.Joueur)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdJoueur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_JOUEUR_JOUEUR");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdMission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_JOUEUR_MISSION");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdQuestion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPONSE_JOUEUR_QUESTION");

                entity.HasOne(d => d.Reponse)
                    .WithMany(p => p.ReponseJoueurs)
                    .HasForeignKey(d => d.IdReponse)
                    .HasConstraintName("FK_REPONSE_JOUEUR_REPONSE");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("ROUTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATIONDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Distance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISTANCE");

                entity.Property(e => e.Handicap).HasColumnName("HANDICAP");

                entity.Property(e => e.IdCreator).HasColumnName("ID_CREATOR");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Organisateur)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("FK_ROUTE_ORGANISATEUR");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.ToTable("STEP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Coordgps).HasColumnName("COORDGPS");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.Missionid).HasColumnName("MISSIONID");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Validation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VALIDATION");

                entity.HasOne(d => d.Mission)
                    .WithMany(p => p.Steps)
                    .HasForeignKey(d => d.Missionid)
                    .HasConstraintName("FK_STEP_MISSION");
            });

            modelBuilder.Entity<Steproutereport>(entity =>
            {
                entity.HasKey(e => new { e.Idroute, e.Idstep });

                entity.ToTable("STEPROUTEREPORT");

                entity.Property(e => e.Idroute).HasColumnName("IDROUTE");

                entity.Property(e => e.Idstep).HasColumnName("IDSTEP");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Steproutereports)
                    .HasForeignKey(d => d.Idroute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STEPROUTEREPORT_ROUTE");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.Steproutereports)
                    .HasForeignKey(d => d.Idstep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STEPROUTEREPORT_STEP");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("TAG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("NAME")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Taggedreport>(entity =>
            {
                entity.HasKey(e => new { e.Tagid, e.Stepid });

                entity.ToTable("TAGGEDREPORT");

                entity.Property(e => e.Tagid).HasColumnName("TAGID");

                entity.Property(e => e.Stepid).HasColumnName("STEPID");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.Taggedreports)
                    .HasForeignKey(d => d.Stepid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TAGGEDREPORT_STEP");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Taggedreports)
                    .HasForeignKey(d => d.Tagid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TAGGEDREPORT_TAG");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("TYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Goodie>(entity =>
            {
                entity.ToTable("GOODIE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Points).HasColumnName("POINTS");
            });

            modelBuilder.Entity<EquipeGoodie>(entity =>
            {
                entity.HasKey(e => new { e.IdEquipe, e.IdGoodies, e.DateObtention });

                entity.ToTable("EQUIPE_GOODIE");

                entity.Property(e => e.IdEquipe).HasColumnName("ID_EQUIPE");

                entity.Property(e => e.IdGoodies).HasColumnName("ID_GOODIES");

                entity.Property(e => e.DateObtention)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEOBTENTION");

                //entity.HasOne(d => d.Equipe)
                //    .WithMany(p => p.Appartenirs)
                //    .HasForeignKey(d => d.IdEquipe)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_APPARTENIR_EQUIPE");

                //entity.HasOne(d => d.Joueur)
                //    .WithMany(p => p.Appartenirs)
                //    .HasForeignKey(d => d.IdJoueur)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_APPARTENIR_JOUEUR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
