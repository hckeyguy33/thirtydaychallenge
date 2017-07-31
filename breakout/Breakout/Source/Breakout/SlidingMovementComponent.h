// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/PawnMovementComponent.h"
#include "SlidingMovementComponent.generated.h"

/**
 * 
 */
UCLASS()
class BREAKOUT_API USlidingMovementComponent : public UPawnMovementComponent
{
	GENERATED_BODY()
	
public:
    // Called every frame
    virtual void TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction *ThisTickFunction) override;
	
	
};
