namespace ExamploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int setMes()
        {
            return this.mes;
        }
        public void setMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public int Mes
        { 
             get
              {
                 return this.mes;
              } 
            
            set
             {
                 if (value > 0 && value <= 12)
                 {
                     this.mes = value;
                     this.mesValido = true;
                 }
         
             } 
         }
        public void apresentarMes()
        {
            if (mesValido == true)
            {
                System.Console.WriteLine(mes);
            }else
            {
                System.Console.WriteLine("Mês Inválido");
            }
        }
    }
}