﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesClubTennis.Acteurs {
    class Membre : Personne, ICompetiteur {
        public int Cotisation {
            get { return MontantCotisation(); }
        }

        public bool ARegleCotisation {
            get => default;
            set {
            }
        }

        public bool EstCompetiteur {
            get => default;
            set {
            }
        }

        public Classement Classement { get; set; }

        public Adresse Adresse {
            get => default;
            set {
            }
        }

        public string NumeroTelephone {
            get => default;
            set {
            }
        }

        public void ModifierNumeroTelephone(string nouveauNumero) {
            throw new System.NotImplementedException();
        }

        public int MontantCotisation()
        {
            int res = 0;
            if(Adresse.CodePostal == 92400)
            {
                if (Enfant) { res+= 130; }
                else { res+= 200; }
            }
            else
            {
                if (Enfant) { res+= 180; }
                else { res+= 280; }
            }
            if (EstCompetiteur)
            {
                res += 20;
            }
            return res;
        }

        public Membre(string nom, string prenom, DateTime dateNaissance, TypeSexe sexe, int age) : base(nom, prenom, dateNaissance, sexe, age)
        {

        }
    }
}
