// See https://aka.ms/new-console-template for more information
using NebulaApi.UsersApi;

var userClass = new UserInfo("e0ea21438427fc6f91a4e41d09f04664db515ce6");
var result = await userClass.GetResponseAsync();
Console.WriteLine(result?.CreatedAt);