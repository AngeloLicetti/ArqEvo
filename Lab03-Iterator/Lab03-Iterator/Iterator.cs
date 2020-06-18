using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Iterator
{
    class Iterator : AbstractIterator
    {
        protected MiListBox lista;
        private int index = 0;
        private bool mNormal, soloPares, soloImpares;

        public Iterator(MiListBox lista)
        {
            this.lista = lista;
        }

        public void modoNormal()
        {
            mNormal = true;
            soloPares = false;
            soloImpares = false;
        }

        public void modoPar()
        {
            mNormal = false;
            soloPares = true;
            soloImpares = false;
        }

        public void modoImpar()
        {
            mNormal = false;
            soloPares = false;
            soloImpares = true;
        }

        public override Object Top()
        {
            index = 0;
            if (soloPares)
            {
                while (!EsPar(lista.Items[index]))
                {
                    index++;
                    if (index == lista.Items.Count)
                    {
                        return "No hay ningún par";
                    }
                }
            }
            if (soloImpares)
            {
                while (!EsImpar(lista.Items[index]))
                {
                    index++;
                    if (index == lista.Items.Count)
                    {
                        return "No hay ningún impar";
                    }
                }
            }
            return lista.Items[index];
        }

        public override Object Bottom()
        {
            index = lista.Items.Count - 1;
            if (soloPares)
            {
                while (!EsPar(lista.Items[index]))
                {
                    index--;
                    if (index == 0)
                    {
                        return "No hay ningún par";
                    }
                }
            }
            if (soloImpares)
            {
                while (!EsImpar(lista.Items[index]))
                {
                    index--;
                    if (index == 0)
                    {
                        return "No hay ningún impar";
                    }
                }
            }
            return lista.Items[index];
        }

        public override Object Central()
        {
            if (mNormal)
            {
                if (lista.Items.Count % 2 == 0)
                {
                    index = lista.Items.Count / 2 - 1;
                }
                else
                {
                    index = (lista.Items.Count - 1) / 2;
                }
            }
            if (soloPares)
            {
                for (int i = 0, j = lista.Items.Count - 1; i <= j; i++, j--)
                {
                    bool primeraIteracion = i == 0;
                    while (!EsPar(lista.Items[i]))
                    {
                        i++;
                        if (index == lista.Items.Count && primeraIteracion)
                        {
                            return "No hay ningún par";
                        }
                    }

                    while (!EsPar(lista.Items[j]))
                    {
                        j--;
                    }
                    index = i;
                }
            }
            if (soloImpares)
            {
                for (int i = 0, j = lista.Items.Count - 1; i <= j; i++, j--)
                {
                    bool primeraIteracion = i == 0;
                    while (!EsImpar(lista.Items[i]))
                    {
                        i++;
                        if (index == lista.Items.Count && primeraIteracion)
                        {
                            return "No hay ningún imnpar";
                        }
                    }

                    while (!EsImpar(lista.Items[j]))
                    {
                        j--;
                    }
                    index = i;
                }
            }
            return lista.Items[index];
        }

        public override Object Next()
        {
            Object ret = new object();
            if (mNormal)
            {
                index++;
                if (index == lista.Items.Count)
                {
                    index = 0;
                }
                ret = lista.Items[index];
            }
            if (soloPares)
            {
                int indexOriginal = index;
                do
                {
                    index++;
                    if (index == lista.Items.Count)
                    {
                        index = 0;
                    }
                    if (index == indexOriginal)
                    {
                        //no hay ningún elemento par
                        return "No hay ningún par";
                    }
                }
                while (!EsPar(lista.Items[index]));
                ret = lista.Items[index];
            }
            if (soloImpares)
            {
                int indexOriginal = index;
                do
                {
                    index++;
                    if (index == lista.Items.Count)
                    {
                        index = 0;
                    }
                    if (index == indexOriginal)
                    {
                        //no hay ningún elemento impar
                        return "No hay ningún impar";
                    }
                }
                while (!EsImpar(lista.Items[index]));
                ret = lista.Items[index];
            }
            return ret;
        }

        public override Object Previous()
        {
            Object ret = new object();
            if (mNormal)
            {
                index--;
                if (index < 0)
                {
                    index = lista.Items.Count - 1;

                }
                ret = lista.Items[index];
            }
            if (soloPares)
            {
                int indexOriginal = index;
                do
                {
                    index--;
                    if (index < 0)
                    {
                        index = lista.Items.Count - 1;

                    }
                    if (index == indexOriginal)
                    {
                        //no hay ningún elemento par
                        return "No hay ningún par";
                    }
                }
                while (!EsPar(lista.Items[index]));
                ret = lista.Items[index];
            }
            if (soloImpares)
            {
                int indexOriginal = index;
                do
                {
                    index--;
                    if (index < 0)
                    {
                        index = lista.Items.Count - 1;

                    }
                    if (index == indexOriginal)
                    {
                        //no hay ningún elemento impar
                        return "No hay ningún impar";
                    }
                }
                while (!EsImpar(lista.Items[index]));
                ret = lista.Items[index];
            }
            return ret;
        }


        public bool EsPar(Object o)
        {
            bool ret = o.ToString().Length % 2 == 0;
            Console.WriteLine(ret);
            return ret;
        }

        public bool EsImpar(Object o)
        {
            return o.ToString().Length % 2 != 0;
        }

        //public Iterator(MiListBox lista, int modo)
        //{
        //    this.lista = lista;
        //    switch (modo)
        //    {
        //        case 1:
        //            this.lista = filtrarPares(lista);
        //            break;
        //        case 2:
        //            this.lista = filtrarImpares(lista);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public MiListBox filtrarPares(MiListBox lista)
        //{
        //    MiListBox listaPares = new MiListBox();
        //    for(int i=0; i<lista.Items.Count; i++)
        //    {
        //        if (esPar(lista.Items[i]))
        //        {
        //            listaPares.Items.Add(lista.Items[i]);
        //        }
        //    }
        //    return listaPares;
        //}
        //public MiListBox filtrarImpares(MiListBox lista)
        //{
        //    MiListBox listaImpares = new MiListBox();
        //    for (int i = 0; i < lista.Items.Count; i++)
        //    {
        //        if (esImpar(lista.Items[i]))
        //        {
        //            listaImpares.Items.Add(lista.Items[i]);
        //        }
        //    }
        //    return listaImpares;
        //}
    }
}
