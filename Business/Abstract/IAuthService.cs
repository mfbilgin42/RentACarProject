﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
//Muhammet Bilgin


namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult ChangePassword(ChangePasswordDto changePasswordDto);
        IResult ForgotPassword(ForgotPasswordDto forgotPasswordDto);
    }
}
