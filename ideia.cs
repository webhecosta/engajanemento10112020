using System;

class Ideia {
	
  public User dono;
  public string descricao;
  public string areaAplicacao;
  public int tVotos;

public Ideia(){

}

  public Ideia (User u, string d, string a, int v){
    dono = u;
    descricao = d;
    areaAplicacao = a;
    tVotos = v;
  }



}