// Fill out your copyright notice in the Description page of Project Settings.


#include "PC_Gameplay.h"


void APC_Gameplay::ServerRecieveCharacterClass_Implementation(TSubclassOf<AGameplayCharacterBase> SelectedCharacterClass)
{
	this->CharacterClass = SelectedCharacterClass;
}