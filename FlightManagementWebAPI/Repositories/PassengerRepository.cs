using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class PassengerRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public PassengerRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public List<Passenger> GetPassengers(int flightId)
        {
            return _airportSystemContext.Passengers.Include(passenger => passenger.Flight).Where(passenger => passenger.FlightId == flightId).ToList();
        }
        public void InsertPassenger(Passenger passenger)
        {
            _airportSystemContext.Passengers.Add(passenger);
            _airportSystemContext.SaveChanges();
        }
        public Passenger GetPassenger(int passengerId)
        {
            return _airportSystemContext.Passengers
                .FirstOrDefault(passenger => passenger.Id == passengerId);
        }
        public Passenger GetPassenger(int passengerId, bool check)
        {
            return _airportSystemContext.Passengers
                .FirstOrDefault(passenger => passenger.Id == passengerId);
        }
        public void UpdatePassenger(Passenger passenger)
        {
            var passengerForUpdate = GetPassenger(passenger.Id);
            if (passengerForUpdate != null)
            {
                passengerForUpdate.Name = passenger.Name;
                passengerForUpdate.LastName = passenger.LastName;
                passengerForUpdate.Gender = passenger.Gender;
                passengerForUpdate.SeatNumber = passenger.SeatNumber;
                passengerForUpdate.IsChecked = passenger.IsChecked;
                passengerForUpdate.NumberLuggage = passenger.NumberLuggage;
                passengerForUpdate.LuggageWeight = passenger.LuggageWeight;
               
                _airportSystemContext.SaveChanges();
            }
        }
        public void DeletePassenger(int passengerId)
        {
            var passengerForDelete = GetPassenger(passengerId);
            if (passengerForDelete != null)
            {
                _airportSystemContext.Passengers.Remove(passengerForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
        public void CheckPassenger(Passenger passenger)
        {
            var passengerUpdate = GetPassenger(passenger.Id);
            if (passengerUpdate != null)
            {
                passengerUpdate.IsChecked = true;
                passengerUpdate.SeatNumber = passenger.SeatNumber;
                _airportSystemContext.SaveChanges();
            }
        }
    }
}
