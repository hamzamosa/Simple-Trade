// See https://aka.ms/new-console-template for more information
using MySimpleProject.EntityFrameWork;
using MySimpleProject.EntityFrameWork.Services;

using MySimpleProject;
using MySimpleTrader.Domain.Services;
using MySimpleTrader.Domain.Models;

IDataServices<User> userServices = new GenericDataService<User>( new DesignTimeDbContextFactory() );
