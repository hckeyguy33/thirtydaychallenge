// Fill out your copyright notice in the Description page of Project Settings.

#include "Breakout.h"
#include "SlidingMovementComponent.h"
#include "UserBar.h"


// Sets default values
AUserBar::AUserBar()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
    
    // Our root component will be a box that reacts to physics
    UBoxComponent* BoxComponent = CreateDefaultSubobject<UBoxComponent>(TEXT("RootComponent"));
    RootComponent = BoxComponent;
    //BoxComponent->InitSphereRadius(40.0f);
    BoxComponent->SetCollisionProfileName(TEXT("Pawn"));
    
    // Create and position a mesh component so we can see where our box is
    UStaticMeshComponent* BoxVisual = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("VisualRepresentation"));
    BoxVisual->SetupAttachment(RootComponent);
    //need to bring in starter shape and use here
    static ConstructorHelpers::FObjectFinder<UStaticMesh> BoxVisualAsset(TEXT("/Game/MobileStarterContent/Shapes/Shape_Cube"));
    if (BoxVisualAsset.Succeeded())
    {
        BoxVisual->SetStaticMesh(BoxVisualAsset.Object);
        BoxVisual->SetRelativeLocation(FVector(0.0f, 0.0f, 0.0f));
//        SphereVisual->SetWorldScale3D(FVector(0.8f));
    }
    
    // Take control of the default player
    AutoPossessPlayer = EAutoReceiveInput::Player0;
    
    // Create an instance of our movement component, and tell it to update the root.
    OurMovementComponent = CreateDefaultSubobject<USlidingMovementComponent>(TEXT("CustomMovementComponent"));
    OurMovementComponent->UpdatedComponent = RootComponent;

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
    
    InputComponent->BindAxis("HorizontalSlide", this, &AUserBar::MoveRight);

}
UPawnMovementComponent* AUserBar::GetMovementComponent() const
{
    return OurMovementComponent;
}

void AUserBar::MoveRight(float AxisValue)
{
    if (OurMovementComponent && (OurMovementComponent->UpdatedComponent == RootComponent))
    {
        OurMovementComponent->AddInputVector(GetActorRightVector() * AxisValue);
    }
}

