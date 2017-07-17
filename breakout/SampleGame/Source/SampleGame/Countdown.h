// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/Actor.h"
#include "Countdown.generated.h"

UCLASS()
class SAMPLEGAME_API ACountdown : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	ACountdown();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

    //How long, in seconds, our timer will run
    UPROPERTY(EditAnywhere)
    int32 CountdownTime;
    
    UTextRenderComponent* CountdownText;
    
    void UpdateTimerDisplay();
	
    void AdvanceTimer();
    
    UFUNCTION(BlueprintNativeEvent)
    void CountdownHasFinished();
    virtual void CountdownHasFinished_Implementation();
    
    FTimerHandle CountdownTimerHandle;
};
