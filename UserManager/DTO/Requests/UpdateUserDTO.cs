﻿namespace UserManager.DTO.Requests;

public class UpdateUserDTO
{ 
    public string Login { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}