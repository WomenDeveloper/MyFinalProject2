using System;
using System.Runtime.Serialization;
using Core.Entities.Concreate;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Added a product";
        public static string ProductNameInvalid = "The product name is invalid";
        public static string ProductListed = "The product name is invalid";
        public static string MaintenanceTime = "System is under Maintenance";
        public static string ProductCountOfCategoryError = "maximum number of product in category is 15";
        public static string ProductNameAlreadyExits = "Product name already exits";
        public static string CategoryLimitexceed ="Category Limit exceed";
        public static string AuthorizationDenied="Authorization denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound ="User not found";
        public static string PasswordError= "password is invalid";
        public static string SuccessfulLogin = "successful login";
        public static string UserAlreadyExists = "User already exits";
        public static string AccessTokenCreated = "Access token created";
    }
}

