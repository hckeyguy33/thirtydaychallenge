// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/Actor.h"
#include "FloatingActor.generated.h"

UCLASS()
class SAMPLEGAME_API AFloatingActor : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AFloatingActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;
    void PostInitProperties();
    
    UFUNCTION(BlueprintCallable, Category="Damage")
    void CalculateValues();
    void PostEditChangeProperty(FPropertyChangedEvent& PropertyChangedEvent);
    
    //blueprint implementation will be called if it exists, if not it will call our implementation
    UFUNCTION(BlueprintCallable, Category="Damage")
    void CalledFromCpp();
    
    void Move(float f);

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

    float RunningTime;
	
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category="Damage")
    int32 TotalDamage;
    
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category="Damage")
    float DamageTimeInSeconds;
    
    UPROPERTY(BlueprintReadOnly, VisibleAnywhere, Transient, Category="Damage")
    float DamagePerSecond;
};
