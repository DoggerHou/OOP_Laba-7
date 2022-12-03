namespace OOP_Laba_7
{
    public abstract class ModelFactory //Абстрактная фабрика
    {
        public virtual Model CreateObject(string code) {return null;}
    }


    public class MyObjectsFactory : ModelFactory
    {
        public override Model CreateObject(string code)
        {
            Model temp = null;
            switch (code)
            {
                case "Circle":
                    temp = new CCircle();
                    break;
                case "Square":
                    temp = new CSquare();
                    break;
                case "Triangle":
                    temp = new Triangle();
                    break;
                case "Group":
                    temp = new Group();
                    break;
            }
            return temp;
        }
    }
}

   