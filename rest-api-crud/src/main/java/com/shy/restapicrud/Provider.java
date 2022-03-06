package com.shy.restapicrud;

import javax.persistence.Entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@AllArgsConstructor
@NoArgsConstructor
public class Provider {
	
	String Cnpj;
	String Name;
	String RegisterDate;
}
