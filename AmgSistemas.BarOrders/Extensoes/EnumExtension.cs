using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Extensoes
{
    public static class EnumExtension
    {

        public static string RecuperarValor(this System.Enum e)
        {
            Type tipoEnum = e.GetType();
            System.Reflection.FieldInfo field = tipoEnum.GetField(System.Enum.GetName(tipoEnum, e));
            if (field != null)
            {
                Classes.ValorEnum atributo = (Classes.ValorEnum)Attribute.GetCustomAttribute(field, typeof(Classes.ValorEnum));
                if (atributo != null)
                {
                    return atributo.Valor;
                }
                throw new NotImplementedException(tipoEnum.ToString() + "." + field.Name);
            }
            return null;
        }

        public static TEnum RecuperarEnum<TEnum>(string valor)
        {
            Type tipoEnum = typeof(TEnum);
            if (!tipoEnum.IsEnum)
            {
                throw new ArgumentException("TEnum", "TEnum");
            }
            System.Reflection.FieldInfo[] fields = tipoEnum.GetFields();
            if (fields != null)
            {
                Classes.ValorEnum atributo = default(Classes.ValorEnum);
                foreach (System.Reflection.FieldInfo field in fields)
                {
                    atributo = (Classes.ValorEnum)Attribute.GetCustomAttribute(field, typeof(Classes.ValorEnum));
                    if (atributo != null)
                    {
                        if (atributo.Valor == valor)
                        {
                            return (TEnum)System.Enum.Parse(typeof(TEnum), field.Name);
                        }
                    }
                }

                return RecuperarEnum<TEnum>("NAO-RECONHECIDO");

            }
            throw new NotImplementedException(valor);
        }

    }
}
