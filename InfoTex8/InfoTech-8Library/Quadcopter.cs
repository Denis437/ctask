using System;

namespace InfoTech8
{
    public class Quadcopter : AbstractEntity
    {
        private static readonly Random random = new Random();

        private bool flying = true;

        private readonly Operator @operator;

        public Quadcopter(string name) : base(name, 100)
        {
            @operator = new Operator();
            @operator.ProgressEvent += (owner) => {
                RaiseEvent($"Оператор включает пульт: {@operator.Progress}%.");
                if (@operator.Progress == 100)
                {
                    flying = true;
                }
            };
        }

        protected override void Run()
        {
            if (!flying)
            {
                return;
            }

            var roll = random.NextDouble();
            if (roll < 0.0019d)
            {
                flying = false;
                if (roll < 0.00094d)
                {
                    var passenger = Technic.GetRandomTechnic();
                    RaiseEvent($"Сломался GPS, ожидает починки.");
                    passenger.ProgressEvent += (owner) =>
                    {
                        if (owner == this)
                        {
                            flying = true;
                        }
                    };
                    passenger.RequestTechnicRepairing(this);
                } else
                {
                    @operator.RequestOperator();
                }
            }

            if (flying)
            {
                RaiseEvent("Летает.");
                return;
            }
        }
    }
}
