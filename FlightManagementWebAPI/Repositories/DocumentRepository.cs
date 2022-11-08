using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class DocumentRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public DocumentRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public Document GetDocument(int passengerId)
        {
            return _airportSystemContext.Documents
                .FirstOrDefault(document => document.Id == passengerId);
        }
        public void UpdateDocument(Document document)
        {
            var documentUpdate = GetDocument(document.Id);
            if (documentUpdate != null)
            {
                documentUpdate.Name = document.Name;
                documentUpdate.documentType = document.documentType;
                documentUpdate.documentNumber = document.documentNumber;
                documentUpdate.ExpireDate = document.ExpireDate;

                _airportSystemContext.SaveChanges();
            }
        }
        public void AddDocument(Document document)
        {
            _airportSystemContext.Documents.Add(document);
            _airportSystemContext.SaveChanges();
        }
    }
}
