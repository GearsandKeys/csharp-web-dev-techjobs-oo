﻿using System;
using System.Linq.Expressions;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            try
            {
                if (String.IsNullOrEmpty(Name))
                {
                    Name = "Data not avaliable";
                }

                return $"\nID: {Id} \nName: {Name} \nEmployer: {EmployerName.ToString()} " +
                    $"\nLocation: {EmployerLocation.ToString()} \nPosition Type: {JobType.ToString()} " +
                    $"\nCore Competency: {JobCoreCompetency.ToString()} \n";
            }
            catch(NullReferenceException)
            {
                return "OOPS! This job does not seem to exist.";
            }
        }
    }

}
