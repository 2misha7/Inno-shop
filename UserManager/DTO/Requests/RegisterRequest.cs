﻿namespace UserManager.DTO.Requests;

public class RegisterRequest
{
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}