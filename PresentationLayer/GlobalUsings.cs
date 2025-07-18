global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using BusinessLogicLayer.IServices;
global using BusinessLogicLayer.Services;
global using BusinessLogicLayer.DTOs.AccountDTOs;
global using BusinessLogicLayer.DTOs.JournalEntryHeaderDTOs;
global using BusinessLogicLayer.DTOs.JournalEntryDetailsDTOs;
global using BusinessLogicLayer.DTOs.ResponseDTOs;
global using BusinessLogicLayer.MappingConfig;
global using DataAccessLayer.Entities;
global using DataAccessLayer.IRepos;
global using DataAccessLayer.Repos;
global using DataAccessLayer.UnitOfWorks;