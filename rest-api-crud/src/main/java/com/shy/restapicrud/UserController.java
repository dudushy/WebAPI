package com.shy.restapicrud;

import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import antlr.collections.List;
import lombok.AllArgsConstructor;

@RestController
@AllArgsConstructor
public class UserController {
	
	UserRepository repository;
	
	@GetMapping("/user")
	public List<User> getAllUsers(){
		return repository.findAll();
	}
	
	@GetMapping("/user/{cpf}")
	public User getUserById(@PathVariable String cpf) {
		return repository.findById(cpf);
	}
	
	@PostMapping("/user")
	public User saveUser(@RequestBody User user) {
		return repository.save(user);
	}
	
	@DeleteMapping("/user/{cpf}")
	public void deleteUser(@PathVariable String cpf) {
		return repository.delete(cpf);
	}
}
