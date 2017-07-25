// Fill out your copyright notice in the Description page of Project Settings.

#include "Breakout.h"
#include "UserBar.h"


// Sets default values
AUserBar::AUserBar()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AUserBar::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AUserBar::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AUserBar::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

