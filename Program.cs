double comprimentoescada, anguloeradiano, anguloemgraus, altura;

   Console.Clear();
   Console.Write("informe o comprimento da escada:   ");
   comprimentoescada = Convert.ToDouble(Console.ReadLine());

   Console.Write("Informe o angulo da escada em graus:   ");
   anguloemgraus = Convert.ToDouble(Console.ReadLine());

   anguloeradiano = anguloemgraus * (Math.PI / 180);

   altura = comprimentoescada * Math.Sin(anguloeradiano);

   Console.WriteLine($"A escada alcanca aproximadamente {altura:N2}");