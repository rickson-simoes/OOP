namespace ExercicioDois.Polimorfismo
{
    public class Passaros
    {
        public virtual void Som()
        {
            Console.WriteLine("O som do animal é: ");
        }
    }

    public class Papagaio : Passaros
    {
        public override void Som()
        {
            base.Som();
            Console.WriteLine("Papagaio!");
            Console.WriteLine("Disse: Bom dia safado");
        }
    }

    public class BemTeVi : Passaros
    {
        public override void Som()
        {
            base.Som();
            Console.WriteLine("BemTeVi");
            Console.WriteLine("Disse: Bem te vi");
        }

    }
}
