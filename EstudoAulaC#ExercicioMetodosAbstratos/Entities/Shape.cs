

using EstudoAulaC_ExercicioMetodosAbstratos.Enums;

namespace EstudoAulaC_ExercicioMetodosAbstratos.Entities
{
    abstract internal class Shape
    {
        public Color color { get; set; }
        public Shape(Color color){
            this.color = color; 
        }
        public abstract double Area();
        
        
    }
}