// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/Pawn.h"
#include "UserBar.generated.h"

UCLASS()
class BREAKOUT_API AUserBar : public APawn
{
	GENERATED_BODY()

public:
	// Sets default values for this pawn's properties
	AUserBar();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// Called to bind functionality to input
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;

    class USlidingMovementComponent* OurMovementComponent;
    
    virtual UPawnMovementComponent* GetMovementComponent() const override;
	
	void MoveRight(float AxisValue);
};
