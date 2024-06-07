global using System.ComponentModel.DataAnnotations.Schema;
global using System.ComponentModel.DataAnnotations;
global using System.Runtime.Serialization;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Crypt = BCrypt.Net.BCrypt;
global using EFCore.BulkExtensions;

// DbContexts
global using Ticket.Domain.DbContexts;

// Enums
global using Ticket.Domain.Enums;

// Entities
global using Ticket.Domain.Entities;

// Extensions
global using Ticket.Domain.Extensions;