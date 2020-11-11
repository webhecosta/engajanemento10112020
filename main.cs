using System;
using System.Collections.Generic; 

class MainClass {
  public static void Main (string[] args) {
    //INSTANCIAR CLASSE VOTAR
    Votar campanha = new Votar();
		// USUÁRIO
		List < User > listUser;
		listUser = new List < User > (); 
		//IDEIA
		List<Ideia> listIdeia;
		listIdeia	 = new List < Ideia > (); 

		//DECLRAÇÃO DE VARIÁVEL
		int opcao ;
    int idx=0;
		string opc="n";
    do {				
					Console.WriteLine("1-CRIAR USUÁRIO");
					Console.WriteLine("2-CRIAR IDEIA");
					Console.WriteLine("3-VISUALIZAR IDEIAS E VOTAR");
					Console.WriteLine("4-VISUALIZAR VENCEDOR");
					Console.WriteLine("0-SAIR");
					opcao = int.Parse(Console.ReadLine());

					switch(opcao){
					
					//MENU CRIAR USUARIO
						//ATRIBUTOS DO USUARIO - INSTANCIAR
						case 1:

							Console.WriteLine("NOME"); 	
							string nome = Console.ReadLine();					
					
							User usr = new User(nome); 
							listUser.Add(usr); // ADICIONAR O NOME NA LISTA
						 Console.Clear(); 	
					//########################TESTE#############################

							foreach(User c in listUser) {
								Console.WriteLine("NOME: {0}", c.nome);			
						}
					//########################TESTE#############################		

					break;
				
				//MENU CRIAR IDEIA
				//ATT. IDEIA - INSTANCIAR
						case 2:

							Console.WriteLine("USUÁRIOS:");	
							idx=0;
							foreach(User c in listUser) {
								Console.WriteLine("OPC {0} : {1}",idx+1 ,c.nome);	
								idx++;
							}
							
							Console.WriteLine("ESCOLHA O USUÁRIO"); 
							idx = int.Parse(Console.ReadLine());
              idx--;
								Console.WriteLine("VOCÊ ESCOLHEU O USUÁRIO : {0}",listUser[idx].nome);
										
							Console.WriteLine("DIGITE A SUA IDEIA"); 	
							string desc = Console.ReadLine();	

							Console.WriteLine("QUAL A AREA DE ATUAL DA IDEIA"); 	
							string area = Console.ReadLine();	

						//	Console.WriteLine("VOTOS"); 	
						//	int tvotos = int.Parse(Console.ReadLine());					
					
							Ideia ide = new Ideia(listUser[idx],desc,area,0); 
							listIdeia.Add(ide); // ADICIONAR O NOME NA LISTA
				    	Console.Clear(); 	
					//########################TESTE#############################
             	 idx=0;
							foreach(Ideia c in listIdeia) {
								Console.WriteLine(" OPC {0} NOME: {1} IDEIA: {2}\nAREA: {3}\nVOTOS: {4}",idx+1, c.dono.nome,c.descricao,c.areaAplicacao,c.tVotos);
								Console.WriteLine("");
								idx++;			
						}
						idx--;
					//########################TESTE#############################	

							break;

					
				//MENU VOTAR
				//VISUALIZAR AS IDEIAS NA LISTA e PERMITIR LIKE
						case 3:
						
						 do{
							  idx=0;
							  opc="n";

							Console.WriteLine("OPC [0] NÃO QUERO VOTAR.");
							Console.WriteLine("");
							foreach(Ideia c in listIdeia) {
								Console.WriteLine("OPC [{0}] IDEIA: {2} AREA: {3} VOTOS: {4}",idx+1, c.dono.nome,c.descricao,c.areaAplicacao,c.tVotos);
									Console.WriteLine("");
								idx++;			
						}
					
            	Console.WriteLine("VOTE NA IDEIA, ESCOLHA A OPÇÃO"); 
							idx = int.Parse(Console.ReadLine());            

							if (idx==0){
                  Console.WriteLine("SAIR DA VOTAÇÃO? S ou N");
								opc = Console.ReadLine();

								if (opc=="S" || opc=="s"){
							  	opc ="N";
							 }

							}
							else{
								 idx--;
								Console.WriteLine("VOCÊ ESCOLHEU A IDEIA {0} ",listIdeia[idx].descricao);
								Console.WriteLine("CONFIRMA SEU VOTO? S ou N");
								opc = Console.ReadLine();
               if (opc=="S" || opc=="s"){
								 listIdeia[idx].tVotos++;
								Console.WriteLine("VOTO COMPUTADO.");
								opc ="N";
							 }
							 else
							   {
									 	opc ="S";
								 }
							}
						 }while(opc!="N" && opc!="n");
							break;
				//MENU DEFINIR VENCEDOR
				//CHAMAR VENCEDORA()
						case 4:
						Votar votar = new Votar();

						votar.portfolio=listIdeia;
					  	Ideia c1 = votar.Vencedora();
							Console.WriteLine("NOME: {0}\nIDEIA: {1}\nAREA {2}\nVOTOS: {3}", c1.dono.nome,c1.descricao,c1.areaAplicacao,c1.tVotos);		
						
							break;	

					} //FIM SWITCH case

		}while(opcao != 0 ); //FIM DO WHILE
		

  


  }
}