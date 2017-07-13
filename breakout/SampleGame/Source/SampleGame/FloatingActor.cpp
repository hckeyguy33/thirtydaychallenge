// Fill out your copyright notice in the Description page of Project Settings.

#include "SampleGame.h"
#include "FloatingActor.h"


// Sets default values
AFloatingActor::AFloatingActor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

    TotalDamage = 200;
    DamageTimeInSeconds = 1.f;
    
}

void AFloatingActor::PostInitProperties()
{
    Super::PostInitProperties();
    DamagePerSecond = TotalDamage / DamageTimeInSeconds;
}

// Called when the game starts or when spawned
void AFloatingActor::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AFloatingActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
    
    FVector NewLocation = GetActorLocation();
    float DeltaHeight = (FMath::Sin(RunningTime + DeltaTime) - FMath::Sin(RunningTime));
    NewLocation.Z += DeltaHeight * 20.0f; //Scales the height by factor of 20
    RunningTime += DeltaTime;
    SetActorLocation(NewLocation);
}

