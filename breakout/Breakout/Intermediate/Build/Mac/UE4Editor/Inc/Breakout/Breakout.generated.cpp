// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Boilerplate C++ definitions for a single module.
	This is automatically generated by UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "GeneratedCppIncludes.h"
#include "Breakout.h"
#include "Breakout.generated.dep.h"
PRAGMA_DISABLE_OPTIMIZATION
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCode1Breakout() {}
	void ABall::StaticRegisterNativesABall()
	{
		FNativeFunctionRegistrar::RegisterFunction(ABall::StaticClass(), "FireInDirection",(Native)&ABall::execFireInDirection);
	}
	IMPLEMENT_CLASS(ABall, 1416058928);
	void ABreakoutGameModeBase::StaticRegisterNativesABreakoutGameModeBase()
	{
	}
	IMPLEMENT_CLASS(ABreakoutGameModeBase, 3249791903);
	void USlidingMovementComponent::StaticRegisterNativesUSlidingMovementComponent()
	{
	}
	IMPLEMENT_CLASS(USlidingMovementComponent, 176361710);
	void AUserBar::StaticRegisterNativesAUserBar()
	{
	}
	IMPLEMENT_CLASS(AUserBar, 3158072830);
#if USE_COMPILED_IN_NATIVES
// Cross Module References
	COREUOBJECT_API class UScriptStruct* Z_Construct_UScriptStruct_FVector();
	ENGINE_API class UClass* Z_Construct_UClass_AActor();
	ENGINE_API class UClass* Z_Construct_UClass_UProjectileMovementComponent_NoRegister();
	ENGINE_API class UClass* Z_Construct_UClass_USphereComponent_NoRegister();
	ENGINE_API class UClass* Z_Construct_UClass_AGameModeBase();
	ENGINE_API class UClass* Z_Construct_UClass_UPawnMovementComponent();
	ENGINE_API class UClass* Z_Construct_UClass_APawn();

	BREAKOUT_API class UFunction* Z_Construct_UFunction_ABall_FireInDirection();
	BREAKOUT_API class UClass* Z_Construct_UClass_ABall_NoRegister();
	BREAKOUT_API class UClass* Z_Construct_UClass_ABall();
	BREAKOUT_API class UClass* Z_Construct_UClass_ABreakoutGameModeBase_NoRegister();
	BREAKOUT_API class UClass* Z_Construct_UClass_ABreakoutGameModeBase();
	BREAKOUT_API class UClass* Z_Construct_UClass_USlidingMovementComponent_NoRegister();
	BREAKOUT_API class UClass* Z_Construct_UClass_USlidingMovementComponent();
	BREAKOUT_API class UClass* Z_Construct_UClass_AUserBar_NoRegister();
	BREAKOUT_API class UClass* Z_Construct_UClass_AUserBar();
	BREAKOUT_API class UPackage* Z_Construct_UPackage__Script_Breakout();
	UFunction* Z_Construct_UFunction_ABall_FireInDirection()
	{
		struct Ball_eventFireInDirection_Parms
		{
			FVector ShootDirection;
		};
		UObject* Outer=Z_Construct_UClass_ABall();
		static UFunction* ReturnFunction = NULL;
		if (!ReturnFunction)
		{
			ReturnFunction = new(EC_InternalUseOnlyConstructor, Outer, TEXT("FireInDirection"), RF_Public|RF_Transient|RF_MarkAsNative) UFunction(FObjectInitializer(), NULL, 0x04C20401, 65535, sizeof(Ball_eventFireInDirection_Parms));
			UProperty* NewProp_ShootDirection = new(EC_InternalUseOnlyConstructor, ReturnFunction, TEXT("ShootDirection"), RF_Public|RF_Transient|RF_MarkAsNative) UStructProperty(CPP_PROPERTY_BASE(ShootDirection, Ball_eventFireInDirection_Parms), 0x0010000008000182, Z_Construct_UScriptStruct_FVector());
			ReturnFunction->Bind();
			ReturnFunction->StaticLink();
#if WITH_METADATA
			UMetaData* MetaData = ReturnFunction->GetOutermost()->GetMetaData();
			MetaData->SetValue(ReturnFunction, TEXT("Category"), TEXT("Ball"));
			MetaData->SetValue(ReturnFunction, TEXT("ModuleRelativePath"), TEXT("Ball.h"));
			MetaData->SetValue(ReturnFunction, TEXT("ToolTip"), TEXT("Function that initializes the projectile's velocity in the shoot direction."));
			MetaData->SetValue(NewProp_ShootDirection, TEXT("NativeConst"), TEXT(""));
#endif
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_ABall_NoRegister()
	{
		return ABall::StaticClass();
	}
	UClass* Z_Construct_UClass_ABall()
	{
		static UClass* OuterClass = NULL;
		if (!OuterClass)
		{
			Z_Construct_UClass_AActor();
			Z_Construct_UPackage__Script_Breakout();
			OuterClass = ABall::StaticClass();
			if (!(OuterClass->ClassFlags & CLASS_Constructed))
			{
				UObjectForceRegistration(OuterClass);
				OuterClass->ClassFlags |= 0x20900080;

				OuterClass->LinkChild(Z_Construct_UFunction_ABall_FireInDirection());

PRAGMA_DISABLE_DEPRECATION_WARNINGS
				UProperty* NewProp_ProjectileMovementComponent = new(EC_InternalUseOnlyConstructor, OuterClass, TEXT("ProjectileMovementComponent"), RF_Public|RF_Transient|RF_MarkAsNative) UObjectProperty(CPP_PROPERTY_BASE(ProjectileMovementComponent, ABall), 0x00100000000a0009, Z_Construct_UClass_UProjectileMovementComponent_NoRegister());
				UProperty* NewProp_CollisionComponent = new(EC_InternalUseOnlyConstructor, OuterClass, TEXT("CollisionComponent"), RF_Public|RF_Transient|RF_MarkAsNative) UObjectProperty(CPP_PROPERTY_BASE(CollisionComponent, ABall), 0x00100000000b0009, Z_Construct_UClass_USphereComponent_NoRegister());
PRAGMA_ENABLE_DEPRECATION_WARNINGS
				OuterClass->AddFunctionToFunctionMapWithOverriddenName(Z_Construct_UFunction_ABall_FireInDirection(), "FireInDirection"); // 1725761574
				OuterClass->StaticLink();
#if WITH_METADATA
				UMetaData* MetaData = OuterClass->GetOutermost()->GetMetaData();
				MetaData->SetValue(OuterClass, TEXT("IncludePath"), TEXT("Ball.h"));
				MetaData->SetValue(OuterClass, TEXT("ModuleRelativePath"), TEXT("Ball.h"));
				MetaData->SetValue(NewProp_ProjectileMovementComponent, TEXT("Category"), TEXT("Movement"));
				MetaData->SetValue(NewProp_ProjectileMovementComponent, TEXT("EditInline"), TEXT("true"));
				MetaData->SetValue(NewProp_ProjectileMovementComponent, TEXT("ModuleRelativePath"), TEXT("Ball.h"));
				MetaData->SetValue(NewProp_ProjectileMovementComponent, TEXT("ToolTip"), TEXT("Projectile movement component."));
				MetaData->SetValue(NewProp_CollisionComponent, TEXT("Category"), TEXT("Ball"));
				MetaData->SetValue(NewProp_CollisionComponent, TEXT("EditInline"), TEXT("true"));
				MetaData->SetValue(NewProp_CollisionComponent, TEXT("ModuleRelativePath"), TEXT("Ball.h"));
				MetaData->SetValue(NewProp_CollisionComponent, TEXT("ToolTip"), TEXT("Sphere collision component."));
#endif
			}
		}
		check(OuterClass->GetClass());
		return OuterClass;
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_ABall(Z_Construct_UClass_ABall, &ABall::StaticClass, TEXT("ABall"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(ABall);
	UClass* Z_Construct_UClass_ABreakoutGameModeBase_NoRegister()
	{
		return ABreakoutGameModeBase::StaticClass();
	}
	UClass* Z_Construct_UClass_ABreakoutGameModeBase()
	{
		static UClass* OuterClass = NULL;
		if (!OuterClass)
		{
			Z_Construct_UClass_AGameModeBase();
			Z_Construct_UPackage__Script_Breakout();
			OuterClass = ABreakoutGameModeBase::StaticClass();
			if (!(OuterClass->ClassFlags & CLASS_Constructed))
			{
				UObjectForceRegistration(OuterClass);
				OuterClass->ClassFlags |= 0x20900288;


				OuterClass->StaticLink();
#if WITH_METADATA
				UMetaData* MetaData = OuterClass->GetOutermost()->GetMetaData();
				MetaData->SetValue(OuterClass, TEXT("HideCategories"), TEXT("Info Rendering MovementReplication Replication Actor Input Movement Collision Rendering Utilities|Transformation"));
				MetaData->SetValue(OuterClass, TEXT("IncludePath"), TEXT("BreakoutGameModeBase.h"));
				MetaData->SetValue(OuterClass, TEXT("ModuleRelativePath"), TEXT("BreakoutGameModeBase.h"));
				MetaData->SetValue(OuterClass, TEXT("ShowCategories"), TEXT("Input|MouseInput Input|TouchInput"));
#endif
			}
		}
		check(OuterClass->GetClass());
		return OuterClass;
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_ABreakoutGameModeBase(Z_Construct_UClass_ABreakoutGameModeBase, &ABreakoutGameModeBase::StaticClass, TEXT("ABreakoutGameModeBase"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(ABreakoutGameModeBase);
	UClass* Z_Construct_UClass_USlidingMovementComponent_NoRegister()
	{
		return USlidingMovementComponent::StaticClass();
	}
	UClass* Z_Construct_UClass_USlidingMovementComponent()
	{
		static UClass* OuterClass = NULL;
		if (!OuterClass)
		{
			Z_Construct_UClass_UPawnMovementComponent();
			Z_Construct_UPackage__Script_Breakout();
			OuterClass = USlidingMovementComponent::StaticClass();
			if (!(OuterClass->ClassFlags & CLASS_Constructed))
			{
				UObjectForceRegistration(OuterClass);
				OuterClass->ClassFlags |= 0x20B00084;


				OuterClass->ClassConfigName = FName(TEXT("Engine"));
				OuterClass->StaticLink();
#if WITH_METADATA
				UMetaData* MetaData = OuterClass->GetOutermost()->GetMetaData();
				MetaData->SetValue(OuterClass, TEXT("IncludePath"), TEXT("SlidingMovementComponent.h"));
				MetaData->SetValue(OuterClass, TEXT("ModuleRelativePath"), TEXT("SlidingMovementComponent.h"));
#endif
			}
		}
		check(OuterClass->GetClass());
		return OuterClass;
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_USlidingMovementComponent(Z_Construct_UClass_USlidingMovementComponent, &USlidingMovementComponent::StaticClass, TEXT("USlidingMovementComponent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(USlidingMovementComponent);
	UClass* Z_Construct_UClass_AUserBar_NoRegister()
	{
		return AUserBar::StaticClass();
	}
	UClass* Z_Construct_UClass_AUserBar()
	{
		static UClass* OuterClass = NULL;
		if (!OuterClass)
		{
			Z_Construct_UClass_APawn();
			Z_Construct_UPackage__Script_Breakout();
			OuterClass = AUserBar::StaticClass();
			if (!(OuterClass->ClassFlags & CLASS_Constructed))
			{
				UObjectForceRegistration(OuterClass);
				OuterClass->ClassFlags |= 0x20900080;


				OuterClass->StaticLink();
#if WITH_METADATA
				UMetaData* MetaData = OuterClass->GetOutermost()->GetMetaData();
				MetaData->SetValue(OuterClass, TEXT("HideCategories"), TEXT("Navigation"));
				MetaData->SetValue(OuterClass, TEXT("IncludePath"), TEXT("UserBar.h"));
				MetaData->SetValue(OuterClass, TEXT("ModuleRelativePath"), TEXT("UserBar.h"));
#endif
			}
		}
		check(OuterClass->GetClass());
		return OuterClass;
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_AUserBar(Z_Construct_UClass_AUserBar, &AUserBar::StaticClass, TEXT("AUserBar"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(AUserBar);
	UPackage* Z_Construct_UPackage__Script_Breakout()
	{
		static UPackage* ReturnPackage = NULL;
		if (!ReturnPackage)
		{
			ReturnPackage = CastChecked<UPackage>(StaticFindObjectFast(UPackage::StaticClass(), NULL, FName(TEXT("/Script/Breakout")), false, false));
			ReturnPackage->SetPackageFlags(PKG_CompiledIn | 0x00000000);
			FGuid Guid;
			Guid.A = 0x7EB5DDD6;
			Guid.B = 0x6D650398;
			Guid.C = 0x00000000;
			Guid.D = 0x00000000;
			ReturnPackage->SetGuid(Guid);

		}
		return ReturnPackage;
	}
#endif

PRAGMA_ENABLE_DEPRECATION_WARNINGS
