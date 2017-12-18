using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }
        public abstract PhoneDisplay Display { get; }
        public abstract Keyboard Keyboard { get; }
        public abstract Battery Battery { get; }
        public abstract SimCard SimCard { get; }
        public abstract OperatingSystem OperatingSystem { get; }
        public abstract Camera Camera { get; }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        public string Description()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type:\n{Screen.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Display Parameters:\n{Display.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Keyboard parmeters:\n{Keyboard.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Battery parameters:\n{Battery.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"SimCard parameters:\n{SimCard.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Operating system parameters:\n{OperatingSystem.ToString()}");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Camera parameters:\n{Camera.ToString()}");
            return descriptionBuilder.ToString();
        }

    }
}
