using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBeta.Etudiant
{
  class EtudiantModel
    {
        public int id;
        public string CNE;
        public String nomEtudiant;
        public String prenomEtudiant;
        public String sexeEtudiant;
        public string DOBEtudiant;
        public String adresseEtudiant;
        public string teleEtudiant;
        public int id_filiere;
        public EtudiantModel(int id,string CNE, String nomEtudiant, String prenomEtudiant, String sexeEtudiant, string DOBEtudiant, String adresseEtudiant, String teleEtudiant, int id_filiere)
        {
            this.CNE = CNE;
            this.id = id;
            this.nomEtudiant = nomEtudiant;
            this.prenomEtudiant = prenomEtudiant;
            this.sexeEtudiant = sexeEtudiant;
            this.DOBEtudiant = DOBEtudiant;
            this.adresseEtudiant = adresseEtudiant;
            this.teleEtudiant = teleEtudiant;
            this.id_filiere = id_filiere;

        }
        public EtudiantModel( string CNE, String nomEtudiant, String prenomEtudiant, String sexeEtudiant, string DOBEtudiant, String adresseEtudiant, String teleEtudiant, int id_filiere)
        {
            this.CNE = CNE;
          
            this.nomEtudiant = nomEtudiant;
            this.prenomEtudiant = prenomEtudiant;
            this.sexeEtudiant = sexeEtudiant;
            this.DOBEtudiant = DOBEtudiant;
            this.adresseEtudiant = adresseEtudiant;
            this.teleEtudiant = teleEtudiant;
            this.id_filiere = id_filiere;

        }



    }
}
