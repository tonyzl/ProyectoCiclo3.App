using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{
    public class Estaciones{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string nombre {get;set;}            
        public string direccion {get;set;}            
        public string coord_x {get;set;}            
        public string coord_y {get;set;}            
        public string tipo {get;set;}            
           
    } 
}