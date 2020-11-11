using System;
using System.Collections.Generic; 

class Votar {

 	public List<Ideia> portfolio;

  public Votar(){
	
    portfolio = new List<Ideia>();

  }

  public void AdicionarIdeia(Ideia i){
    portfolio.Add(i);
  }

  public Ideia Vencedora(){
     //logica de maior ideia 
      Ideia maior_likes = portfolio[0];
      for (int i=0;i<portfolio.Count;i++){
        if (portfolio[i].tVotos > maior_likes.tVotos){
          maior_likes = portfolio[i];
        }
      }
    return maior_likes;
  } 

}