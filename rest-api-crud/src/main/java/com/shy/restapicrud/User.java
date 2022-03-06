package com.shy.restapicrud;

import javax.persistence.Entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class User {
	
	String Cpf;
	String Name;
	String BirthDate;
	String Email;
	String Password;
}
