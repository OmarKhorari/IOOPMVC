using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOOPMVC.Business;
using IOOPMVC.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using IOOPMVC.Domain;
using IOOPMVC.Models;
using IOOPMVC.Repository.DataBase;
using IOOPMVC.Business.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace IOOPMVC.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {

        private IGenericRepository<Etudiant> _etudiantRepository;
        private IGenericRepository<Personne> _personneRepository;
        public StudentController(IGenericRepository<Etudiant> etudiantRepository, IGenericRepository<Personne> personneRepository)
        {
            _etudiantRepository = etudiantRepository;
            _personneRepository = personneRepository;
        }
        public IActionResult Index()
        {
            var modelEtudiant = _etudiantRepository.GetByID(1);
            var modelPersonne = _personneRepository.GetByID(modelEtudiant.IdPersonne);
            EtudiantViewModel ietudListViewModel = new EtudiantViewModel();
            ietudListViewModel.personneViewModel = new PersonneViewModel();
            ietudListViewModel.IdEtudiant = modelEtudiant.IdEtudiant;
            ietudListViewModel.Matricule = modelEtudiant.Matricule;
            ietudListViewModel.NomPère = modelEtudiant.NomPère;
            ietudListViewModel.NomMère = modelEtudiant.NomMère;
            ietudListViewModel.personneViewModel.Nom = modelPersonne.Nom;
            ietudListViewModel.personneViewModel.Prénom = modelPersonne.Prénom;
            ietudListViewModel.personneViewModel.Sexe = modelPersonne.Sexe;
            ietudListViewModel.personneViewModel.Cin = modelPersonne.Cin;
            ietudListViewModel.personneViewModel.DateNaissance = modelPersonne.DateNaissance;
            ietudListViewModel.personneViewModel.Nationalité = modelPersonne.Nationalité;
            ietudListViewModel.personneViewModel.Email = modelPersonne.Email;
            ietudListViewModel.personneViewModel.Gsm = modelPersonne.Gsm;
            return View(ietudListViewModel);
        }

        public ViewResult GetAllStudents()
        {
            //List<Etudiant> ietuddList = _etudiantRepository.GetAll().ToList();
            List<EtudiantViewModel> ietudListViewModel = new List<EtudiantViewModel>();
            foreach (var modelEtudiant in _etudiantRepository.GetAll().ToList())
            {
                EtudiantViewModel evm = new EtudiantViewModel();
                var modelPersonne = _personneRepository.GetByID(modelEtudiant.IdPersonne);
                evm.personneViewModel = new PersonneViewModel();
                evm.Matricule = modelEtudiant.Matricule;
                evm.NomPère = modelEtudiant.NomPère;
                evm.NomMère = modelEtudiant.NomMère;
                evm.personneViewModel = new PersonneViewModel();
                evm.personneViewModel.Nom = modelPersonne.Nom;
                evm.personneViewModel.Prénom = modelPersonne.Prénom;
                evm.personneViewModel.Sexe = modelPersonne.Sexe;
                evm.personneViewModel.Cin = modelPersonne.Cin;
                evm.personneViewModel.DateNaissance = modelPersonne.DateNaissance;
                evm.personneViewModel.Nationalité = modelPersonne.Nationalité;
                evm.personneViewModel.Email = modelPersonne.Email;
                evm.personneViewModel.Gsm = modelPersonne.Gsm;
                ietudListViewModel.Add(evm);
            }

            return View(ietudListViewModel);
        }

        public ViewResult GetAllStudent()
        {
            //List<Etudiant> ietuddList = _etudiantRepository.GetAll().ToList();
            List<EtudiantViewModel> ietudListViewModel = new List<EtudiantViewModel>();
            foreach (var modelEtudiant in _etudiantRepository.GetAll().ToList())
            {
                EtudiantViewModel evm = new EtudiantViewModel();
                var modelPersonne = _personneRepository.GetByID(modelEtudiant.IdPersonne);
                evm.personneViewModel = new PersonneViewModel();
                evm.Matricule = modelEtudiant.Matricule;
                evm.NomPère = modelEtudiant.NomPère;
                evm.NomMère = modelEtudiant.NomMère;
                evm.personneViewModel = new PersonneViewModel();
                evm.personneViewModel.Nom = modelPersonne.Nom;
                evm.personneViewModel.Prénom = modelPersonne.Prénom;
                evm.personneViewModel.Sexe = modelPersonne.Sexe;
                evm.personneViewModel.Cin = modelPersonne.Cin;
                evm.personneViewModel.DateNaissance = modelPersonne.DateNaissance;
                evm.personneViewModel.Nationalité = modelPersonne.Nationalité;
                evm.personneViewModel.Email = modelPersonne.Email;
                evm.personneViewModel.Gsm = modelPersonne.Gsm;
                ietudListViewModel.Add(evm);
            }

            return View(ietudListViewModel);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            EtudiantViewModel evm = new EtudiantViewModel();
            return PartialView("_AddStudentPartial", evm);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(EtudiantViewModel etudModel)
        {
            if (ModelState.IsValid)
            {
                Etudiant etd = new Etudiant();
                etd.IdPersonneNavigation = new Personne();
                etd.IdAdresseNavigation = new Adresse();
                etd.IdPersonneNavigation.Nom = etudModel.personneViewModel.Nom;
                etd.IdPersonneNavigation.Prénom = etudModel.personneViewModel.Prénom;
                etd.IdPersonneNavigation.DateNaissance = etudModel.personneViewModel.DateNaissance;
                etd.IdPersonneNavigation.Sexe = etudModel.personneViewModel.Sexe;
                etd.IdPersonneNavigation.Cin = etudModel.personneViewModel.Cin;
                etd.IdPersonneNavigation.Nationalité = etudModel.personneViewModel.Nationalité;
                etd.IdPersonneNavigation.Téléphone = etudModel.personneViewModel.Téléphone;
                etd.IdPersonneNavigation.Gsm = etudModel.personneViewModel.Gsm;
                etd.IdPersonneNavigation.Email = etudModel.personneViewModel.Email;
                etd.IdAdresseNavigation.Adresse1 = etudModel.adresseViewModel.Adresse1;
                etd.IdAdresseNavigation.Cp = etudModel.adresseViewModel.Cp;
                etd.IdAdresseNavigation.Ville = etudModel.adresseViewModel.Ville;
                etd.Matricule = etudModel.Matricule;
                etd.ProfessionPère = etudModel.ProfessionPère;
                etd.ProfessionMère = etudModel.ProfessionMère;
                etd.NomPère = etudModel.NomPère;
                etd.NomMère = etudModel.NomMère;
                etd.NiveauEtudePère = etudModel.NiveauEtudePère;
                etd.NiveauEtudeMère = etudModel.NiveauEtudeMère;
                etd.IdFiliere = 1;
                await _etudiantRepository.AddAsync(etd);
                return View("GetAllStudent");
            }
            else
            {
                return View(etudModel);
            }
            
        }


    }
}
