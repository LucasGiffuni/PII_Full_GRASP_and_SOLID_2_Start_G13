using System;
using Full_GRASP_And_SOLID.Library;


//Agregamos la clase ConsolePrinter para cumplir con el patron srp y el expert
//Con el expert nos encargamos de que el consolePrinter conozca la receta a imprimir y imprima esta misma.

//La clase consolePrinter tiene la responsabilidad sobre una receta, conoce todo sobre ella y tiene la
//responsabilidad de imprimir esta. 
public class ConsolePrinter{

    public Recipe recipe;
    public ConsolePrinter(Recipe recipe){
        this.recipe = recipe;
    }


    public void printRecipe(){
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in this.recipe.Steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
    }

}