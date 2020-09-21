// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerController.h"
#include "PC_Gameplay.generated.h"

UCLASS()
class STEAMAS_API APC_Gameplay : public APlayerController
{
	GENERATED_BODY()

public:

	UFUNCTION(Server, Reliable, BlueprintCallable)
		void ServerRecieveCharacterClass(UClass* SelectedCharacterClass);

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UClass* CharacterClass = nullptr;
};
