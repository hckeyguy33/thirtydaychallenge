// Fill out your copyright notice in the Description page of Project Settings.

#include "SampleGame.h"
#include "MyPlayerController.h"



void AMyPlayerController::BeginPlay()
{
    Super::BeginPlay();
    SetInputMode(FInputModeGameAndUI());
}
