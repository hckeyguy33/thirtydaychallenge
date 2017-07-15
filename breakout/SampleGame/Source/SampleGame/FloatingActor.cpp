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

void AFloatingActor::CalculateValues(){
    DamagePerSecond = TotalDamage / DamageTimeInSeconds;
}

#if WITH_EDITOR
void AFloatingActor::PostEditChangeProperty(FPropertyChangedEvent& PropertyChangedEvent)
{
    CalculateValues();
    
    Super::PostEditChangeProperty(PropertyChangedEvent);
}
#endif

void AFloatingActor::PostInitProperties()
{
    Super::PostInitProperties();
    CalculateValues();
}

//void AFloatingActor::CalledFromCpp_Implementation()
//{
//    Move(10.0f);
//}

// Called when the game starts or when spawned
void AFloatingActor::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AFloatingActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
    
    float DeltaHeight = (FMath::Sin(RunningTime + DeltaTime) - FMath::Sin(RunningTime));
    RunningTime += DeltaTime;

    Move(DeltaHeight);
    
    CalledFromCpp();

}

void AFloatingActor::Move(float DeltaHeight){
    
    FVector NewLocation = GetActorLocation();
    NewLocation.Z += DeltaHeight * 20.0f;  //Scales the height by factor of 20
    SetActorLocation(NewLocation);
}

