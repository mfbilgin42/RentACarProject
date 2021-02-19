﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDAL _customerDal;

        public CustomerManager(ICustomerDAL customerDal)
        {
            _customerDal = customerDal;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Customer>> GetByCustomerId(int CustomerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CustomerId == CustomerId));
        }

        public IDataResult<List<Customer>> GetByUserId(int UserId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.UserId == UserId));
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}