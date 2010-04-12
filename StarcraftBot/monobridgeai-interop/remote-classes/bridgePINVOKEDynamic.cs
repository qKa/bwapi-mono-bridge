
namespace BWAPI {

using System;
using System.Runtime.InteropServices;
using log4net;


public class bridgePINVOKEDynamic: MarshalByRefObject {

	
public class SWIGPendingExceptionDynamic: MarshalByRefObject {
    public bool Pending {
      get {
        return bridgePINVOKE.SWIGPendingException.Pending;
      } 
    }

    public void Set(Exception e) {
		bridgePINVOKE.SWIGPendingException.Set(e);
	}

    public Exception Retrieve() {
		return bridgePINVOKE.SWIGPendingException.Retrieve();
    }
}

public SWIGPendingExceptionDynamic SWIGPendingException;
                                                        
public static ILog errorlog = null;

public bridgePINVOKEDynamic() {
	SWIGPendingException = new SWIGPendingExceptionDynamic();
}



public void BWAPI_init( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BWAPI_init"); } 
bridgePINVOKE.BWAPI_init();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BWAPI_init: ",e);}
throw e;
   }     
}
}


public IntPtr new_Race__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Race__SWIG_0"); } 
return bridgePINVOKE.new_Race__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Race__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_Race__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Race__SWIG_1"); } 
return bridgePINVOKE.new_Race__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Race__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_Race__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Race__SWIG_2"); } 
return bridgePINVOKE.new_Race__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Race__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr Race_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_opAssign"); } 
return bridgePINVOKE.Race_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_opAssign: ",e);}
throw e;
   }     
}
}


public bool Race_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_opEquals"); } 
return bridgePINVOKE.Race_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_opEquals: ",e);}
throw e;
   }     
}
}


public bool Race_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_opNotEquals"); } 
return bridgePINVOKE.Race_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool Race_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_opLessThan"); } 
return bridgePINVOKE.Race_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_opLessThan: ",e);}
throw e;
   }     
}
}


public int Race_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getID"); } 
return bridgePINVOKE.Race_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getID: ",e);}
throw e;
   }     
}
}


public string Race_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getName"); } 
return bridgePINVOKE.Race_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getName: ",e);}
throw e;
   }     
}
}


public IntPtr Race_getWorker(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getWorker"); } 
return bridgePINVOKE.Race_getWorker(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getWorker: ",e);}
throw e;
   }     
}
}


public IntPtr Race_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getCenter"); } 
return bridgePINVOKE.Race_getCenter(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getCenter: ",e);}
throw e;
   }     
}
}


public IntPtr Race_getRefinery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getRefinery"); } 
return bridgePINVOKE.Race_getRefinery(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getRefinery: ",e);}
throw e;
   }     
}
}


public IntPtr Race_getTransport(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getTransport"); } 
return bridgePINVOKE.Race_getTransport(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getTransport: ",e);}
throw e;
   }     
}
}


public IntPtr Race_getSupplyProvider(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Race_getSupplyProvider"); } 
return bridgePINVOKE.Race_getSupplyProvider(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Race_getSupplyProvider: ",e);}
throw e;
   }     
}
}


public void delete_Race(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Race"); } 
bridgePINVOKE.delete_Race(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Race: ",e);}
throw e;
   }     
}
}


public IntPtr getRace(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getRace"); } 
return bridgePINVOKE.getRace(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getRace: ",e);}
throw e;
   }     
}
}


public IntPtr allRaces( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allRaces"); } 
return bridgePINVOKE.allRaces();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allRaces: ",e);}
throw e;
   }     
}
}


public void initRaces( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initRaces"); } 
bridgePINVOKE.initRaces();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initRaces: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_get"); } 
return bridgePINVOKE.Zerg_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_get"); } 
return bridgePINVOKE.Terran_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_get"); } 
return bridgePINVOKE.Protoss_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_get: ",e);}
throw e;
   }     
}
}


public IntPtr Random_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Random_get"); } 
return bridgePINVOKE.Random_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Random_get: ",e);}
throw e;
   }     
}
}


public IntPtr Other_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Other_get"); } 
return bridgePINVOKE.Other_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Other_get: ",e);}
throw e;
   }     
}
}


public IntPtr RaceNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceNone_get"); } 
return bridgePINVOKE.RaceNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr RaceUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceUnknown_get"); } 
return bridgePINVOKE.RaceUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechType__SWIG_0"); } 
return bridgePINVOKE.new_TechType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechType__SWIG_1"); } 
return bridgePINVOKE.new_TechType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechType__SWIG_2"); } 
return bridgePINVOKE.new_TechType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr TechType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_opAssign"); } 
return bridgePINVOKE.TechType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_opAssign: ",e);}
throw e;
   }     
}
}


public bool TechType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_opEquals"); } 
return bridgePINVOKE.TechType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_opEquals: ",e);}
throw e;
   }     
}
}


public bool TechType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_opNotEquals"); } 
return bridgePINVOKE.TechType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool TechType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_opLessThan"); } 
return bridgePINVOKE.TechType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_opLessThan: ",e);}
throw e;
   }     
}
}


public int TechType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_getID"); } 
return bridgePINVOKE.TechType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_getID: ",e);}
throw e;
   }     
}
}


public string TechType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_getName"); } 
return bridgePINVOKE.TechType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_getName: ",e);}
throw e;
   }     
}
}


public int TechType_mineralPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_mineralPrice"); } 
return bridgePINVOKE.TechType_mineralPrice(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_mineralPrice: ",e);}
throw e;
   }     
}
}


public int TechType_gasPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_gasPrice"); } 
return bridgePINVOKE.TechType_gasPrice(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_gasPrice: ",e);}
throw e;
   }     
}
}


public int TechType_energyUsed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_energyUsed"); } 
return bridgePINVOKE.TechType_energyUsed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_energyUsed: ",e);}
throw e;
   }     
}
}


public IntPtr TechType_whatResearches(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_whatResearches"); } 
return bridgePINVOKE.TechType_whatResearches(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_whatResearches: ",e);}
throw e;
   }     
}
}


public IntPtr TechType_getWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_getWeapon"); } 
return bridgePINVOKE.TechType_getWeapon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_getWeapon: ",e);}
throw e;
   }     
}
}


public IntPtr TechType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechType_whatUses"); } 
return bridgePINVOKE.TechType_whatUses(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechType_whatUses: ",e);}
throw e;
   }     
}
}


public void delete_TechType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TechType"); } 
bridgePINVOKE.delete_TechType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TechType: ",e);}
throw e;
   }     
}
}


public IntPtr getTechType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getTechType"); } 
return bridgePINVOKE.getTechType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getTechType: ",e);}
throw e;
   }     
}
}


public IntPtr allTechTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allTechTypes"); } 
return bridgePINVOKE.allTechTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allTechTypes: ",e);}
throw e;
   }     
}
}


public void initTechTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initTechTypes"); } 
bridgePINVOKE.initTechTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initTechTypes: ",e);}
throw e;
   }     
}
}


public IntPtr Stim_Packs_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Stim_Packs_get"); } 
return bridgePINVOKE.Stim_Packs_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Stim_Packs_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeLockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeLockdown_get"); } 
return bridgePINVOKE.TechTypeLockdown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeLockdown_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeEMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeEMP_Shockwave_get"); } 
return bridgePINVOKE.TechTypeEMP_Shockwave_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeEMP_Shockwave_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spider_Mines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spider_Mines_get"); } 
return bridgePINVOKE.Spider_Mines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spider_Mines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Scanner_Sweep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Scanner_Sweep_get"); } 
return bridgePINVOKE.Scanner_Sweep_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Scanner_Sweep_get: ",e);}
throw e;
   }     
}
}


public IntPtr Tank_Siege_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Tank_Siege_Mode_get"); } 
return bridgePINVOKE.Tank_Siege_Mode_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Tank_Siege_Mode_get: ",e);}
throw e;
   }     
}
}


public IntPtr Defensive_Matrix_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Defensive_Matrix_get"); } 
return bridgePINVOKE.Defensive_Matrix_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Defensive_Matrix_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeIrradiate_get"); } 
return bridgePINVOKE.TechTypeIrradiate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeIrradiate_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeYamato_Gun_get"); } 
return bridgePINVOKE.TechTypeYamato_Gun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeYamato_Gun_get: ",e);}
throw e;
   }     
}
}


public IntPtr Cloaking_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Cloaking_Field_get"); } 
return bridgePINVOKE.Cloaking_Field_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Cloaking_Field_get: ",e);}
throw e;
   }     
}
}


public IntPtr Personnel_Cloaking_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Personnel_Cloaking_get"); } 
return bridgePINVOKE.Personnel_Cloaking_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Personnel_Cloaking_get: ",e);}
throw e;
   }     
}
}


public IntPtr Burrowing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Burrowing_get"); } 
return bridgePINVOKE.Burrowing_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Burrowing_get: ",e);}
throw e;
   }     
}
}


public IntPtr Infestation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Infestation_get"); } 
return bridgePINVOKE.Infestation_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Infestation_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeSpawn_Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSpawn_Broodlings_get"); } 
return bridgePINVOKE.TechTypeSpawn_Broodlings_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSpawn_Broodlings_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeDark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeDark_Swarm_get"); } 
return bridgePINVOKE.TechTypeDark_Swarm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeDark_Swarm_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePlague_get"); } 
return bridgePINVOKE.TechTypePlague_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePlague_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeConsume_get"); } 
return bridgePINVOKE.TechTypeConsume_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeConsume_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeEnsnare_get"); } 
return bridgePINVOKE.TechTypeEnsnare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeEnsnare_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeParasite_get"); } 
return bridgePINVOKE.TechTypeParasite_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeParasite_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypePsionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePsionic_Storm_get"); } 
return bridgePINVOKE.TechTypePsionic_Storm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePsionic_Storm_get: ",e);}
throw e;
   }     
}
}


public IntPtr Hallucination_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Hallucination_get"); } 
return bridgePINVOKE.Hallucination_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Hallucination_get: ",e);}
throw e;
   }     
}
}


public IntPtr Recall_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Recall_get"); } 
return bridgePINVOKE.Recall_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Recall_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeStasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeStasis_Field_get"); } 
return bridgePINVOKE.TechTypeStasis_Field_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeStasis_Field_get: ",e);}
throw e;
   }     
}
}


public IntPtr Archon_Warp_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Archon_Warp_get"); } 
return bridgePINVOKE.Archon_Warp_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Archon_Warp_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeRestoration_get"); } 
return bridgePINVOKE.TechTypeRestoration_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeRestoration_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeDisruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeDisruption_Web_get"); } 
return bridgePINVOKE.TechTypeDisruption_Web_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeDisruption_Web_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeMind_Control_get"); } 
return bridgePINVOKE.TechTypeMind_Control_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeMind_Control_get: ",e);}
throw e;
   }     
}
}


public IntPtr Dark_Archon_Meld_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Dark_Archon_Meld_get"); } 
return bridgePINVOKE.Dark_Archon_Meld_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Dark_Archon_Meld_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeFeedback_get"); } 
return bridgePINVOKE.TechTypeFeedback_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeFeedback_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeOptical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeOptical_Flare_get"); } 
return bridgePINVOKE.TechTypeOptical_Flare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeOptical_Flare_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeMaelstrom_get"); } 
return bridgePINVOKE.TechTypeMaelstrom_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeMaelstrom_get: ",e);}
throw e;
   }     
}
}


public IntPtr Lurker_Aspect_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Lurker_Aspect_get"); } 
return bridgePINVOKE.Lurker_Aspect_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Lurker_Aspect_get: ",e);}
throw e;
   }     
}
}


public IntPtr Healing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Healing_get"); } 
return bridgePINVOKE.Healing_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Healing_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeNone_get"); } 
return bridgePINVOKE.TechTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeUnknown_get"); } 
return bridgePINVOKE.TechTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeNuclear_Strike_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeNuclear_Strike_get"); } 
return bridgePINVOKE.TechTypeNuclear_Strike_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeNuclear_Strike_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeType__SWIG_0"); } 
return bridgePINVOKE.new_UpgradeType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeType__SWIG_1"); } 
return bridgePINVOKE.new_UpgradeType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeType__SWIG_2"); } 
return bridgePINVOKE.new_UpgradeType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_opAssign"); } 
return bridgePINVOKE.UpgradeType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_opAssign: ",e);}
throw e;
   }     
}
}


public bool UpgradeType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_opEquals"); } 
return bridgePINVOKE.UpgradeType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_opEquals: ",e);}
throw e;
   }     
}
}


public bool UpgradeType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_opNotEquals"); } 
return bridgePINVOKE.UpgradeType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool UpgradeType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_opLessThan"); } 
return bridgePINVOKE.UpgradeType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_opLessThan: ",e);}
throw e;
   }     
}
}


public int UpgradeType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_getID"); } 
return bridgePINVOKE.UpgradeType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_getID: ",e);}
throw e;
   }     
}
}


public string UpgradeType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_getName"); } 
return bridgePINVOKE.UpgradeType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_getName: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeType_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_getRace"); } 
return bridgePINVOKE.UpgradeType_getRace(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_getRace: ",e);}
throw e;
   }     
}
}


public int UpgradeType_mineralPriceBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_mineralPriceBase"); } 
return bridgePINVOKE.UpgradeType_mineralPriceBase(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_mineralPriceBase: ",e);}
throw e;
   }     
}
}


public int UpgradeType_mineralPriceFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_mineralPriceFactor"); } 
return bridgePINVOKE.UpgradeType_mineralPriceFactor(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_mineralPriceFactor: ",e);}
throw e;
   }     
}
}


public int UpgradeType_gasPriceBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_gasPriceBase"); } 
return bridgePINVOKE.UpgradeType_gasPriceBase(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_gasPriceBase: ",e);}
throw e;
   }     
}
}


public int UpgradeType_gasPriceFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_gasPriceFactor"); } 
return bridgePINVOKE.UpgradeType_gasPriceFactor(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_gasPriceFactor: ",e);}
throw e;
   }     
}
}


public int UpgradeType_upgradeTimeBase(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_upgradeTimeBase"); } 
return bridgePINVOKE.UpgradeType_upgradeTimeBase(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_upgradeTimeBase: ",e);}
throw e;
   }     
}
}


public int UpgradeType_upgradeTimeFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_upgradeTimeFactor"); } 
return bridgePINVOKE.UpgradeType_upgradeTimeFactor(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_upgradeTimeFactor: ",e);}
throw e;
   }     
}
}


public int UpgradeType_maxRepeats(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_maxRepeats"); } 
return bridgePINVOKE.UpgradeType_maxRepeats(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_maxRepeats: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeType_whatUpgrades(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_whatUpgrades"); } 
return bridgePINVOKE.UpgradeType_whatUpgrades(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_whatUpgrades: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeType_whatUses"); } 
return bridgePINVOKE.UpgradeType_whatUses(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeType_whatUses: ",e);}
throw e;
   }     
}
}


public void delete_UpgradeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UpgradeType"); } 
bridgePINVOKE.delete_UpgradeType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UpgradeType: ",e);}
throw e;
   }     
}
}


public IntPtr getUpgradeType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getUpgradeType"); } 
return bridgePINVOKE.getUpgradeType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getUpgradeType: ",e);}
throw e;
   }     
}
}


public IntPtr allUpgradeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allUpgradeTypes"); } 
return bridgePINVOKE.allUpgradeTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allUpgradeTypes: ",e);}
throw e;
   }     
}
}


public void initUpgradeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initUpgradeTypes"); } 
bridgePINVOKE.initUpgradeTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initUpgradeTypes: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Infantry_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Infantry_Armor_get"); } 
return bridgePINVOKE.Terran_Infantry_Armor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Infantry_Armor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Vehicle_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Vehicle_Plating_get"); } 
return bridgePINVOKE.Terran_Vehicle_Plating_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Vehicle_Plating_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Ship_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Ship_Plating_get"); } 
return bridgePINVOKE.Terran_Ship_Plating_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Ship_Plating_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Carapace_get"); } 
return bridgePINVOKE.Zerg_Carapace_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Carapace_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Flyer_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Flyer_Carapace_get"); } 
return bridgePINVOKE.Zerg_Flyer_Carapace_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Flyer_Carapace_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Armor_get"); } 
return bridgePINVOKE.Protoss_Armor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Armor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Plating_get"); } 
return bridgePINVOKE.Protoss_Plating_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Plating_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Infantry_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Infantry_Weapons_get"); } 
return bridgePINVOKE.Terran_Infantry_Weapons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Infantry_Weapons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Vehicle_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Vehicle_Weapons_get"); } 
return bridgePINVOKE.Terran_Vehicle_Weapons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Vehicle_Weapons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Ship_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Ship_Weapons_get"); } 
return bridgePINVOKE.Terran_Ship_Weapons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Ship_Weapons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Melee_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Melee_Attacks_get"); } 
return bridgePINVOKE.Zerg_Melee_Attacks_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Melee_Attacks_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Missile_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Missile_Attacks_get"); } 
return bridgePINVOKE.Zerg_Missile_Attacks_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Missile_Attacks_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Flyer_Attacks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Flyer_Attacks_get"); } 
return bridgePINVOKE.Zerg_Flyer_Attacks_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Flyer_Attacks_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Ground_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Ground_Weapons_get"); } 
return bridgePINVOKE.Protoss_Ground_Weapons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Ground_Weapons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Air_Weapons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Air_Weapons_get"); } 
return bridgePINVOKE.Protoss_Air_Weapons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Air_Weapons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Plasma_Shields_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Plasma_Shields_get"); } 
return bridgePINVOKE.Protoss_Plasma_Shields_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Plasma_Shields_get: ",e);}
throw e;
   }     
}
}


public IntPtr U_238_Shells_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - U_238_Shells_get"); } 
return bridgePINVOKE.U_238_Shells_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in U_238_Shells_get: ",e);}
throw e;
   }     
}
}


public IntPtr Ion_Thrusters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Ion_Thrusters_get"); } 
return bridgePINVOKE.Ion_Thrusters_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Ion_Thrusters_get: ",e);}
throw e;
   }     
}
}


public IntPtr Titan_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Titan_Reactor_get"); } 
return bridgePINVOKE.Titan_Reactor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Titan_Reactor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Ocular_Implants_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Ocular_Implants_get"); } 
return bridgePINVOKE.Ocular_Implants_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Ocular_Implants_get: ",e);}
throw e;
   }     
}
}


public IntPtr Moebius_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Moebius_Reactor_get"); } 
return bridgePINVOKE.Moebius_Reactor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Moebius_Reactor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Apollo_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Apollo_Reactor_get"); } 
return bridgePINVOKE.Apollo_Reactor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Apollo_Reactor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Colossus_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Colossus_Reactor_get"); } 
return bridgePINVOKE.Colossus_Reactor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Colossus_Reactor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Ventral_Sacs_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Ventral_Sacs_get"); } 
return bridgePINVOKE.Ventral_Sacs_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Ventral_Sacs_get: ",e);}
throw e;
   }     
}
}


public IntPtr Antennae_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Antennae_get"); } 
return bridgePINVOKE.Antennae_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Antennae_get: ",e);}
throw e;
   }     
}
}


public IntPtr Pneumatized_Carapace_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Pneumatized_Carapace_get"); } 
return bridgePINVOKE.Pneumatized_Carapace_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Pneumatized_Carapace_get: ",e);}
throw e;
   }     
}
}


public IntPtr Metabolic_Boost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Metabolic_Boost_get"); } 
return bridgePINVOKE.Metabolic_Boost_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Metabolic_Boost_get: ",e);}
throw e;
   }     
}
}


public IntPtr Adrenal_Glands_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Adrenal_Glands_get"); } 
return bridgePINVOKE.Adrenal_Glands_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Adrenal_Glands_get: ",e);}
throw e;
   }     
}
}


public IntPtr Muscular_Augments_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Muscular_Augments_get"); } 
return bridgePINVOKE.Muscular_Augments_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Muscular_Augments_get: ",e);}
throw e;
   }     
}
}


public IntPtr Grooved_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Grooved_Spines_get"); } 
return bridgePINVOKE.Grooved_Spines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Grooved_Spines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Gamete_Meiosis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gamete_Meiosis_get"); } 
return bridgePINVOKE.Gamete_Meiosis_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gamete_Meiosis_get: ",e);}
throw e;
   }     
}
}


public IntPtr Metasynaptic_Node_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Metasynaptic_Node_get"); } 
return bridgePINVOKE.Metasynaptic_Node_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Metasynaptic_Node_get: ",e);}
throw e;
   }     
}
}


public IntPtr Singularity_Charge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Singularity_Charge_get"); } 
return bridgePINVOKE.Singularity_Charge_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Singularity_Charge_get: ",e);}
throw e;
   }     
}
}


public IntPtr Leg_Enhancements_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Leg_Enhancements_get"); } 
return bridgePINVOKE.Leg_Enhancements_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Leg_Enhancements_get: ",e);}
throw e;
   }     
}
}


public IntPtr Scarab_Damage_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Scarab_Damage_get"); } 
return bridgePINVOKE.Scarab_Damage_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Scarab_Damage_get: ",e);}
throw e;
   }     
}
}


public IntPtr Reaver_Capacity_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Reaver_Capacity_get"); } 
return bridgePINVOKE.Reaver_Capacity_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Reaver_Capacity_get: ",e);}
throw e;
   }     
}
}


public IntPtr Gravitic_Drive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gravitic_Drive_get"); } 
return bridgePINVOKE.Gravitic_Drive_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gravitic_Drive_get: ",e);}
throw e;
   }     
}
}


public IntPtr Sensor_Array_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Sensor_Array_get"); } 
return bridgePINVOKE.Sensor_Array_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Sensor_Array_get: ",e);}
throw e;
   }     
}
}


public IntPtr Gravitic_Boosters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gravitic_Boosters_get"); } 
return bridgePINVOKE.Gravitic_Boosters_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gravitic_Boosters_get: ",e);}
throw e;
   }     
}
}


public IntPtr Khaydarin_Amulet_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Khaydarin_Amulet_get"); } 
return bridgePINVOKE.Khaydarin_Amulet_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Khaydarin_Amulet_get: ",e);}
throw e;
   }     
}
}


public IntPtr Apial_Sensors_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Apial_Sensors_get"); } 
return bridgePINVOKE.Apial_Sensors_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Apial_Sensors_get: ",e);}
throw e;
   }     
}
}


public IntPtr Gravitic_Thrusters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gravitic_Thrusters_get"); } 
return bridgePINVOKE.Gravitic_Thrusters_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gravitic_Thrusters_get: ",e);}
throw e;
   }     
}
}


public IntPtr Carrier_Capacity_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Carrier_Capacity_get"); } 
return bridgePINVOKE.Carrier_Capacity_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Carrier_Capacity_get: ",e);}
throw e;
   }     
}
}


public IntPtr Khaydarin_Core_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Khaydarin_Core_get"); } 
return bridgePINVOKE.Khaydarin_Core_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Khaydarin_Core_get: ",e);}
throw e;
   }     
}
}


public IntPtr Argus_Jewel_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Argus_Jewel_get"); } 
return bridgePINVOKE.Argus_Jewel_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Argus_Jewel_get: ",e);}
throw e;
   }     
}
}


public IntPtr Argus_Talisman_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Argus_Talisman_get"); } 
return bridgePINVOKE.Argus_Talisman_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Argus_Talisman_get: ",e);}
throw e;
   }     
}
}


public IntPtr Caduceus_Reactor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Caduceus_Reactor_get"); } 
return bridgePINVOKE.Caduceus_Reactor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Caduceus_Reactor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Chitinous_Plating_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Chitinous_Plating_get"); } 
return bridgePINVOKE.Chitinous_Plating_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Chitinous_Plating_get: ",e);}
throw e;
   }     
}
}


public IntPtr Anabolic_Synthesis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Anabolic_Synthesis_get"); } 
return bridgePINVOKE.Anabolic_Synthesis_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Anabolic_Synthesis_get: ",e);}
throw e;
   }     
}
}


public IntPtr Charon_Booster_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Charon_Booster_get"); } 
return bridgePINVOKE.Charon_Booster_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Charon_Booster_get: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeNone_get"); } 
return bridgePINVOKE.UpgradeTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeUnknown_get"); } 
return bridgePINVOKE.UpgradeTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_Position__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Position__SWIG_0"); } 
return bridgePINVOKE.new_Position__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Position__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_Position__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Position__SWIG_1"); } 
return bridgePINVOKE.new_Position__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Position__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_Position__SWIG_2(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Position__SWIG_2"); } 
return bridgePINVOKE.new_Position__SWIG_2(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Position__SWIG_2: ",e);}
throw e;
   }     
}
}


public bool Position_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opEquals"); } 
return bridgePINVOKE.Position_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opEquals: ",e);}
throw e;
   }     
}
}


public bool Position_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opNotEquals"); } 
return bridgePINVOKE.Position_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool Position_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opLessThan"); } 
return bridgePINVOKE.Position_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opLessThan: ",e);}
throw e;
   }     
}
}


public IntPtr Position_opPlus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opPlus"); } 
return bridgePINVOKE.Position_opPlus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opPlus: ",e);}
throw e;
   }     
}
}


public IntPtr Position_opMinus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opMinus"); } 
return bridgePINVOKE.Position_opMinus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opMinus: ",e);}
throw e;
   }     
}
}


public IntPtr Position_opAdd(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opAdd"); } 
return bridgePINVOKE.Position_opAdd(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opAdd: ",e);}
throw e;
   }     
}
}


public IntPtr Position_opSubtract(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_opSubtract"); } 
return bridgePINVOKE.Position_opSubtract(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_opSubtract: ",e);}
throw e;
   }     
}
}


public double Position_getDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_getDistance"); } 
return bridgePINVOKE.Position_getDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_getDistance: ",e);}
throw e;
   }     
}
}


public double Position_getApproxDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_getApproxDistance"); } 
return bridgePINVOKE.Position_getApproxDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_getApproxDistance: ",e);}
throw e;
   }     
}
}


public double Position_getLength(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_getLength"); } 
return bridgePINVOKE.Position_getLength(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_getLength: ",e);}
throw e;
   }     
}
}


public IntPtr Position_x(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_x"); } 
return bridgePINVOKE.Position_x(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_x: ",e);}
throw e;
   }     
}
}


public IntPtr Position_y(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_y"); } 
return bridgePINVOKE.Position_y(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_y: ",e);}
throw e;
   }     
}
}


public int Position_xConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_xConst"); } 
return bridgePINVOKE.Position_xConst(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_xConst: ",e);}
throw e;
   }     
}
}


public int Position_yConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Position_yConst"); } 
return bridgePINVOKE.Position_yConst(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Position_yConst: ",e);}
throw e;
   }     
}
}


public void delete_Position(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Position"); } 
bridgePINVOKE.delete_Position(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Position: ",e);}
throw e;
   }     
}
}


public IntPtr PositionInvalid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionInvalid_get"); } 
return bridgePINVOKE.PositionInvalid_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionInvalid_get: ",e);}
throw e;
   }     
}
}


public IntPtr PositionNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionNone_get"); } 
return bridgePINVOKE.PositionNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr PositionUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionUnknown_get"); } 
return bridgePINVOKE.PositionUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_AIModule( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AIModule"); } 
return bridgePINVOKE.new_AIModule();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AIModule: ",e);}
throw e;
   }     
}
}


public void delete_AIModule(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_AIModule"); } 
bridgePINVOKE.delete_AIModule(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_AIModule: ",e);}
throw e;
   }     
}
}


public void AIModule_onStart(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onStart"); } 
bridgePINVOKE.AIModule_onStart(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onStart: ",e);}
throw e;
   }     
}
}


public void AIModule_onEnd(IntPtr jarg1, bool jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onEnd"); } 
bridgePINVOKE.AIModule_onEnd(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onEnd: ",e);}
throw e;
   }     
}
}


public void AIModule_onFrame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onFrame"); } 
bridgePINVOKE.AIModule_onFrame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onFrame: ",e);}
throw e;
   }     
}
}


public bool AIModule_onSendText(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onSendText"); } 
return bridgePINVOKE.AIModule_onSendText(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onSendText: ",e);}
throw e;
   }     
}
}


public void AIModule_onPlayerLeft(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onPlayerLeft"); } 
bridgePINVOKE.AIModule_onPlayerLeft(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onPlayerLeft: ",e);}
throw e;
   }     
}
}


public void AIModule_onNukeDetect(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onNukeDetect"); } 
bridgePINVOKE.AIModule_onNukeDetect(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onNukeDetect: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitCreate(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitCreate"); } 
bridgePINVOKE.AIModule_onUnitCreate(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitCreate: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitDestroy(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitDestroy"); } 
bridgePINVOKE.AIModule_onUnitDestroy(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitDestroy: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitMorph(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitMorph"); } 
bridgePINVOKE.AIModule_onUnitMorph(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitMorph: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitShow(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitShow"); } 
bridgePINVOKE.AIModule_onUnitShow(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitShow: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitHide(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitHide"); } 
bridgePINVOKE.AIModule_onUnitHide(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitHide: ",e);}
throw e;
   }     
}
}


public void AIModule_onUnitRenegade(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIModule_onUnitRenegade"); } 
bridgePINVOKE.AIModule_onUnitRenegade(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIModule_onUnitRenegade: ",e);}
throw e;
   }     
}
}


public IntPtr new_AttackType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AttackType__SWIG_0"); } 
return bridgePINVOKE.new_AttackType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AttackType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_AttackType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AttackType__SWIG_1"); } 
return bridgePINVOKE.new_AttackType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AttackType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_AttackType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AttackType__SWIG_2"); } 
return bridgePINVOKE.new_AttackType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AttackType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr AttackType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_opAssign"); } 
return bridgePINVOKE.AttackType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_opAssign: ",e);}
throw e;
   }     
}
}


public bool AttackType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_opEquals"); } 
return bridgePINVOKE.AttackType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_opEquals: ",e);}
throw e;
   }     
}
}


public bool AttackType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_opNotEquals"); } 
return bridgePINVOKE.AttackType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool AttackType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_opLessThan"); } 
return bridgePINVOKE.AttackType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_opLessThan: ",e);}
throw e;
   }     
}
}


public int AttackType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_getID"); } 
return bridgePINVOKE.AttackType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_getID: ",e);}
throw e;
   }     
}
}


public string AttackType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackType_getName"); } 
return bridgePINVOKE.AttackType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackType_getName: ",e);}
throw e;
   }     
}
}


public void delete_AttackType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_AttackType"); } 
bridgePINVOKE.delete_AttackType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_AttackType: ",e);}
throw e;
   }     
}
}


public IntPtr getAttackType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getAttackType"); } 
return bridgePINVOKE.getAttackType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getAttackType: ",e);}
throw e;
   }     
}
}


public IntPtr allAttackTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allAttackTypes"); } 
return bridgePINVOKE.allAttackTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allAttackTypes: ",e);}
throw e;
   }     
}
}


public void initAttackTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initAttackTypes"); } 
bridgePINVOKE.initAttackTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initAttackTypes: ",e);}
throw e;
   }     
}
}


public IntPtr Melee_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Melee_get"); } 
return bridgePINVOKE.Melee_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Melee_get: ",e);}
throw e;
   }     
}
}


public IntPtr Fusion_Cutter_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Fusion_Cutter_Hit_get"); } 
return bridgePINVOKE.Fusion_Cutter_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Fusion_Cutter_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Gauss_Rifle_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gauss_Rifle_Hit_get"); } 
return bridgePINVOKE.Gauss_Rifle_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gauss_Rifle_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr C_10_Canister_Rifle_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - C_10_Canister_Rifle_Hit_get"); } 
return bridgePINVOKE.C_10_Canister_Rifle_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in C_10_Canister_Rifle_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeGemeni_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeGemeni_Missiles_get"); } 
return bridgePINVOKE.AttackTypeGemeni_Missiles_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeGemeni_Missiles_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeFragmentation_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeFragmentation_Grenade_get"); } 
return bridgePINVOKE.AttackTypeFragmentation_Grenade_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeFragmentation_Grenade_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeLongbolt_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeLongbolt_Missile_get"); } 
return bridgePINVOKE.AttackTypeLongbolt_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeLongbolt_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr ATS_ATA_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ATS_ATA_Laser_Battery_get"); } 
return bridgePINVOKE.ATS_ATA_Laser_Battery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ATS_ATA_Laser_Battery_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeBurst_Lasers_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeBurst_Lasers_get"); } 
return bridgePINVOKE.AttackTypeBurst_Lasers_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeBurst_Lasers_get: ",e);}
throw e;
   }     
}
}


public IntPtr Arclite_Shock_Cannon_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Arclite_Shock_Cannon_Hit_get"); } 
return bridgePINVOKE.Arclite_Shock_Cannon_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Arclite_Shock_Cannon_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr EMP_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - EMP_Missile_get"); } 
return bridgePINVOKE.EMP_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in EMP_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr Dual_Photon_Blasters_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Dual_Photon_Blasters_Hit_get"); } 
return bridgePINVOKE.Dual_Photon_Blasters_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Dual_Photon_Blasters_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Particle_Beam_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Particle_Beam_Hit_get"); } 
return bridgePINVOKE.Particle_Beam_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Particle_Beam_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Anti_Matter_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Anti_Matter_Missile_get"); } 
return bridgePINVOKE.Anti_Matter_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Anti_Matter_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypePulse_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypePulse_Cannon_get"); } 
return bridgePINVOKE.AttackTypePulse_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypePulse_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Psionic_Shockwave_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Psionic_Shockwave_Hit_get"); } 
return bridgePINVOKE.Psionic_Shockwave_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Psionic_Shockwave_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Psionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Psionic_Storm_get"); } 
return bridgePINVOKE.Psionic_Storm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Psionic_Storm_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeYamato_Gun_get"); } 
return bridgePINVOKE.AttackTypeYamato_Gun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeYamato_Gun_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypePhase_Disruptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypePhase_Disruptor_get"); } 
return bridgePINVOKE.AttackTypePhase_Disruptor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypePhase_Disruptor_get: ",e);}
throw e;
   }     
}
}


public IntPtr STA_STS_Cannon_Overlay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - STA_STS_Cannon_Overlay_get"); } 
return bridgePINVOKE.STA_STS_Cannon_Overlay_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in STA_STS_Cannon_Overlay_get: ",e);}
throw e;
   }     
}
}


public IntPtr Sunken_Colony_Tentacle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Sunken_Colony_Tentacle_get"); } 
return bridgePINVOKE.Sunken_Colony_Tentacle_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Sunken_Colony_Tentacle_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeAcid_Spore_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeAcid_Spore_get"); } 
return bridgePINVOKE.AttackTypeAcid_Spore_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeAcid_Spore_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeGlave_Wurm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeGlave_Wurm_get"); } 
return bridgePINVOKE.AttackTypeGlave_Wurm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeGlave_Wurm_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeSeeker_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSeeker_Spores_get"); } 
return bridgePINVOKE.AttackTypeSeeker_Spores_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSeeker_Spores_get: ",e);}
throw e;
   }     
}
}


public IntPtr Queen_Spell_Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Queen_Spell_Carrier_get"); } 
return bridgePINVOKE.Queen_Spell_Carrier_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Queen_Spell_Carrier_get: ",e);}
throw e;
   }     
}
}


public IntPtr Plague_Cloud_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Plague_Cloud_get"); } 
return bridgePINVOKE.Plague_Cloud_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Plague_Cloud_get: ",e);}
throw e;
   }     
}
}


public IntPtr Consume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Consume_get"); } 
return bridgePINVOKE.Consume_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Consume_get: ",e);}
throw e;
   }     
}
}


public IntPtr Needle_Spine_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Needle_Spine_Hit_get"); } 
return bridgePINVOKE.Needle_Spine_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Needle_Spine_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Invisible_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Invisible_get"); } 
return bridgePINVOKE.Invisible_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Invisible_get: ",e);}
throw e;
   }     
}
}


public IntPtr Optical_Flare_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Optical_Flare_Grenade_get"); } 
return bridgePINVOKE.Optical_Flare_Grenade_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Optical_Flare_Grenade_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeHalo_Rockets_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeHalo_Rockets_get"); } 
return bridgePINVOKE.AttackTypeHalo_Rockets_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeHalo_Rockets_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeSubterranean_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSubterranean_Spines_get"); } 
return bridgePINVOKE.AttackTypeSubterranean_Spines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSubterranean_Spines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Corrosive_Acid_Shot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Corrosive_Acid_Shot_get"); } 
return bridgePINVOKE.Corrosive_Acid_Shot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Corrosive_Acid_Shot_get: ",e);}
throw e;
   }     
}
}


public IntPtr Neutron_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Neutron_Flare_get"); } 
return bridgePINVOKE.Neutron_Flare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Neutron_Flare_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeNone_get"); } 
return bridgePINVOKE.AttackTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeUnknown_get"); } 
return bridgePINVOKE.AttackTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_Color__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Color__SWIG_0"); } 
return bridgePINVOKE.new_Color__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Color__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_Color__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Color__SWIG_1"); } 
return bridgePINVOKE.new_Color__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Color__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_Color__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Color__SWIG_2"); } 
return bridgePINVOKE.new_Color__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Color__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr new_Color__SWIG_3(int jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Color__SWIG_3"); } 
return bridgePINVOKE.new_Color__SWIG_3(jarg1, jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Color__SWIG_3: ",e);}
throw e;
   }     
}
}


public IntPtr Color_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_opAssign"); } 
return bridgePINVOKE.Color_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_opAssign: ",e);}
throw e;
   }     
}
}


public bool Color_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_opEquals"); } 
return bridgePINVOKE.Color_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_opEquals: ",e);}
throw e;
   }     
}
}


public bool Color_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_opNotEquals"); } 
return bridgePINVOKE.Color_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool Color_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_opLessThan"); } 
return bridgePINVOKE.Color_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_opLessThan: ",e);}
throw e;
   }     
}
}


public int Color_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_getID"); } 
return bridgePINVOKE.Color_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_getID: ",e);}
throw e;
   }     
}
}


public int Color_red(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_red"); } 
return bridgePINVOKE.Color_red(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_red: ",e);}
throw e;
   }     
}
}


public int Color_green(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_green"); } 
return bridgePINVOKE.Color_green(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_green: ",e);}
throw e;
   }     
}
}


public int Color_blue(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Color_blue"); } 
return bridgePINVOKE.Color_blue(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Color_blue: ",e);}
throw e;
   }     
}
}


public void delete_Color(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Color"); } 
bridgePINVOKE.delete_Color(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Color: ",e);}
throw e;
   }     
}
}


public void initColors( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initColors"); } 
bridgePINVOKE.initColors();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initColors: ",e);}
throw e;
   }     
}
}


public IntPtr Red_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Red_get"); } 
return bridgePINVOKE.Red_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Red_get: ",e);}
throw e;
   }     
}
}


public IntPtr Green_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Green_get"); } 
return bridgePINVOKE.Green_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Green_get: ",e);}
throw e;
   }     
}
}


public IntPtr Blue_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Blue_get"); } 
return bridgePINVOKE.Blue_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Blue_get: ",e);}
throw e;
   }     
}
}


public IntPtr Yellow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Yellow_get"); } 
return bridgePINVOKE.Yellow_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Yellow_get: ",e);}
throw e;
   }     
}
}


public IntPtr Cyan_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Cyan_get"); } 
return bridgePINVOKE.Cyan_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Cyan_get: ",e);}
throw e;
   }     
}
}


public IntPtr Purple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Purple_get"); } 
return bridgePINVOKE.Purple_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Purple_get: ",e);}
throw e;
   }     
}
}


public IntPtr Orange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Orange_get"); } 
return bridgePINVOKE.Orange_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Orange_get: ",e);}
throw e;
   }     
}
}


public IntPtr Black_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Black_get"); } 
return bridgePINVOKE.Black_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Black_get: ",e);}
throw e;
   }     
}
}


public IntPtr White_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - White_get"); } 
return bridgePINVOKE.White_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in White_get: ",e);}
throw e;
   }     
}
}


public IntPtr Grey_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Grey_get"); } 
return bridgePINVOKE.Grey_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Grey_get: ",e);}
throw e;
   }     
}
}


public int TILE_SIZE_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TILE_SIZE_get"); } 
return bridgePINVOKE.TILE_SIZE_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TILE_SIZE_get: ",e);}
throw e;
   }     
}
}


public int PYLON_X_RADIUS_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PYLON_X_RADIUS_get"); } 
return bridgePINVOKE.PYLON_X_RADIUS_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PYLON_X_RADIUS_get: ",e);}
throw e;
   }     
}
}


public int PYLON_Y_RADIUS_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PYLON_Y_RADIUS_get"); } 
return bridgePINVOKE.PYLON_Y_RADIUS_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PYLON_Y_RADIUS_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_DamageType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_DamageType__SWIG_0"); } 
return bridgePINVOKE.new_DamageType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_DamageType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_DamageType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_DamageType__SWIG_1"); } 
return bridgePINVOKE.new_DamageType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_DamageType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_DamageType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_DamageType__SWIG_2"); } 
return bridgePINVOKE.new_DamageType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_DamageType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr DamageType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_opAssign"); } 
return bridgePINVOKE.DamageType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_opAssign: ",e);}
throw e;
   }     
}
}


public bool DamageType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_opEquals"); } 
return bridgePINVOKE.DamageType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_opEquals: ",e);}
throw e;
   }     
}
}


public bool DamageType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_opNotEquals"); } 
return bridgePINVOKE.DamageType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool DamageType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_opLessThan"); } 
return bridgePINVOKE.DamageType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_opLessThan: ",e);}
throw e;
   }     
}
}


public int DamageType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_getID"); } 
return bridgePINVOKE.DamageType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_getID: ",e);}
throw e;
   }     
}
}


public string DamageType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageType_getName"); } 
return bridgePINVOKE.DamageType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageType_getName: ",e);}
throw e;
   }     
}
}


public void delete_DamageType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_DamageType"); } 
bridgePINVOKE.delete_DamageType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_DamageType: ",e);}
throw e;
   }     
}
}


public IntPtr getDamageType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getDamageType"); } 
return bridgePINVOKE.getDamageType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getDamageType: ",e);}
throw e;
   }     
}
}


public IntPtr allDamageTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allDamageTypes"); } 
return bridgePINVOKE.allDamageTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allDamageTypes: ",e);}
throw e;
   }     
}
}


public void initDamageTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initDamageTypes"); } 
bridgePINVOKE.initDamageTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initDamageTypes: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeIndependent_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeIndependent_get"); } 
return bridgePINVOKE.DamageTypeIndependent_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeIndependent_get: ",e);}
throw e;
   }     
}
}


public IntPtr Explosive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Explosive_get"); } 
return bridgePINVOKE.Explosive_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Explosive_get: ",e);}
throw e;
   }     
}
}


public IntPtr Concussive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Concussive_get"); } 
return bridgePINVOKE.Concussive_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Concussive_get: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeNormal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeNormal_get"); } 
return bridgePINVOKE.DamageTypeNormal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeNormal_get: ",e);}
throw e;
   }     
}
}


public IntPtr Ignore_Armor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Ignore_Armor_get"); } 
return bridgePINVOKE.Ignore_Armor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Ignore_Armor_get: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeNone_get"); } 
return bridgePINVOKE.DamageTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeUnknown_get"); } 
return bridgePINVOKE.DamageTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_Error__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Error__SWIG_0"); } 
return bridgePINVOKE.new_Error__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Error__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_Error__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Error__SWIG_1"); } 
return bridgePINVOKE.new_Error__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Error__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_Error__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Error__SWIG_2"); } 
return bridgePINVOKE.new_Error__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Error__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr Error_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_opAssign"); } 
return bridgePINVOKE.Error_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_opAssign: ",e);}
throw e;
   }     
}
}


public bool Error_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_opEquals"); } 
return bridgePINVOKE.Error_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_opEquals: ",e);}
throw e;
   }     
}
}


public bool Error_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_opNotEquals"); } 
return bridgePINVOKE.Error_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool Error_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_opLessThan"); } 
return bridgePINVOKE.Error_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_opLessThan: ",e);}
throw e;
   }     
}
}


public int Error_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_getID"); } 
return bridgePINVOKE.Error_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_getID: ",e);}
throw e;
   }     
}
}


public string Error_toErrorString(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Error_toErrorString"); } 
return bridgePINVOKE.Error_toErrorString(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Error_toErrorString: ",e);}
throw e;
   }     
}
}


public void delete_Error(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Error"); } 
bridgePINVOKE.delete_Error(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Error: ",e);}
throw e;
   }     
}
}


public IntPtr getError(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getError"); } 
return bridgePINVOKE.getError(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getError: ",e);}
throw e;
   }     
}
}


public IntPtr allErrors( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allErrors"); } 
return bridgePINVOKE.allErrors();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allErrors: ",e);}
throw e;
   }     
}
}


public void initErrors( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initErrors"); } 
bridgePINVOKE.initErrors();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initErrors: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_Does_Not_Exist_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_Does_Not_Exist_get"); } 
return bridgePINVOKE.Unit_Does_Not_Exist_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_Does_Not_Exist_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_Not_Visible_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_Not_Visible_get"); } 
return bridgePINVOKE.Unit_Not_Visible_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_Not_Visible_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_Not_Owned_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_Not_Owned_get"); } 
return bridgePINVOKE.Unit_Not_Owned_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_Not_Owned_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_Busy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_Busy_get"); } 
return bridgePINVOKE.Unit_Busy_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_Busy_get: ",e);}
throw e;
   }     
}
}


public IntPtr Incompatible_UnitType_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Incompatible_UnitType_get"); } 
return bridgePINVOKE.Incompatible_UnitType_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Incompatible_UnitType_get: ",e);}
throw e;
   }     
}
}


public IntPtr Incompatible_TechType_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Incompatible_TechType_get"); } 
return bridgePINVOKE.Incompatible_TechType_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Incompatible_TechType_get: ",e);}
throw e;
   }     
}
}


public IntPtr Already_Researched_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Already_Researched_get"); } 
return bridgePINVOKE.Already_Researched_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Already_Researched_get: ",e);}
throw e;
   }     
}
}


public IntPtr Fully_Upgraded_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Fully_Upgraded_get"); } 
return bridgePINVOKE.Fully_Upgraded_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Fully_Upgraded_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Minerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Minerals_get"); } 
return bridgePINVOKE.Insufficient_Minerals_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Minerals_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Gas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Gas_get"); } 
return bridgePINVOKE.Insufficient_Gas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Gas_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Supply_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Supply_get"); } 
return bridgePINVOKE.Insufficient_Supply_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Supply_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Energy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Energy_get"); } 
return bridgePINVOKE.Insufficient_Energy_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Energy_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Tech_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Tech_get"); } 
return bridgePINVOKE.Insufficient_Tech_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Tech_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Ammo_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Ammo_get"); } 
return bridgePINVOKE.Insufficient_Ammo_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Ammo_get: ",e);}
throw e;
   }     
}
}


public IntPtr Insufficient_Space_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Insufficient_Space_get"); } 
return bridgePINVOKE.Insufficient_Space_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Insufficient_Space_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unbuildable_Location_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unbuildable_Location_get"); } 
return bridgePINVOKE.Unbuildable_Location_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unbuildable_Location_get: ",e);}
throw e;
   }     
}
}


public IntPtr Out_Of_Range_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Out_Of_Range_get"); } 
return bridgePINVOKE.Out_Of_Range_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Out_Of_Range_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unable_To_Hit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unable_To_Hit_get"); } 
return bridgePINVOKE.Unable_To_Hit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unable_To_Hit_get: ",e);}
throw e;
   }     
}
}


public IntPtr Access_Denied_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Access_Denied_get"); } 
return bridgePINVOKE.Access_Denied_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Access_Denied_get: ",e);}
throw e;
   }     
}
}


public IntPtr ErrorNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorNone_get"); } 
return bridgePINVOKE.ErrorNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr ErrorUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorUnknown_get"); } 
return bridgePINVOKE.ErrorUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_ExplosionType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ExplosionType__SWIG_0"); } 
return bridgePINVOKE.new_ExplosionType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ExplosionType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_ExplosionType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ExplosionType__SWIG_1"); } 
return bridgePINVOKE.new_ExplosionType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ExplosionType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_ExplosionType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ExplosionType__SWIG_2"); } 
return bridgePINVOKE.new_ExplosionType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ExplosionType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_opAssign"); } 
return bridgePINVOKE.ExplosionType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_opAssign: ",e);}
throw e;
   }     
}
}


public bool ExplosionType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_opEquals"); } 
return bridgePINVOKE.ExplosionType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_opEquals: ",e);}
throw e;
   }     
}
}


public bool ExplosionType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_opNotEquals"); } 
return bridgePINVOKE.ExplosionType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool ExplosionType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_opLessThan"); } 
return bridgePINVOKE.ExplosionType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_opLessThan: ",e);}
throw e;
   }     
}
}


public int ExplosionType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_getID"); } 
return bridgePINVOKE.ExplosionType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_getID: ",e);}
throw e;
   }     
}
}


public string ExplosionType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionType_getName"); } 
return bridgePINVOKE.ExplosionType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionType_getName: ",e);}
throw e;
   }     
}
}


public void delete_ExplosionType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_ExplosionType"); } 
bridgePINVOKE.delete_ExplosionType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_ExplosionType: ",e);}
throw e;
   }     
}
}


public IntPtr getExplosionType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getExplosionType"); } 
return bridgePINVOKE.getExplosionType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getExplosionType: ",e);}
throw e;
   }     
}
}


public IntPtr allExplosionTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allExplosionTypes"); } 
return bridgePINVOKE.allExplosionTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allExplosionTypes: ",e);}
throw e;
   }     
}
}


public void initExplosionTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initExplosionTypes"); } 
bridgePINVOKE.initExplosionTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initExplosionTypes: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeNone_get"); } 
return bridgePINVOKE.ExplosionTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeNormal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeNormal_get"); } 
return bridgePINVOKE.ExplosionTypeNormal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeNormal_get: ",e);}
throw e;
   }     
}
}


public IntPtr Radial_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Radial_Splash_get"); } 
return bridgePINVOKE.Radial_Splash_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Radial_Splash_get: ",e);}
throw e;
   }     
}
}


public IntPtr Enemy_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Enemy_Splash_get"); } 
return bridgePINVOKE.Enemy_Splash_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Enemy_Splash_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeLockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeLockdown_get"); } 
return bridgePINVOKE.ExplosionTypeLockdown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeLockdown_get: ",e);}
throw e;
   }     
}
}


public IntPtr Nuclear_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Nuclear_Missile_get"); } 
return bridgePINVOKE.Nuclear_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Nuclear_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeParasite_get"); } 
return bridgePINVOKE.ExplosionTypeParasite_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeParasite_get: ",e);}
throw e;
   }     
}
}


public IntPtr Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Broodlings_get"); } 
return bridgePINVOKE.Broodlings_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Broodlings_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeEMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeEMP_Shockwave_get"); } 
return bridgePINVOKE.ExplosionTypeEMP_Shockwave_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeEMP_Shockwave_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeIrradiate_get"); } 
return bridgePINVOKE.ExplosionTypeIrradiate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeIrradiate_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeEnsnare_get"); } 
return bridgePINVOKE.ExplosionTypeEnsnare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeEnsnare_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypePlague_get"); } 
return bridgePINVOKE.ExplosionTypePlague_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypePlague_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeStasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeStasis_Field_get"); } 
return bridgePINVOKE.ExplosionTypeStasis_Field_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeStasis_Field_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeDark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeDark_Swarm_get"); } 
return bridgePINVOKE.ExplosionTypeDark_Swarm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeDark_Swarm_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeConsume_get"); } 
return bridgePINVOKE.ExplosionTypeConsume_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeConsume_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeYamato_Gun_get"); } 
return bridgePINVOKE.ExplosionTypeYamato_Gun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeYamato_Gun_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeRestoration_get"); } 
return bridgePINVOKE.ExplosionTypeRestoration_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeRestoration_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeDisruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeDisruption_Web_get"); } 
return bridgePINVOKE.ExplosionTypeDisruption_Web_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeDisruption_Web_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeCorrosive_Acid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeCorrosive_Acid_get"); } 
return bridgePINVOKE.ExplosionTypeCorrosive_Acid_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeCorrosive_Acid_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeMind_Control_get"); } 
return bridgePINVOKE.ExplosionTypeMind_Control_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeMind_Control_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeFeedback_get"); } 
return bridgePINVOKE.ExplosionTypeFeedback_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeFeedback_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeOptical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeOptical_Flare_get"); } 
return bridgePINVOKE.ExplosionTypeOptical_Flare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeOptical_Flare_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeMaelstrom_get"); } 
return bridgePINVOKE.ExplosionTypeMaelstrom_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeMaelstrom_get: ",e);}
throw e;
   }     
}
}


public IntPtr Air_Splash_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Air_Splash_get"); } 
return bridgePINVOKE.Air_Splash_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Air_Splash_get: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeUnknown_get"); } 
return bridgePINVOKE.ExplosionTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public int FLAG_COUNT_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - FLAG_COUNT_get"); } 
return bridgePINVOKE.FLAG_COUNT_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in FLAG_COUNT_get: ",e);}
throw e;
   }     
}
}


public string Force_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Force_getName"); } 
return bridgePINVOKE.Force_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Force_getName: ",e);}
throw e;
   }     
}
}


public IntPtr Force_getPlayers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Force_getPlayers"); } 
return bridgePINVOKE.Force_getPlayers(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Force_getPlayers: ",e);}
throw e;
   }     
}
}


public void delete_Force(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Force"); } 
bridgePINVOKE.delete_Force(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Force: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getForces(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getForces"); } 
return bridgePINVOKE.Game_getForces(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getForces: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getPlayers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getPlayers"); } 
return bridgePINVOKE.Game_getPlayers(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getPlayers: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getAllUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getAllUnits"); } 
return bridgePINVOKE.Game_getAllUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getAllUnits: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMinerals"); } 
return bridgePINVOKE.Game_getMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMinerals: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getGeysers"); } 
return bridgePINVOKE.Game_getGeysers(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getGeysers: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getNeutralUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getNeutralUnits"); } 
return bridgePINVOKE.Game_getNeutralUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getNeutralUnits: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getStaticMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getStaticMinerals"); } 
return bridgePINVOKE.Game_getStaticMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getStaticMinerals: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getStaticGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getStaticGeysers"); } 
return bridgePINVOKE.Game_getStaticGeysers(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getStaticGeysers: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getStaticNeutralUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getStaticNeutralUnits"); } 
return bridgePINVOKE.Game_getStaticNeutralUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getStaticNeutralUnits: ",e);}
throw e;
   }     
}
}


public int Game_getLatency(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getLatency"); } 
return bridgePINVOKE.Game_getLatency(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getLatency: ",e);}
throw e;
   }     
}
}


public int Game_getFrameCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getFrameCount"); } 
return bridgePINVOKE.Game_getFrameCount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getFrameCount: ",e);}
throw e;
   }     
}
}


public int Game_getMouseX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMouseX"); } 
return bridgePINVOKE.Game_getMouseX(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMouseX: ",e);}
throw e;
   }     
}
}


public int Game_getMouseY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMouseY"); } 
return bridgePINVOKE.Game_getMouseY(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMouseY: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getMousePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMousePosition"); } 
return bridgePINVOKE.Game_getMousePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMousePosition: ",e);}
throw e;
   }     
}
}


public bool Game_getMouseState__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMouseState__SWIG_0"); } 
return bridgePINVOKE.Game_getMouseState__SWIG_0(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMouseState__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_getMouseState__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMouseState__SWIG_1"); } 
return bridgePINVOKE.Game_getMouseState__SWIG_1(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMouseState__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_getKeyState__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getKeyState__SWIG_0"); } 
return bridgePINVOKE.Game_getKeyState__SWIG_0(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getKeyState__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_getKeyState__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getKeyState__SWIG_1"); } 
return bridgePINVOKE.Game_getKeyState__SWIG_1(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getKeyState__SWIG_1: ",e);}
throw e;
   }     
}
}


public int Game_getScreenX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getScreenX"); } 
return bridgePINVOKE.Game_getScreenX(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getScreenX: ",e);}
throw e;
   }     
}
}


public int Game_getScreenY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getScreenY"); } 
return bridgePINVOKE.Game_getScreenY(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getScreenY: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getScreenPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getScreenPosition"); } 
return bridgePINVOKE.Game_getScreenPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getScreenPosition: ",e);}
throw e;
   }     
}
}


public void Game_setScreenPosition__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_setScreenPosition__SWIG_0"); } 
bridgePINVOKE.Game_setScreenPosition__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_setScreenPosition__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_setScreenPosition__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_setScreenPosition__SWIG_1"); } 
bridgePINVOKE.Game_setScreenPosition__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_setScreenPosition__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_pingMinimap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_pingMinimap__SWIG_0"); } 
bridgePINVOKE.Game_pingMinimap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_pingMinimap__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_pingMinimap__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_pingMinimap__SWIG_1"); } 
bridgePINVOKE.Game_pingMinimap__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_pingMinimap__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_isFlagEnabled(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isFlagEnabled"); } 
return bridgePINVOKE.Game_isFlagEnabled(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isFlagEnabled: ",e);}
throw e;
   }     
}
}


public void Game_enableFlag(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_enableFlag"); } 
bridgePINVOKE.Game_enableFlag(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_enableFlag: ",e);}
throw e;
   }     
}
}


public IntPtr Game_unitsOnTile(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_unitsOnTile"); } 
return bridgePINVOKE.Game_unitsOnTile(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_unitsOnTile: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getLastError(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getLastError"); } 
return bridgePINVOKE.Game_getLastError(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getLastError: ",e);}
throw e;
   }     
}
}


public int Game_mapWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_mapWidth"); } 
return bridgePINVOKE.Game_mapWidth(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_mapWidth: ",e);}
throw e;
   }     
}
}


public int Game_mapHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_mapHeight"); } 
return bridgePINVOKE.Game_mapHeight(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_mapHeight: ",e);}
throw e;
   }     
}
}


public string Game_mapFilename(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_mapFilename"); } 
return bridgePINVOKE.Game_mapFilename(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_mapFilename: ",e);}
throw e;
   }     
}
}


public string Game_mapName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_mapName"); } 
return bridgePINVOKE.Game_mapName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_mapName: ",e);}
throw e;
   }     
}
}


public int Game_getMapHash(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getMapHash"); } 
return bridgePINVOKE.Game_getMapHash(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getMapHash: ",e);}
throw e;
   }     
}
}


public int Game_getGroundHeight(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getGroundHeight"); } 
return bridgePINVOKE.Game_getGroundHeight(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getGroundHeight: ",e);}
throw e;
   }     
}
}


public bool Game_isWalkable(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isWalkable"); } 
return bridgePINVOKE.Game_isWalkable(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isWalkable: ",e);}
throw e;
   }     
}
}


public bool Game_isBuildable__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isBuildable__SWIG_0"); } 
return bridgePINVOKE.Game_isBuildable__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isBuildable__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_isVisible__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isVisible__SWIG_0"); } 
return bridgePINVOKE.Game_isVisible__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isVisible__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_isExplored__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isExplored__SWIG_0"); } 
return bridgePINVOKE.Game_isExplored__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isExplored__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_hasCreep__SWIG_0(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_hasCreep__SWIG_0"); } 
return bridgePINVOKE.Game_hasCreep__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_hasCreep__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_hasPower__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_hasPower__SWIG_0"); } 
return bridgePINVOKE.Game_hasPower__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_hasPower__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Game_isBuildable__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isBuildable__SWIG_1"); } 
return bridgePINVOKE.Game_isBuildable__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isBuildable__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_isVisible__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isVisible__SWIG_1"); } 
return bridgePINVOKE.Game_isVisible__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isVisible__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_isExplored__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isExplored__SWIG_1"); } 
return bridgePINVOKE.Game_isExplored__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isExplored__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_hasCreep__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_hasCreep__SWIG_1"); } 
return bridgePINVOKE.Game_hasCreep__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_hasCreep__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_hasPower__SWIG_1(IntPtr jarg1, IntPtr jarg2, int jarg3, int jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_hasPower__SWIG_1"); } 
return bridgePINVOKE.Game_hasPower__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3, jarg4);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_hasPower__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Game_canBuildHere(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_canBuildHere"); } 
return bridgePINVOKE.Game_canBuildHere(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3), new HandleRef(null,jarg4));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_canBuildHere: ",e);}
throw e;
   }     
}
}


public bool Game_canMake(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_canMake"); } 
return bridgePINVOKE.Game_canMake(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_canMake: ",e);}
throw e;
   }     
}
}


public bool Game_canResearch(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_canResearch"); } 
return bridgePINVOKE.Game_canResearch(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_canResearch: ",e);}
throw e;
   }     
}
}


public bool Game_canUpgrade(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_canUpgrade"); } 
return bridgePINVOKE.Game_canUpgrade(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_canUpgrade: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getStartLocations(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getStartLocations"); } 
return bridgePINVOKE.Game_getStartLocations(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getStartLocations: ",e);}
throw e;
   }     
}
}


public void Game_printf(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_printf"); } 
bridgePINVOKE.Game_printf(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_printf: ",e);}
throw e;
   }     
}
}


public void Game_sendText(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_sendText"); } 
bridgePINVOKE.Game_sendText(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_sendText: ",e);}
throw e;
   }     
}
}


public void Game_changeRace(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_changeRace"); } 
bridgePINVOKE.Game_changeRace(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_changeRace: ",e);}
throw e;
   }     
}
}


public bool Game_isMultiplayer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isMultiplayer"); } 
return bridgePINVOKE.Game_isMultiplayer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isMultiplayer: ",e);}
throw e;
   }     
}
}


public bool Game_isPaused(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isPaused"); } 
return bridgePINVOKE.Game_isPaused(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isPaused: ",e);}
throw e;
   }     
}
}


public bool Game_isReplay(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_isReplay"); } 
return bridgePINVOKE.Game_isReplay(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_isReplay: ",e);}
throw e;
   }     
}
}


public void Game_startGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_startGame"); } 
bridgePINVOKE.Game_startGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_startGame: ",e);}
throw e;
   }     
}
}


public void Game_pauseGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_pauseGame"); } 
bridgePINVOKE.Game_pauseGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_pauseGame: ",e);}
throw e;
   }     
}
}


public void Game_resumeGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_resumeGame"); } 
bridgePINVOKE.Game_resumeGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_resumeGame: ",e);}
throw e;
   }     
}
}


public void Game_leaveGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_leaveGame"); } 
bridgePINVOKE.Game_leaveGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_leaveGame: ",e);}
throw e;
   }     
}
}


public void Game_restartGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_restartGame"); } 
bridgePINVOKE.Game_restartGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_restartGame: ",e);}
throw e;
   }     
}
}


public void Game_setLocalSpeed__SWIG_0(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_setLocalSpeed__SWIG_0"); } 
bridgePINVOKE.Game_setLocalSpeed__SWIG_0(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_setLocalSpeed__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_setLocalSpeed__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_setLocalSpeed__SWIG_1"); } 
bridgePINVOKE.Game_setLocalSpeed__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_setLocalSpeed__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr Game_getSelectedUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_getSelectedUnits"); } 
return bridgePINVOKE.Game_getSelectedUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_getSelectedUnits: ",e);}
throw e;
   }     
}
}


public IntPtr Game_self(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_self"); } 
return bridgePINVOKE.Game_self(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_self: ",e);}
throw e;
   }     
}
}


public IntPtr Game_enemy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_enemy"); } 
return bridgePINVOKE.Game_enemy(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_enemy: ",e);}
throw e;
   }     
}
}


public void Game_drawText(IntPtr jarg1, int jarg2, int jarg3, int jarg4, string jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawText"); } 
bridgePINVOKE.Game_drawText(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawText: ",e);}
throw e;
   }     
}
}


public void Game_drawTextMap(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTextMap"); } 
bridgePINVOKE.Game_drawTextMap(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTextMap: ",e);}
throw e;
   }     
}
}


public void Game_drawTextMouse(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTextMouse"); } 
bridgePINVOKE.Game_drawTextMouse(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTextMouse: ",e);}
throw e;
   }     
}
}


public void Game_drawTextScreen(IntPtr jarg1, int jarg2, int jarg3, string jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTextScreen"); } 
bridgePINVOKE.Game_drawTextScreen(new HandleRef(null,jarg1), jarg2, jarg3, jarg4);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTextScreen: ",e);}
throw e;
   }     
}
}


public void Game_drawBox__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7, bool jarg8) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBox__SWIG_0"); } 
bridgePINVOKE.Game_drawBox__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7), jarg8);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBox__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawBox__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBox__SWIG_1"); } 
bridgePINVOKE.Game_drawBox__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBox__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxMap__SWIG_0"); } 
bridgePINVOKE.Game_drawBoxMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxMap__SWIG_1"); } 
bridgePINVOKE.Game_drawBoxMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxMouse__SWIG_0"); } 
bridgePINVOKE.Game_drawBoxMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxMouse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxMouse__SWIG_1"); } 
bridgePINVOKE.Game_drawBoxMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxMouse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxScreen__SWIG_0"); } 
bridgePINVOKE.Game_drawBoxScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxScreen__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawBoxScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawBoxScreen__SWIG_1"); } 
bridgePINVOKE.Game_drawBoxScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawBoxScreen__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangle__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, IntPtr jarg9, bool jarg10) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangle__SWIG_0"); } 
bridgePINVOKE.Game_drawTriangle__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, new HandleRef(null,jarg9), jarg10);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangle__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangle__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, int jarg8, IntPtr jarg9) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangle__SWIG_1"); } 
bridgePINVOKE.Game_drawTriangle__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, jarg8, new HandleRef(null,jarg9));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangle__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleMap__SWIG_0"); } 
bridgePINVOKE.Game_drawTriangleMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleMap__SWIG_1"); } 
bridgePINVOKE.Game_drawTriangleMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleMouse__SWIG_0"); } 
bridgePINVOKE.Game_drawTriangleMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleMouse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleMouse__SWIG_1"); } 
bridgePINVOKE.Game_drawTriangleMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleMouse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8, bool jarg9) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleScreen__SWIG_0"); } 
bridgePINVOKE.Game_drawTriangleScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8), jarg9);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleScreen__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawTriangleScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, IntPtr jarg8) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawTriangleScreen__SWIG_1"); } 
bridgePINVOKE.Game_drawTriangleScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, jarg7, new HandleRef(null,jarg8));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawTriangleScreen__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawCircle__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircle__SWIG_0"); } 
bridgePINVOKE.Game_drawCircle__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircle__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawCircle__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircle__SWIG_1"); } 
bridgePINVOKE.Game_drawCircle__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircle__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleMap__SWIG_0"); } 
bridgePINVOKE.Game_drawCircleMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleMap__SWIG_1"); } 
bridgePINVOKE.Game_drawCircleMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleMouse__SWIG_0"); } 
bridgePINVOKE.Game_drawCircleMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleMouse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleMouse__SWIG_1"); } 
bridgePINVOKE.Game_drawCircleMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleMouse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5, bool jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleScreen__SWIG_0"); } 
bridgePINVOKE.Game_drawCircleScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5), jarg6);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleScreen__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawCircleScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawCircleScreen__SWIG_1"); } 
bridgePINVOKE.Game_drawCircleScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawCircleScreen__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7, bool jarg8) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipse__SWIG_0"); } 
bridgePINVOKE.Game_drawEllipse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7), jarg8);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipse__SWIG_1"); } 
bridgePINVOKE.Game_drawEllipse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseMap__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseMap__SWIG_0"); } 
bridgePINVOKE.Game_drawEllipseMap__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseMap__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseMap__SWIG_1"); } 
bridgePINVOKE.Game_drawEllipseMap__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseMouse__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseMouse__SWIG_0"); } 
bridgePINVOKE.Game_drawEllipseMouse__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseMouse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseMouse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseMouse__SWIG_1"); } 
bridgePINVOKE.Game_drawEllipseMouse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseMouse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseScreen__SWIG_0(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, bool jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseScreen__SWIG_0"); } 
bridgePINVOKE.Game_drawEllipseScreen__SWIG_0(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6), jarg7);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseScreen__SWIG_0: ",e);}
throw e;
   }     
}
}


public void Game_drawEllipseScreen__SWIG_1(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawEllipseScreen__SWIG_1"); } 
bridgePINVOKE.Game_drawEllipseScreen__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawEllipseScreen__SWIG_1: ",e);}
throw e;
   }     
}
}


public void Game_drawDot(IntPtr jarg1, int jarg2, int jarg3, int jarg4, IntPtr jarg5) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawDot"); } 
bridgePINVOKE.Game_drawDot(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, new HandleRef(null,jarg5));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawDot: ",e);}
throw e;
   }     
}
}


public void Game_drawDotMap(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawDotMap"); } 
bridgePINVOKE.Game_drawDotMap(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawDotMap: ",e);}
throw e;
   }     
}
}


public void Game_drawDotMouse(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawDotMouse"); } 
bridgePINVOKE.Game_drawDotMouse(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawDotMouse: ",e);}
throw e;
   }     
}
}


public void Game_drawDotScreen(IntPtr jarg1, int jarg2, int jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawDotScreen"); } 
bridgePINVOKE.Game_drawDotScreen(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawDotScreen: ",e);}
throw e;
   }     
}
}


public void Game_drawLine(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr jarg7) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawLine"); } 
bridgePINVOKE.Game_drawLine(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, jarg6, new HandleRef(null,jarg7));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawLine: ",e);}
throw e;
   }     
}
}


public void Game_drawLineMap(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawLineMap"); } 
bridgePINVOKE.Game_drawLineMap(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawLineMap: ",e);}
throw e;
   }     
}
}


public void Game_drawLineMouse(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawLineMouse"); } 
bridgePINVOKE.Game_drawLineMouse(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawLineMouse: ",e);}
throw e;
   }     
}
}


public void Game_drawLineScreen(IntPtr jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Game_drawLineScreen"); } 
bridgePINVOKE.Game_drawLineScreen(new HandleRef(null,jarg1), jarg2, jarg3, jarg4, jarg5, new HandleRef(null,jarg6));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Game_drawLineScreen: ",e);}
throw e;
   }     
}
}


public void delete_Game(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Game"); } 
bridgePINVOKE.delete_Game(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Game: ",e);}
throw e;
   }     
}
}


public void Broodwar_set(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Broodwar_set"); } 
bridgePINVOKE.Broodwar_set(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Broodwar_set: ",e);}
throw e;
   }     
}
}


public IntPtr Broodwar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Broodwar_get"); } 
return bridgePINVOKE.Broodwar_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Broodwar_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_Order__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Order__SWIG_0"); } 
return bridgePINVOKE.new_Order__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Order__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_Order__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Order__SWIG_1"); } 
return bridgePINVOKE.new_Order__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Order__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_Order__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Order__SWIG_2"); } 
return bridgePINVOKE.new_Order__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Order__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr Order_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_opAssign"); } 
return bridgePINVOKE.Order_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_opAssign: ",e);}
throw e;
   }     
}
}


public bool Order_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_opEquals"); } 
return bridgePINVOKE.Order_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_opEquals: ",e);}
throw e;
   }     
}
}


public bool Order_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_opNotEquals"); } 
return bridgePINVOKE.Order_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool Order_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_opLessThan"); } 
return bridgePINVOKE.Order_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_opLessThan: ",e);}
throw e;
   }     
}
}


public int Order_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_getID"); } 
return bridgePINVOKE.Order_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_getID: ",e);}
throw e;
   }     
}
}


public string Order_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Order_getName"); } 
return bridgePINVOKE.Order_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Order_getName: ",e);}
throw e;
   }     
}
}


public void delete_Order(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Order"); } 
bridgePINVOKE.delete_Order(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Order: ",e);}
throw e;
   }     
}
}


public IntPtr getOrder(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getOrder"); } 
return bridgePINVOKE.getOrder(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getOrder: ",e);}
throw e;
   }     
}
}


public IntPtr allOrders( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allOrders"); } 
return bridgePINVOKE.allOrders();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allOrders: ",e);}
throw e;
   }     
}
}


public void initOrders( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initOrders"); } 
bridgePINVOKE.initOrders();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initOrders: ",e);}
throw e;
   }     
}
}


public IntPtr Die_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Die_get"); } 
return bridgePINVOKE.Die_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Die_get: ",e);}
throw e;
   }     
}
}


public IntPtr Stop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Stop_get"); } 
return bridgePINVOKE.Stop_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Stop_get: ",e);}
throw e;
   }     
}
}


public IntPtr Guard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Guard_get"); } 
return bridgePINVOKE.Guard_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Guard_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerGuard_get"); } 
return bridgePINVOKE.PlayerGuard_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerGuard_get: ",e);}
throw e;
   }     
}
}


public IntPtr TurretGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TurretGuard_get"); } 
return bridgePINVOKE.TurretGuard_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TurretGuard_get: ",e);}
throw e;
   }     
}
}


public IntPtr BunkerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BunkerGuard_get"); } 
return bridgePINVOKE.BunkerGuard_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BunkerGuard_get: ",e);}
throw e;
   }     
}
}


public IntPtr Move_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Move_get"); } 
return bridgePINVOKE.Move_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Move_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReaverStop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReaverStop_get"); } 
return bridgePINVOKE.ReaverStop_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReaverStop_get: ",e);}
throw e;
   }     
}
}


public IntPtr Attack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Attack1_get"); } 
return bridgePINVOKE.Attack1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Attack1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Attack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Attack2_get"); } 
return bridgePINVOKE.Attack2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Attack2_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackUnit_get"); } 
return bridgePINVOKE.AttackUnit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackUnit_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackFixedRange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackFixedRange_get"); } 
return bridgePINVOKE.AttackFixedRange_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackFixedRange_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTile_get"); } 
return bridgePINVOKE.AttackTile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTile_get: ",e);}
throw e;
   }     
}
}


public IntPtr Hover_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Hover_get"); } 
return bridgePINVOKE.Hover_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Hover_get: ",e);}
throw e;
   }     
}
}


public IntPtr AttackMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackMove_get"); } 
return bridgePINVOKE.AttackMove_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackMove_get: ",e);}
throw e;
   }     
}
}


public IntPtr InfestMine1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InfestMine1_get"); } 
return bridgePINVOKE.InfestMine1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InfestMine1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Nothing1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Nothing1_get"); } 
return bridgePINVOKE.Nothing1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Nothing1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Powerup1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Powerup1_get"); } 
return bridgePINVOKE.Powerup1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Powerup1_get: ",e);}
throw e;
   }     
}
}


public IntPtr TowerGuard_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TowerGuard_get"); } 
return bridgePINVOKE.TowerGuard_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TowerGuard_get: ",e);}
throw e;
   }     
}
}


public IntPtr TowerAttack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TowerAttack_get"); } 
return bridgePINVOKE.TowerAttack_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TowerAttack_get: ",e);}
throw e;
   }     
}
}


public IntPtr VultureMine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - VultureMine_get"); } 
return bridgePINVOKE.VultureMine_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in VultureMine_get: ",e);}
throw e;
   }     
}
}


public IntPtr StayinRange_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - StayinRange_get"); } 
return bridgePINVOKE.StayinRange_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in StayinRange_get: ",e);}
throw e;
   }     
}
}


public IntPtr TurretAttack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TurretAttack_get"); } 
return bridgePINVOKE.TurretAttack_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TurretAttack_get: ",e);}
throw e;
   }     
}
}


public IntPtr Nothing2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Nothing2_get"); } 
return bridgePINVOKE.Nothing2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Nothing2_get: ",e);}
throw e;
   }     
}
}


public IntPtr Nothing3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Nothing3_get"); } 
return bridgePINVOKE.Nothing3_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Nothing3_get: ",e);}
throw e;
   }     
}
}


public IntPtr DroneStartBuild_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DroneStartBuild_get"); } 
return bridgePINVOKE.DroneStartBuild_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DroneStartBuild_get: ",e);}
throw e;
   }     
}
}


public IntPtr DroneBuild_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DroneBuild_get"); } 
return bridgePINVOKE.DroneBuild_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DroneBuild_get: ",e);}
throw e;
   }     
}
}


public IntPtr InfestMine2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InfestMine2_get"); } 
return bridgePINVOKE.InfestMine2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InfestMine2_get: ",e);}
throw e;
   }     
}
}


public IntPtr InfestMine3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InfestMine3_get"); } 
return bridgePINVOKE.InfestMine3_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InfestMine3_get: ",e);}
throw e;
   }     
}
}


public IntPtr InfestMine4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InfestMine4_get"); } 
return bridgePINVOKE.InfestMine4_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InfestMine4_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildTerran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildTerran_get"); } 
return bridgePINVOKE.BuildTerran_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildTerran_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildProtoss1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildProtoss1_get"); } 
return bridgePINVOKE.BuildProtoss1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildProtoss1_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildProtoss2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildProtoss2_get"); } 
return bridgePINVOKE.BuildProtoss2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildProtoss2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ConstructingBuilding_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ConstructingBuilding_get"); } 
return bridgePINVOKE.ConstructingBuilding_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ConstructingBuilding_get: ",e);}
throw e;
   }     
}
}


public IntPtr Repair1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Repair1_get"); } 
return bridgePINVOKE.Repair1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Repair1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Repair2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Repair2_get"); } 
return bridgePINVOKE.Repair2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Repair2_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlaceAddon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlaceAddon_get"); } 
return bridgePINVOKE.PlaceAddon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlaceAddon_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildAddon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildAddon_get"); } 
return bridgePINVOKE.BuildAddon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildAddon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Train_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Train_get"); } 
return bridgePINVOKE.Train_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Train_get: ",e);}
throw e;
   }     
}
}


public IntPtr RallyPoint1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RallyPoint1_get"); } 
return bridgePINVOKE.RallyPoint1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RallyPoint1_get: ",e);}
throw e;
   }     
}
}


public IntPtr RallyPoint2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RallyPoint2_get"); } 
return bridgePINVOKE.RallyPoint2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RallyPoint2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ZergBirth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ZergBirth_get"); } 
return bridgePINVOKE.ZergBirth_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ZergBirth_get: ",e);}
throw e;
   }     
}
}


public IntPtr Morph1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Morph1_get"); } 
return bridgePINVOKE.Morph1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Morph1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Morph2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Morph2_get"); } 
return bridgePINVOKE.Morph2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Morph2_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildSelf1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildSelf1_get"); } 
return bridgePINVOKE.BuildSelf1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildSelf1_get: ",e);}
throw e;
   }     
}
}


public IntPtr ZergBuildSelf_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ZergBuildSelf_get"); } 
return bridgePINVOKE.ZergBuildSelf_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ZergBuildSelf_get: ",e);}
throw e;
   }     
}
}


public IntPtr Build5_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Build5_get"); } 
return bridgePINVOKE.Build5_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Build5_get: ",e);}
throw e;
   }     
}
}


public IntPtr Enternyduscanal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Enternyduscanal_get"); } 
return bridgePINVOKE.Enternyduscanal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Enternyduscanal_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildSelf2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildSelf2_get"); } 
return bridgePINVOKE.BuildSelf2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildSelf2_get: ",e);}
throw e;
   }     
}
}


public IntPtr Follow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Follow_get"); } 
return bridgePINVOKE.Follow_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Follow_get: ",e);}
throw e;
   }     
}
}


public IntPtr Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Carrier_get"); } 
return bridgePINVOKE.Carrier_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Carrier_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierIgnore1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierIgnore1_get"); } 
return bridgePINVOKE.CarrierIgnore1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierIgnore1_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierStop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierStop_get"); } 
return bridgePINVOKE.CarrierStop_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierStop_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierAttack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierAttack1_get"); } 
return bridgePINVOKE.CarrierAttack1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierAttack1_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierAttack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierAttack2_get"); } 
return bridgePINVOKE.CarrierAttack2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierAttack2_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierIgnore2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierIgnore2_get"); } 
return bridgePINVOKE.CarrierIgnore2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierIgnore2_get: ",e);}
throw e;
   }     
}
}


public IntPtr CarrierFight_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CarrierFight_get"); } 
return bridgePINVOKE.CarrierFight_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CarrierFight_get: ",e);}
throw e;
   }     
}
}


public IntPtr HoldPosition1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HoldPosition1_get"); } 
return bridgePINVOKE.HoldPosition1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HoldPosition1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Reaver_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Reaver_get"); } 
return bridgePINVOKE.Reaver_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Reaver_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReaverAttack1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReaverAttack1_get"); } 
return bridgePINVOKE.ReaverAttack1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReaverAttack1_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReaverAttack2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReaverAttack2_get"); } 
return bridgePINVOKE.ReaverAttack2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReaverAttack2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReaverFight_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReaverFight_get"); } 
return bridgePINVOKE.ReaverFight_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReaverFight_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReaverHold_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReaverHold_get"); } 
return bridgePINVOKE.ReaverHold_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReaverHold_get: ",e);}
throw e;
   }     
}
}


public IntPtr TrainFighter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TrainFighter_get"); } 
return bridgePINVOKE.TrainFighter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TrainFighter_get: ",e);}
throw e;
   }     
}
}


public IntPtr StrafeUnit1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - StrafeUnit1_get"); } 
return bridgePINVOKE.StrafeUnit1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in StrafeUnit1_get: ",e);}
throw e;
   }     
}
}


public IntPtr StrafeUnit2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - StrafeUnit2_get"); } 
return bridgePINVOKE.StrafeUnit2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in StrafeUnit2_get: ",e);}
throw e;
   }     
}
}


public IntPtr RechargeShields1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RechargeShields1_get"); } 
return bridgePINVOKE.RechargeShields1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RechargeShields1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Rechargeshields2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Rechargeshields2_get"); } 
return bridgePINVOKE.Rechargeshields2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Rechargeshields2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ShieldBattery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ShieldBattery_get"); } 
return bridgePINVOKE.ShieldBattery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ShieldBattery_get: ",e);}
throw e;
   }     
}
}


public IntPtr Return_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Return_get"); } 
return bridgePINVOKE.Return_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Return_get: ",e);}
throw e;
   }     
}
}


public IntPtr DroneLand_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DroneLand_get"); } 
return bridgePINVOKE.DroneLand_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DroneLand_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildingLand_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildingLand_get"); } 
return bridgePINVOKE.BuildingLand_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildingLand_get: ",e);}
throw e;
   }     
}
}


public IntPtr BuildingLiftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BuildingLiftoff_get"); } 
return bridgePINVOKE.BuildingLiftoff_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BuildingLiftoff_get: ",e);}
throw e;
   }     
}
}


public IntPtr DroneLiftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DroneLiftoff_get"); } 
return bridgePINVOKE.DroneLiftoff_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DroneLiftoff_get: ",e);}
throw e;
   }     
}
}


public IntPtr Liftoff_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Liftoff_get"); } 
return bridgePINVOKE.Liftoff_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Liftoff_get: ",e);}
throw e;
   }     
}
}


public IntPtr ResearchTech_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ResearchTech_get"); } 
return bridgePINVOKE.ResearchTech_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ResearchTech_get: ",e);}
throw e;
   }     
}
}


public IntPtr Upgrade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Upgrade_get"); } 
return bridgePINVOKE.Upgrade_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Upgrade_get: ",e);}
throw e;
   }     
}
}


public IntPtr Larva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Larva_get"); } 
return bridgePINVOKE.Larva_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Larva_get: ",e);}
throw e;
   }     
}
}


public IntPtr SpawningLarva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SpawningLarva_get"); } 
return bridgePINVOKE.SpawningLarva_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SpawningLarva_get: ",e);}
throw e;
   }     
}
}


public IntPtr Harvest1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Harvest1_get"); } 
return bridgePINVOKE.Harvest1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Harvest1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Harvest2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Harvest2_get"); } 
return bridgePINVOKE.Harvest2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Harvest2_get: ",e);}
throw e;
   }     
}
}


public IntPtr MoveToGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MoveToGas_get"); } 
return bridgePINVOKE.MoveToGas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MoveToGas_get: ",e);}
throw e;
   }     
}
}


public IntPtr WaitForGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WaitForGas_get"); } 
return bridgePINVOKE.WaitForGas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WaitForGas_get: ",e);}
throw e;
   }     
}
}


public IntPtr HarvestGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HarvestGas_get"); } 
return bridgePINVOKE.HarvestGas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HarvestGas_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReturnGas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReturnGas_get"); } 
return bridgePINVOKE.ReturnGas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReturnGas_get: ",e);}
throw e;
   }     
}
}


public IntPtr MoveToMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MoveToMinerals_get"); } 
return bridgePINVOKE.MoveToMinerals_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MoveToMinerals_get: ",e);}
throw e;
   }     
}
}


public IntPtr WaitForMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WaitForMinerals_get"); } 
return bridgePINVOKE.WaitForMinerals_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WaitForMinerals_get: ",e);}
throw e;
   }     
}
}


public IntPtr MiningMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MiningMinerals_get"); } 
return bridgePINVOKE.MiningMinerals_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MiningMinerals_get: ",e);}
throw e;
   }     
}
}


public IntPtr Harvest3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Harvest3_get"); } 
return bridgePINVOKE.Harvest3_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Harvest3_get: ",e);}
throw e;
   }     
}
}


public IntPtr Harvest4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Harvest4_get"); } 
return bridgePINVOKE.Harvest4_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Harvest4_get: ",e);}
throw e;
   }     
}
}


public IntPtr ReturnMinerals_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ReturnMinerals_get"); } 
return bridgePINVOKE.ReturnMinerals_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ReturnMinerals_get: ",e);}
throw e;
   }     
}
}


public IntPtr Harvest5_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Harvest5_get"); } 
return bridgePINVOKE.Harvest5_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Harvest5_get: ",e);}
throw e;
   }     
}
}


public IntPtr EnterTransport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - EnterTransport_get"); } 
return bridgePINVOKE.EnterTransport_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in EnterTransport_get: ",e);}
throw e;
   }     
}
}


public IntPtr Pickup1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Pickup1_get"); } 
return bridgePINVOKE.Pickup1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Pickup1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Pickup2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Pickup2_get"); } 
return bridgePINVOKE.Pickup2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Pickup2_get: ",e);}
throw e;
   }     
}
}


public IntPtr Pickup3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Pickup3_get"); } 
return bridgePINVOKE.Pickup3_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Pickup3_get: ",e);}
throw e;
   }     
}
}


public IntPtr Pickup4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Pickup4_get"); } 
return bridgePINVOKE.Pickup4_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Pickup4_get: ",e);}
throw e;
   }     
}
}


public IntPtr Powerup2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Powerup2_get"); } 
return bridgePINVOKE.Powerup2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Powerup2_get: ",e);}
throw e;
   }     
}
}


public IntPtr SiegeMode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SiegeMode_get"); } 
return bridgePINVOKE.SiegeMode_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SiegeMode_get: ",e);}
throw e;
   }     
}
}


public IntPtr TankMode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TankMode_get"); } 
return bridgePINVOKE.TankMode_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TankMode_get: ",e);}
throw e;
   }     
}
}


public IntPtr WatchTarget_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WatchTarget_get"); } 
return bridgePINVOKE.WatchTarget_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WatchTarget_get: ",e);}
throw e;
   }     
}
}


public IntPtr InitCreepGrowth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InitCreepGrowth_get"); } 
return bridgePINVOKE.InitCreepGrowth_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InitCreepGrowth_get: ",e);}
throw e;
   }     
}
}


public IntPtr SpreadCreep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SpreadCreep_get"); } 
return bridgePINVOKE.SpreadCreep_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SpreadCreep_get: ",e);}
throw e;
   }     
}
}


public IntPtr StoppingCreepGrowth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - StoppingCreepGrowth_get"); } 
return bridgePINVOKE.StoppingCreepGrowth_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in StoppingCreepGrowth_get: ",e);}
throw e;
   }     
}
}


public IntPtr GuardianAspect_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - GuardianAspect_get"); } 
return bridgePINVOKE.GuardianAspect_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in GuardianAspect_get: ",e);}
throw e;
   }     
}
}


public IntPtr WarpingArchon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WarpingArchon_get"); } 
return bridgePINVOKE.WarpingArchon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WarpingArchon_get: ",e);}
throw e;
   }     
}
}


public IntPtr CompletingArchonsummon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CompletingArchonsummon_get"); } 
return bridgePINVOKE.CompletingArchonsummon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CompletingArchonsummon_get: ",e);}
throw e;
   }     
}
}


public IntPtr HoldPosition2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HoldPosition2_get"); } 
return bridgePINVOKE.HoldPosition2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HoldPosition2_get: ",e);}
throw e;
   }     
}
}


public IntPtr HoldPosition3_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HoldPosition3_get"); } 
return bridgePINVOKE.HoldPosition3_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HoldPosition3_get: ",e);}
throw e;
   }     
}
}


public IntPtr Cloak_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Cloak_get"); } 
return bridgePINVOKE.Cloak_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Cloak_get: ",e);}
throw e;
   }     
}
}


public IntPtr Decloak_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Decloak_get"); } 
return bridgePINVOKE.Decloak_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Decloak_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unload_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unload_get"); } 
return bridgePINVOKE.Unload_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unload_get: ",e);}
throw e;
   }     
}
}


public IntPtr MoveUnload_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MoveUnload_get"); } 
return bridgePINVOKE.MoveUnload_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MoveUnload_get: ",e);}
throw e;
   }     
}
}


public IntPtr FireYamatoGun1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - FireYamatoGun1_get"); } 
return bridgePINVOKE.FireYamatoGun1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in FireYamatoGun1_get: ",e);}
throw e;
   }     
}
}


public IntPtr FireYamatoGun2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - FireYamatoGun2_get"); } 
return bridgePINVOKE.FireYamatoGun2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in FireYamatoGun2_get: ",e);}
throw e;
   }     
}
}


public IntPtr MagnaPulse_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MagnaPulse_get"); } 
return bridgePINVOKE.MagnaPulse_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MagnaPulse_get: ",e);}
throw e;
   }     
}
}


public IntPtr Burrow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Burrow_get"); } 
return bridgePINVOKE.Burrow_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Burrow_get: ",e);}
throw e;
   }     
}
}


public IntPtr Burrowed_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Burrowed_get"); } 
return bridgePINVOKE.Burrowed_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Burrowed_get: ",e);}
throw e;
   }     
}
}


public IntPtr Unburrow_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unburrow_get"); } 
return bridgePINVOKE.Unburrow_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unburrow_get: ",e);}
throw e;
   }     
}
}


public IntPtr DarkSwarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DarkSwarm_get"); } 
return bridgePINVOKE.DarkSwarm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DarkSwarm_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastParasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastParasite_get"); } 
return bridgePINVOKE.CastParasite_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastParasite_get: ",e);}
throw e;
   }     
}
}


public IntPtr SummonBroodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SummonBroodlings_get"); } 
return bridgePINVOKE.SummonBroodlings_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SummonBroodlings_get: ",e);}
throw e;
   }     
}
}


public IntPtr EmpShockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - EmpShockwave_get"); } 
return bridgePINVOKE.EmpShockwave_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in EmpShockwave_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeWait_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeWait_get"); } 
return bridgePINVOKE.NukeWait_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeWait_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeTrain_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeTrain_get"); } 
return bridgePINVOKE.NukeTrain_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeTrain_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeLaunch_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeLaunch_get"); } 
return bridgePINVOKE.NukeLaunch_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeLaunch_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukePaint_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukePaint_get"); } 
return bridgePINVOKE.NukePaint_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukePaint_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeUnit_get"); } 
return bridgePINVOKE.NukeUnit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeUnit_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeGround_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeGround_get"); } 
return bridgePINVOKE.NukeGround_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeGround_get: ",e);}
throw e;
   }     
}
}


public IntPtr NukeTrack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NukeTrack_get"); } 
return bridgePINVOKE.NukeTrack_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NukeTrack_get: ",e);}
throw e;
   }     
}
}


public IntPtr InitArbiter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InitArbiter_get"); } 
return bridgePINVOKE.InitArbiter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InitArbiter_get: ",e);}
throw e;
   }     
}
}


public IntPtr CloakNearbyUnits_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CloakNearbyUnits_get"); } 
return bridgePINVOKE.CloakNearbyUnits_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CloakNearbyUnits_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlaceMine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlaceMine_get"); } 
return bridgePINVOKE.PlaceMine_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlaceMine_get: ",e);}
throw e;
   }     
}
}


public IntPtr Rightclickaction_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Rightclickaction_get"); } 
return bridgePINVOKE.Rightclickaction_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Rightclickaction_get: ",e);}
throw e;
   }     
}
}


public IntPtr SapUnit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SapUnit_get"); } 
return bridgePINVOKE.SapUnit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SapUnit_get: ",e);}
throw e;
   }     
}
}


public IntPtr SapLocation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SapLocation_get"); } 
return bridgePINVOKE.SapLocation_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SapLocation_get: ",e);}
throw e;
   }     
}
}


public IntPtr HoldPosition4_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HoldPosition4_get"); } 
return bridgePINVOKE.HoldPosition4_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HoldPosition4_get: ",e);}
throw e;
   }     
}
}


public IntPtr Teleport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Teleport_get"); } 
return bridgePINVOKE.Teleport_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Teleport_get: ",e);}
throw e;
   }     
}
}


public IntPtr TeleporttoLocation_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TeleporttoLocation_get"); } 
return bridgePINVOKE.TeleporttoLocation_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TeleporttoLocation_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlaceScanner_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlaceScanner_get"); } 
return bridgePINVOKE.PlaceScanner_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlaceScanner_get: ",e);}
throw e;
   }     
}
}


public IntPtr Scanner_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Scanner_get"); } 
return bridgePINVOKE.Scanner_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Scanner_get: ",e);}
throw e;
   }     
}
}


public IntPtr DefensiveMatrix_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DefensiveMatrix_get"); } 
return bridgePINVOKE.DefensiveMatrix_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DefensiveMatrix_get: ",e);}
throw e;
   }     
}
}


public IntPtr PsiStorm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PsiStorm_get"); } 
return bridgePINVOKE.PsiStorm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PsiStorm_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderIrradiate_get"); } 
return bridgePINVOKE.OrderIrradiate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderIrradiate_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderPlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderPlague_get"); } 
return bridgePINVOKE.OrderPlague_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderPlague_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderConsume_get"); } 
return bridgePINVOKE.OrderConsume_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderConsume_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderEnsnare_get"); } 
return bridgePINVOKE.OrderEnsnare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderEnsnare_get: ",e);}
throw e;
   }     
}
}


public IntPtr StasisField_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - StasisField_get"); } 
return bridgePINVOKE.StasisField_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in StasisField_get: ",e);}
throw e;
   }     
}
}


public IntPtr Hallucination1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Hallucination1_get"); } 
return bridgePINVOKE.Hallucination1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Hallucination1_get: ",e);}
throw e;
   }     
}
}


public IntPtr Hallucination2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Hallucination2_get"); } 
return bridgePINVOKE.Hallucination2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Hallucination2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ResetCollision1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ResetCollision1_get"); } 
return bridgePINVOKE.ResetCollision1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ResetCollision1_get: ",e);}
throw e;
   }     
}
}


public IntPtr ResetCollision2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ResetCollision2_get"); } 
return bridgePINVOKE.ResetCollision2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ResetCollision2_get: ",e);}
throw e;
   }     
}
}


public IntPtr Patrol_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Patrol_get"); } 
return bridgePINVOKE.Patrol_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Patrol_get: ",e);}
throw e;
   }     
}
}


public IntPtr CTFCOPInit_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CTFCOPInit_get"); } 
return bridgePINVOKE.CTFCOPInit_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CTFCOPInit_get: ",e);}
throw e;
   }     
}
}


public IntPtr CTFCOP1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CTFCOP1_get"); } 
return bridgePINVOKE.CTFCOP1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CTFCOP1_get: ",e);}
throw e;
   }     
}
}


public IntPtr CTFCOP2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CTFCOP2_get"); } 
return bridgePINVOKE.CTFCOP2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CTFCOP2_get: ",e);}
throw e;
   }     
}
}


public IntPtr ComputerAI_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ComputerAI_get"); } 
return bridgePINVOKE.ComputerAI_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ComputerAI_get: ",e);}
throw e;
   }     
}
}


public IntPtr AtkMoveEP_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AtkMoveEP_get"); } 
return bridgePINVOKE.AtkMoveEP_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AtkMoveEP_get: ",e);}
throw e;
   }     
}
}


public IntPtr HarassMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HarassMove_get"); } 
return bridgePINVOKE.HarassMove_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HarassMove_get: ",e);}
throw e;
   }     
}
}


public IntPtr AIPatrol_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AIPatrol_get"); } 
return bridgePINVOKE.AIPatrol_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AIPatrol_get: ",e);}
throw e;
   }     
}
}


public IntPtr GuardPost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - GuardPost_get"); } 
return bridgePINVOKE.GuardPost_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in GuardPost_get: ",e);}
throw e;
   }     
}
}


public IntPtr RescuePassive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RescuePassive_get"); } 
return bridgePINVOKE.RescuePassive_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RescuePassive_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderNeutral_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderNeutral_get"); } 
return bridgePINVOKE.OrderNeutral_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderNeutral_get: ",e);}
throw e;
   }     
}
}


public IntPtr ComputerReturn_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ComputerReturn_get"); } 
return bridgePINVOKE.ComputerReturn_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ComputerReturn_get: ",e);}
throw e;
   }     
}
}


public IntPtr InitPsiProvider_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - InitPsiProvider_get"); } 
return bridgePINVOKE.InitPsiProvider_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in InitPsiProvider_get: ",e);}
throw e;
   }     
}
}


public IntPtr SelfDestrucing_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - SelfDestrucing_get"); } 
return bridgePINVOKE.SelfDestrucing_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in SelfDestrucing_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_get"); } 
return bridgePINVOKE.Critter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_get: ",e);}
throw e;
   }     
}
}


public IntPtr HiddenGun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HiddenGun_get"); } 
return bridgePINVOKE.HiddenGun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HiddenGun_get: ",e);}
throw e;
   }     
}
}


public IntPtr OpenDoor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OpenDoor_get"); } 
return bridgePINVOKE.OpenDoor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OpenDoor_get: ",e);}
throw e;
   }     
}
}


public IntPtr CloseDoor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CloseDoor_get"); } 
return bridgePINVOKE.CloseDoor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CloseDoor_get: ",e);}
throw e;
   }     
}
}


public IntPtr HideTrap_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HideTrap_get"); } 
return bridgePINVOKE.HideTrap_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HideTrap_get: ",e);}
throw e;
   }     
}
}


public IntPtr RevealTrap_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RevealTrap_get"); } 
return bridgePINVOKE.RevealTrap_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RevealTrap_get: ",e);}
throw e;
   }     
}
}


public IntPtr Enabledoodad_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Enabledoodad_get"); } 
return bridgePINVOKE.Enabledoodad_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Enabledoodad_get: ",e);}
throw e;
   }     
}
}


public IntPtr Disabledoodad_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Disabledoodad_get"); } 
return bridgePINVOKE.Disabledoodad_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Disabledoodad_get: ",e);}
throw e;
   }     
}
}


public IntPtr Warpin_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Warpin_get"); } 
return bridgePINVOKE.Warpin_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Warpin_get: ",e);}
throw e;
   }     
}
}


public IntPtr Medic_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Medic_get"); } 
return bridgePINVOKE.Medic_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Medic_get: ",e);}
throw e;
   }     
}
}


public IntPtr MedicHeal1_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MedicHeal1_get"); } 
return bridgePINVOKE.MedicHeal1_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MedicHeal1_get: ",e);}
throw e;
   }     
}
}


public IntPtr HealMove_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HealMove_get"); } 
return bridgePINVOKE.HealMove_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HealMove_get: ",e);}
throw e;
   }     
}
}


public IntPtr MedicHoldPosition_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MedicHoldPosition_get"); } 
return bridgePINVOKE.MedicHoldPosition_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MedicHoldPosition_get: ",e);}
throw e;
   }     
}
}


public IntPtr MedicHeal2_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - MedicHeal2_get"); } 
return bridgePINVOKE.MedicHeal2_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in MedicHeal2_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderRestoration_get"); } 
return bridgePINVOKE.OrderRestoration_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderRestoration_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastDisruptionWeb_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastDisruptionWeb_get"); } 
return bridgePINVOKE.CastDisruptionWeb_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastDisruptionWeb_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastMindControl_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastMindControl_get"); } 
return bridgePINVOKE.CastMindControl_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastMindControl_get: ",e);}
throw e;
   }     
}
}


public IntPtr WarpingDarkArchon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WarpingDarkArchon_get"); } 
return bridgePINVOKE.WarpingDarkArchon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WarpingDarkArchon_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastFeedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastFeedback_get"); } 
return bridgePINVOKE.CastFeedback_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastFeedback_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastOpticalFlare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastOpticalFlare_get"); } 
return bridgePINVOKE.CastOpticalFlare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastOpticalFlare_get: ",e);}
throw e;
   }     
}
}


public IntPtr CastMaelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - CastMaelstrom_get"); } 
return bridgePINVOKE.CastMaelstrom_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in CastMaelstrom_get: ",e);}
throw e;
   }     
}
}


public IntPtr JunkYardDog_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - JunkYardDog_get"); } 
return bridgePINVOKE.JunkYardDog_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in JunkYardDog_get: ",e);}
throw e;
   }     
}
}


public IntPtr Fatal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Fatal_get"); } 
return bridgePINVOKE.Fatal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Fatal_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderNone_get"); } 
return bridgePINVOKE.OrderNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr OrderUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderUnknown_get"); } 
return bridgePINVOKE.OrderUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerType__SWIG_0"); } 
return bridgePINVOKE.new_PlayerType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerType__SWIG_1"); } 
return bridgePINVOKE.new_PlayerType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerType__SWIG_2"); } 
return bridgePINVOKE.new_PlayerType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_opAssign"); } 
return bridgePINVOKE.PlayerType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_opAssign: ",e);}
throw e;
   }     
}
}


public bool PlayerType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_opEquals"); } 
return bridgePINVOKE.PlayerType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_opEquals: ",e);}
throw e;
   }     
}
}


public bool PlayerType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_opNotEquals"); } 
return bridgePINVOKE.PlayerType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool PlayerType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_opLessThan"); } 
return bridgePINVOKE.PlayerType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_opLessThan: ",e);}
throw e;
   }     
}
}


public int PlayerType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_getID"); } 
return bridgePINVOKE.PlayerType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_getID: ",e);}
throw e;
   }     
}
}


public string PlayerType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerType_getName"); } 
return bridgePINVOKE.PlayerType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerType_getName: ",e);}
throw e;
   }     
}
}


public void delete_PlayerType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PlayerType"); } 
bridgePINVOKE.delete_PlayerType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PlayerType: ",e);}
throw e;
   }     
}
}


public IntPtr getPlayerType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getPlayerType"); } 
return bridgePINVOKE.getPlayerType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getPlayerType: ",e);}
throw e;
   }     
}
}


public IntPtr allPlayerTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allPlayerTypes"); } 
return bridgePINVOKE.allPlayerTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allPlayerTypes: ",e);}
throw e;
   }     
}
}


public void initPlayerTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initPlayerTypes"); } 
bridgePINVOKE.initPlayerTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initPlayerTypes: ",e);}
throw e;
   }     
}
}


public IntPtr NotUsed_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - NotUsed_get"); } 
return bridgePINVOKE.NotUsed_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in NotUsed_get: ",e);}
throw e;
   }     
}
}


public IntPtr Computer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Computer_get"); } 
return bridgePINVOKE.Computer_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Computer_get: ",e);}
throw e;
   }     
}
}


public IntPtr Human_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Human_get"); } 
return bridgePINVOKE.Human_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Human_get: ",e);}
throw e;
   }     
}
}


public IntPtr Rescuable_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Rescuable_get"); } 
return bridgePINVOKE.Rescuable_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Rescuable_get: ",e);}
throw e;
   }     
}
}


public IntPtr ComputerSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ComputerSlot_get"); } 
return bridgePINVOKE.ComputerSlot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ComputerSlot_get: ",e);}
throw e;
   }     
}
}


public IntPtr OpenSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OpenSlot_get"); } 
return bridgePINVOKE.OpenSlot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OpenSlot_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeNeutral_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeNeutral_get"); } 
return bridgePINVOKE.PlayerTypeNeutral_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeNeutral_get: ",e);}
throw e;
   }     
}
}


public IntPtr ClosedSlot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ClosedSlot_get"); } 
return bridgePINVOKE.ClosedSlot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ClosedSlot_get: ",e);}
throw e;
   }     
}
}


public IntPtr HumanDefeated_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - HumanDefeated_get"); } 
return bridgePINVOKE.HumanDefeated_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in HumanDefeated_get: ",e);}
throw e;
   }     
}
}


public IntPtr ComputerDefeated_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ComputerDefeated_get"); } 
return bridgePINVOKE.ComputerDefeated_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ComputerDefeated_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeNone_get"); } 
return bridgePINVOKE.PlayerTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeUnknown_get"); } 
return bridgePINVOKE.PlayerTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public int Player_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getID"); } 
return bridgePINVOKE.Player_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getID: ",e);}
throw e;
   }     
}
}


public string Player_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getName"); } 
return bridgePINVOKE.Player_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getName: ",e);}
throw e;
   }     
}
}


public IntPtr Player_getUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getUnits"); } 
return bridgePINVOKE.Player_getUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getUnits: ",e);}
throw e;
   }     
}
}


public IntPtr Player_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getRace"); } 
return bridgePINVOKE.Player_getRace(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getRace: ",e);}
throw e;
   }     
}
}


public IntPtr Player_playerType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_playerType"); } 
return bridgePINVOKE.Player_playerType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_playerType: ",e);}
throw e;
   }     
}
}


public IntPtr Player_getForce(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getForce"); } 
return bridgePINVOKE.Player_getForce(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getForce: ",e);}
throw e;
   }     
}
}


public bool Player_isAlly(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isAlly"); } 
return bridgePINVOKE.Player_isAlly(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isAlly: ",e);}
throw e;
   }     
}
}


public bool Player_isEnemy(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isEnemy"); } 
return bridgePINVOKE.Player_isEnemy(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isEnemy: ",e);}
throw e;
   }     
}
}


public bool Player_isNeutral(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isNeutral"); } 
return bridgePINVOKE.Player_isNeutral(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isNeutral: ",e);}
throw e;
   }     
}
}


public IntPtr Player_getStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getStartLocation"); } 
return bridgePINVOKE.Player_getStartLocation(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getStartLocation: ",e);}
throw e;
   }     
}
}


public bool Player_isVictorious(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isVictorious"); } 
return bridgePINVOKE.Player_isVictorious(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isVictorious: ",e);}
throw e;
   }     
}
}


public bool Player_isDefeated(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isDefeated"); } 
return bridgePINVOKE.Player_isDefeated(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isDefeated: ",e);}
throw e;
   }     
}
}


public bool Player_leftGame(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_leftGame"); } 
return bridgePINVOKE.Player_leftGame(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_leftGame: ",e);}
throw e;
   }     
}
}


public int Player_minerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_minerals"); } 
return bridgePINVOKE.Player_minerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_minerals: ",e);}
throw e;
   }     
}
}


public int Player_gas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_gas"); } 
return bridgePINVOKE.Player_gas(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_gas: ",e);}
throw e;
   }     
}
}


public int Player_cumulativeMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_cumulativeMinerals"); } 
return bridgePINVOKE.Player_cumulativeMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_cumulativeMinerals: ",e);}
throw e;
   }     
}
}


public int Player_cumulativeGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_cumulativeGas"); } 
return bridgePINVOKE.Player_cumulativeGas(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_cumulativeGas: ",e);}
throw e;
   }     
}
}


public int Player_supplyTotal__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_supplyTotal__SWIG_0"); } 
return bridgePINVOKE.Player_supplyTotal__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_supplyTotal__SWIG_0: ",e);}
throw e;
   }     
}
}


public int Player_supplyUsed__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_supplyUsed__SWIG_0"); } 
return bridgePINVOKE.Player_supplyUsed__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_supplyUsed__SWIG_0: ",e);}
throw e;
   }     
}
}


public int Player_supplyTotal__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_supplyTotal__SWIG_1"); } 
return bridgePINVOKE.Player_supplyTotal__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_supplyTotal__SWIG_1: ",e);}
throw e;
   }     
}
}


public int Player_supplyUsed__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_supplyUsed__SWIG_1"); } 
return bridgePINVOKE.Player_supplyUsed__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_supplyUsed__SWIG_1: ",e);}
throw e;
   }     
}
}


public int Player_allUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_allUnitCount"); } 
return bridgePINVOKE.Player_allUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_allUnitCount: ",e);}
throw e;
   }     
}
}


public int Player_completedUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_completedUnitCount"); } 
return bridgePINVOKE.Player_completedUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_completedUnitCount: ",e);}
throw e;
   }     
}
}


public int Player_incompleteUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_incompleteUnitCount"); } 
return bridgePINVOKE.Player_incompleteUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_incompleteUnitCount: ",e);}
throw e;
   }     
}
}


public int Player_deadUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_deadUnitCount"); } 
return bridgePINVOKE.Player_deadUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_deadUnitCount: ",e);}
throw e;
   }     
}
}


public int Player_killedUnitCount(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_killedUnitCount"); } 
return bridgePINVOKE.Player_killedUnitCount(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_killedUnitCount: ",e);}
throw e;
   }     
}
}


public int Player_getUpgradeLevel(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_getUpgradeLevel"); } 
return bridgePINVOKE.Player_getUpgradeLevel(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_getUpgradeLevel: ",e);}
throw e;
   }     
}
}


public bool Player_hasResearched(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_hasResearched"); } 
return bridgePINVOKE.Player_hasResearched(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_hasResearched: ",e);}
throw e;
   }     
}
}


public bool Player_isResearching(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isResearching"); } 
return bridgePINVOKE.Player_isResearching(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isResearching: ",e);}
throw e;
   }     
}
}


public bool Player_isUpgrading(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Player_isUpgrading"); } 
return bridgePINVOKE.Player_isUpgrading(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Player_isUpgrading: ",e);}
throw e;
   }     
}
}


public void delete_Player(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Player"); } 
bridgePINVOKE.delete_Player(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Player: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePosition__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePosition__SWIG_0"); } 
return bridgePINVOKE.new_TilePosition__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePosition__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePosition__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePosition__SWIG_1"); } 
return bridgePINVOKE.new_TilePosition__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePosition__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePosition__SWIG_2(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePosition__SWIG_2"); } 
return bridgePINVOKE.new_TilePosition__SWIG_2(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePosition__SWIG_2: ",e);}
throw e;
   }     
}
}


public bool TilePosition_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opEquals"); } 
return bridgePINVOKE.TilePosition_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opEquals: ",e);}
throw e;
   }     
}
}


public bool TilePosition_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opNotEquals"); } 
return bridgePINVOKE.TilePosition_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool TilePosition_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opLessThan"); } 
return bridgePINVOKE.TilePosition_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opLessThan: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_opPlus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opPlus"); } 
return bridgePINVOKE.TilePosition_opPlus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opPlus: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_opMinus(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opMinus"); } 
return bridgePINVOKE.TilePosition_opMinus(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opMinus: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_opAdd(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opAdd"); } 
return bridgePINVOKE.TilePosition_opAdd(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opAdd: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_opSubtract(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_opSubtract"); } 
return bridgePINVOKE.TilePosition_opSubtract(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_opSubtract: ",e);}
throw e;
   }     
}
}


public double TilePosition_getDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_getDistance"); } 
return bridgePINVOKE.TilePosition_getDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_getDistance: ",e);}
throw e;
   }     
}
}


public double TilePosition_getLength(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_getLength"); } 
return bridgePINVOKE.TilePosition_getLength(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_getLength: ",e);}
throw e;
   }     
}
}


public bool TilePosition_isValid(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_isValid"); } 
return bridgePINVOKE.TilePosition_isValid(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_isValid: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_x(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_x"); } 
return bridgePINVOKE.TilePosition_x(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_x: ",e);}
throw e;
   }     
}
}


public IntPtr TilePosition_y(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_y"); } 
return bridgePINVOKE.TilePosition_y(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_y: ",e);}
throw e;
   }     
}
}


public int TilePosition_xConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_xConst"); } 
return bridgePINVOKE.TilePosition_xConst(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_xConst: ",e);}
throw e;
   }     
}
}


public int TilePosition_yConst(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePosition_yConst"); } 
return bridgePINVOKE.TilePosition_yConst(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePosition_yConst: ",e);}
throw e;
   }     
}
}


public void delete_TilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TilePosition"); } 
bridgePINVOKE.delete_TilePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TilePosition: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionInvalid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionInvalid_get"); } 
return bridgePINVOKE.TilePositionInvalid_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionInvalid_get: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionNone_get"); } 
return bridgePINVOKE.TilePositionNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionUnknown_get"); } 
return bridgePINVOKE.TilePositionUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionUnknown_get: ",e);}
throw e;
   }     
}
}


public int Unit_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getID"); } 
return bridgePINVOKE.Unit_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getID: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getPlayer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getPlayer"); } 
return bridgePINVOKE.Unit_getPlayer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getPlayer: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getType"); } 
return bridgePINVOKE.Unit_getType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getType: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getInitialType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInitialType"); } 
return bridgePINVOKE.Unit_getInitialType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInitialType: ",e);}
throw e;
   }     
}
}


public int Unit_getHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getHitPoints"); } 
return bridgePINVOKE.Unit_getHitPoints(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getHitPoints: ",e);}
throw e;
   }     
}
}


public int Unit_getInitialHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInitialHitPoints"); } 
return bridgePINVOKE.Unit_getInitialHitPoints(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInitialHitPoints: ",e);}
throw e;
   }     
}
}


public int Unit_getShields(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getShields"); } 
return bridgePINVOKE.Unit_getShields(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getShields: ",e);}
throw e;
   }     
}
}


public int Unit_getEnergy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getEnergy"); } 
return bridgePINVOKE.Unit_getEnergy(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getEnergy: ",e);}
throw e;
   }     
}
}


public int Unit_getResources(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getResources"); } 
return bridgePINVOKE.Unit_getResources(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getResources: ",e);}
throw e;
   }     
}
}


public int Unit_getInitialResources(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInitialResources"); } 
return bridgePINVOKE.Unit_getInitialResources(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInitialResources: ",e);}
throw e;
   }     
}
}


public int Unit_getKillCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getKillCount"); } 
return bridgePINVOKE.Unit_getKillCount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getKillCount: ",e);}
throw e;
   }     
}
}


public int Unit_getGroundWeaponCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getGroundWeaponCooldown"); } 
return bridgePINVOKE.Unit_getGroundWeaponCooldown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getGroundWeaponCooldown: ",e);}
throw e;
   }     
}
}


public int Unit_getAirWeaponCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getAirWeaponCooldown"); } 
return bridgePINVOKE.Unit_getAirWeaponCooldown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getAirWeaponCooldown: ",e);}
throw e;
   }     
}
}


public int Unit_getSpellCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getSpellCooldown"); } 
return bridgePINVOKE.Unit_getSpellCooldown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getSpellCooldown: ",e);}
throw e;
   }     
}
}


public int Unit_getDefenseMatrixPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getDefenseMatrixPoints"); } 
return bridgePINVOKE.Unit_getDefenseMatrixPoints(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getDefenseMatrixPoints: ",e);}
throw e;
   }     
}
}


public int Unit_getDefenseMatrixTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getDefenseMatrixTimer"); } 
return bridgePINVOKE.Unit_getDefenseMatrixTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getDefenseMatrixTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getEnsnareTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getEnsnareTimer"); } 
return bridgePINVOKE.Unit_getEnsnareTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getEnsnareTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getIrradiateTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getIrradiateTimer"); } 
return bridgePINVOKE.Unit_getIrradiateTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getIrradiateTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getLockdownTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getLockdownTimer"); } 
return bridgePINVOKE.Unit_getLockdownTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getLockdownTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getMaelstromTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getMaelstromTimer"); } 
return bridgePINVOKE.Unit_getMaelstromTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getMaelstromTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getPlagueTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getPlagueTimer"); } 
return bridgePINVOKE.Unit_getPlagueTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getPlagueTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getRemoveTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRemoveTimer"); } 
return bridgePINVOKE.Unit_getRemoveTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRemoveTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getStasisTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getStasisTimer"); } 
return bridgePINVOKE.Unit_getStasisTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getStasisTimer: ",e);}
throw e;
   }     
}
}


public int Unit_getStimTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getStimTimer"); } 
return bridgePINVOKE.Unit_getStimTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getStimTimer: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getPosition"); } 
return bridgePINVOKE.Unit_getPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getPosition: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getInitialPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInitialPosition"); } 
return bridgePINVOKE.Unit_getInitialPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInitialPosition: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTilePosition"); } 
return bridgePINVOKE.Unit_getTilePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTilePosition: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getInitialTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInitialTilePosition"); } 
return bridgePINVOKE.Unit_getInitialTilePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInitialTilePosition: ",e);}
throw e;
   }     
}
}


public double Unit_getDistance__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getDistance__SWIG_0"); } 
return bridgePINVOKE.Unit_getDistance__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getDistance__SWIG_0: ",e);}
throw e;
   }     
}
}


public double Unit_getDistance__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getDistance__SWIG_1"); } 
return bridgePINVOKE.Unit_getDistance__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getDistance__SWIG_1: ",e);}
throw e;
   }     
}
}


public double Unit_getAngle(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getAngle"); } 
return bridgePINVOKE.Unit_getAngle(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getAngle: ",e);}
throw e;
   }     
}
}


public double Unit_getVelocityX(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getVelocityX"); } 
return bridgePINVOKE.Unit_getVelocityX(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getVelocityX: ",e);}
throw e;
   }     
}
}


public double Unit_getVelocityY(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getVelocityY"); } 
return bridgePINVOKE.Unit_getVelocityY(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getVelocityY: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTarget(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTarget"); } 
return bridgePINVOKE.Unit_getTarget(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTarget: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTargetPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTargetPosition"); } 
return bridgePINVOKE.Unit_getTargetPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTargetPosition: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getOrder(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getOrder"); } 
return bridgePINVOKE.Unit_getOrder(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getOrder: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getOrderTarget(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getOrderTarget"); } 
return bridgePINVOKE.Unit_getOrderTarget(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getOrderTarget: ",e);}
throw e;
   }     
}
}


public int Unit_getOrderTimer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getOrderTimer"); } 
return bridgePINVOKE.Unit_getOrderTimer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getOrderTimer: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getSecondaryOrder(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getSecondaryOrder"); } 
return bridgePINVOKE.Unit_getSecondaryOrder(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getSecondaryOrder: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getBuildUnit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getBuildUnit"); } 
return bridgePINVOKE.Unit_getBuildUnit(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getBuildUnit: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getBuildType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getBuildType"); } 
return bridgePINVOKE.Unit_getBuildType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getBuildType: ",e);}
throw e;
   }     
}
}


public int Unit_getRemainingBuildTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRemainingBuildTime"); } 
return bridgePINVOKE.Unit_getRemainingBuildTime(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRemainingBuildTime: ",e);}
throw e;
   }     
}
}


public int Unit_getRemainingTrainTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRemainingTrainTime"); } 
return bridgePINVOKE.Unit_getRemainingTrainTime(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRemainingTrainTime: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getChild(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getChild"); } 
return bridgePINVOKE.Unit_getChild(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getChild: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTrainingQueue(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTrainingQueue"); } 
return bridgePINVOKE.Unit_getTrainingQueue(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTrainingQueue: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTransport(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTransport"); } 
return bridgePINVOKE.Unit_getTransport(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTransport: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getLoadedUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getLoadedUnits"); } 
return bridgePINVOKE.Unit_getLoadedUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getLoadedUnits: ",e);}
throw e;
   }     
}
}


public int Unit_getInterceptorCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getInterceptorCount"); } 
return bridgePINVOKE.Unit_getInterceptorCount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getInterceptorCount: ",e);}
throw e;
   }     
}
}


public int Unit_getScarabCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getScarabCount"); } 
return bridgePINVOKE.Unit_getScarabCount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getScarabCount: ",e);}
throw e;
   }     
}
}


public int Unit_getSpiderMineCount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getSpiderMineCount"); } 
return bridgePINVOKE.Unit_getSpiderMineCount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getSpiderMineCount: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getTech"); } 
return bridgePINVOKE.Unit_getTech(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getTech: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getUpgrade"); } 
return bridgePINVOKE.Unit_getUpgrade(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getUpgrade: ",e);}
throw e;
   }     
}
}


public int Unit_getRemainingResearchTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRemainingResearchTime"); } 
return bridgePINVOKE.Unit_getRemainingResearchTime(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRemainingResearchTime: ",e);}
throw e;
   }     
}
}


public int Unit_getRemainingUpgradeTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRemainingUpgradeTime"); } 
return bridgePINVOKE.Unit_getRemainingUpgradeTime(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRemainingUpgradeTime: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getRallyPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRallyPosition"); } 
return bridgePINVOKE.Unit_getRallyPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRallyPosition: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getRallyUnit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getRallyUnit"); } 
return bridgePINVOKE.Unit_getRallyUnit(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getRallyUnit: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getAddon"); } 
return bridgePINVOKE.Unit_getAddon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getAddon: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getHatchery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getHatchery"); } 
return bridgePINVOKE.Unit_getHatchery(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getHatchery: ",e);}
throw e;
   }     
}
}


public IntPtr Unit_getLarva(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getLarva"); } 
return bridgePINVOKE.Unit_getLarva(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getLarva: ",e);}
throw e;
   }     
}
}


public int Unit_getUpgradeLevel(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_getUpgradeLevel"); } 
return bridgePINVOKE.Unit_getUpgradeLevel(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_getUpgradeLevel: ",e);}
throw e;
   }     
}
}


public bool Unit_exists(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_exists"); } 
return bridgePINVOKE.Unit_exists(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_exists: ",e);}
throw e;
   }     
}
}


public bool Unit_isAccelerating(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isAccelerating"); } 
return bridgePINVOKE.Unit_isAccelerating(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isAccelerating: ",e);}
throw e;
   }     
}
}


public bool Unit_isBeingConstructed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBeingConstructed"); } 
return bridgePINVOKE.Unit_isBeingConstructed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBeingConstructed: ",e);}
throw e;
   }     
}
}


public bool Unit_isBeingHealed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBeingHealed"); } 
return bridgePINVOKE.Unit_isBeingHealed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBeingHealed: ",e);}
throw e;
   }     
}
}


public bool Unit_isBlind(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBlind"); } 
return bridgePINVOKE.Unit_isBlind(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBlind: ",e);}
throw e;
   }     
}
}


public bool Unit_isBraking(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBraking"); } 
return bridgePINVOKE.Unit_isBraking(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBraking: ",e);}
throw e;
   }     
}
}


public bool Unit_isBurrowed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBurrowed"); } 
return bridgePINVOKE.Unit_isBurrowed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBurrowed: ",e);}
throw e;
   }     
}
}


public bool Unit_isCarryingGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isCarryingGas"); } 
return bridgePINVOKE.Unit_isCarryingGas(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isCarryingGas: ",e);}
throw e;
   }     
}
}


public bool Unit_isCarryingMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isCarryingMinerals"); } 
return bridgePINVOKE.Unit_isCarryingMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isCarryingMinerals: ",e);}
throw e;
   }     
}
}


public bool Unit_isCloaked(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isCloaked"); } 
return bridgePINVOKE.Unit_isCloaked(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isCloaked: ",e);}
throw e;
   }     
}
}


public bool Unit_isCompleted(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isCompleted"); } 
return bridgePINVOKE.Unit_isCompleted(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isCompleted: ",e);}
throw e;
   }     
}
}


public bool Unit_isConstructing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isConstructing"); } 
return bridgePINVOKE.Unit_isConstructing(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isConstructing: ",e);}
throw e;
   }     
}
}


public bool Unit_isDefenseMatrixed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isDefenseMatrixed"); } 
return bridgePINVOKE.Unit_isDefenseMatrixed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isDefenseMatrixed: ",e);}
throw e;
   }     
}
}


public bool Unit_isEnsnared(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isEnsnared"); } 
return bridgePINVOKE.Unit_isEnsnared(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isEnsnared: ",e);}
throw e;
   }     
}
}


public bool Unit_isFollowing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isFollowing"); } 
return bridgePINVOKE.Unit_isFollowing(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isFollowing: ",e);}
throw e;
   }     
}
}


public bool Unit_isGatheringGas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isGatheringGas"); } 
return bridgePINVOKE.Unit_isGatheringGas(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isGatheringGas: ",e);}
throw e;
   }     
}
}


public bool Unit_isGatheringMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isGatheringMinerals"); } 
return bridgePINVOKE.Unit_isGatheringMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isGatheringMinerals: ",e);}
throw e;
   }     
}
}


public bool Unit_isHallucination(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isHallucination"); } 
return bridgePINVOKE.Unit_isHallucination(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isHallucination: ",e);}
throw e;
   }     
}
}


public bool Unit_isIdle(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isIdle"); } 
return bridgePINVOKE.Unit_isIdle(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isIdle: ",e);}
throw e;
   }     
}
}


public bool Unit_isIrradiated(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isIrradiated"); } 
return bridgePINVOKE.Unit_isIrradiated(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isIrradiated: ",e);}
throw e;
   }     
}
}


public bool Unit_isLifted(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isLifted"); } 
return bridgePINVOKE.Unit_isLifted(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isLifted: ",e);}
throw e;
   }     
}
}


public bool Unit_isLoaded(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isLoaded"); } 
return bridgePINVOKE.Unit_isLoaded(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isLoaded: ",e);}
throw e;
   }     
}
}


public bool Unit_isLockedDown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isLockedDown"); } 
return bridgePINVOKE.Unit_isLockedDown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isLockedDown: ",e);}
throw e;
   }     
}
}


public bool Unit_isMaelstrommed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isMaelstrommed"); } 
return bridgePINVOKE.Unit_isMaelstrommed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isMaelstrommed: ",e);}
throw e;
   }     
}
}


public bool Unit_isMorphing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isMorphing"); } 
return bridgePINVOKE.Unit_isMorphing(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isMorphing: ",e);}
throw e;
   }     
}
}


public bool Unit_isMoving(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isMoving"); } 
return bridgePINVOKE.Unit_isMoving(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isMoving: ",e);}
throw e;
   }     
}
}


public bool Unit_isParasited(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isParasited"); } 
return bridgePINVOKE.Unit_isParasited(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isParasited: ",e);}
throw e;
   }     
}
}


public bool Unit_isPatrolling(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isPatrolling"); } 
return bridgePINVOKE.Unit_isPatrolling(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isPatrolling: ",e);}
throw e;
   }     
}
}


public bool Unit_isPlagued(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isPlagued"); } 
return bridgePINVOKE.Unit_isPlagued(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isPlagued: ",e);}
throw e;
   }     
}
}


public bool Unit_isRepairing(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isRepairing"); } 
return bridgePINVOKE.Unit_isRepairing(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isRepairing: ",e);}
throw e;
   }     
}
}


public bool Unit_isResearching(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isResearching"); } 
return bridgePINVOKE.Unit_isResearching(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isResearching: ",e);}
throw e;
   }     
}
}


public bool Unit_isSelected(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isSelected"); } 
return bridgePINVOKE.Unit_isSelected(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isSelected: ",e);}
throw e;
   }     
}
}


public bool Unit_isSieged(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isSieged"); } 
return bridgePINVOKE.Unit_isSieged(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isSieged: ",e);}
throw e;
   }     
}
}


public bool Unit_isStartingAttack(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isStartingAttack"); } 
return bridgePINVOKE.Unit_isStartingAttack(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isStartingAttack: ",e);}
throw e;
   }     
}
}


public bool Unit_isStasised(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isStasised"); } 
return bridgePINVOKE.Unit_isStasised(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isStasised: ",e);}
throw e;
   }     
}
}


public bool Unit_isStimmed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isStimmed"); } 
return bridgePINVOKE.Unit_isStimmed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isStimmed: ",e);}
throw e;
   }     
}
}


public bool Unit_isTraining(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isTraining"); } 
return bridgePINVOKE.Unit_isTraining(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isTraining: ",e);}
throw e;
   }     
}
}


public bool Unit_isUnderStorm(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isUnderStorm"); } 
return bridgePINVOKE.Unit_isUnderStorm(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isUnderStorm: ",e);}
throw e;
   }     
}
}


public bool Unit_isUnpowered(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isUnpowered"); } 
return bridgePINVOKE.Unit_isUnpowered(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isUnpowered: ",e);}
throw e;
   }     
}
}


public bool Unit_isUpgrading(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isUpgrading"); } 
return bridgePINVOKE.Unit_isUpgrading(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isUpgrading: ",e);}
throw e;
   }     
}
}


public bool Unit_isVisible(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isVisible"); } 
return bridgePINVOKE.Unit_isVisible(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isVisible: ",e);}
throw e;
   }     
}
}


public bool Unit_isBeingGathered(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_isBeingGathered"); } 
return bridgePINVOKE.Unit_isBeingGathered(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_isBeingGathered: ",e);}
throw e;
   }     
}
}


public bool Unit_attackMove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_attackMove"); } 
return bridgePINVOKE.Unit_attackMove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_attackMove: ",e);}
throw e;
   }     
}
}


public bool Unit_attackUnit(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_attackUnit"); } 
return bridgePINVOKE.Unit_attackUnit(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_attackUnit: ",e);}
throw e;
   }     
}
}


public bool Unit_rightClick__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_rightClick__SWIG_0"); } 
return bridgePINVOKE.Unit_rightClick__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_rightClick__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Unit_rightClick__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_rightClick__SWIG_1"); } 
return bridgePINVOKE.Unit_rightClick__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_rightClick__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Unit_train(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_train"); } 
return bridgePINVOKE.Unit_train(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_train: ",e);}
throw e;
   }     
}
}


public bool Unit_build(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_build"); } 
return bridgePINVOKE.Unit_build(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_build: ",e);}
throw e;
   }     
}
}


public bool Unit_buildAddon(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_buildAddon"); } 
return bridgePINVOKE.Unit_buildAddon(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_buildAddon: ",e);}
throw e;
   }     
}
}


public bool Unit_research(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_research"); } 
return bridgePINVOKE.Unit_research(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_research: ",e);}
throw e;
   }     
}
}


public bool Unit_upgrade(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_upgrade"); } 
return bridgePINVOKE.Unit_upgrade(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_upgrade: ",e);}
throw e;
   }     
}
}


public bool Unit_stop(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_stop"); } 
return bridgePINVOKE.Unit_stop(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_stop: ",e);}
throw e;
   }     
}
}


public bool Unit_holdPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_holdPosition"); } 
return bridgePINVOKE.Unit_holdPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_holdPosition: ",e);}
throw e;
   }     
}
}


public bool Unit_patrol(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_patrol"); } 
return bridgePINVOKE.Unit_patrol(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_patrol: ",e);}
throw e;
   }     
}
}


public bool Unit_follow(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_follow"); } 
return bridgePINVOKE.Unit_follow(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_follow: ",e);}
throw e;
   }     
}
}


public bool Unit_setRallyPosition(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_setRallyPosition"); } 
return bridgePINVOKE.Unit_setRallyPosition(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_setRallyPosition: ",e);}
throw e;
   }     
}
}


public bool Unit_setRallyUnit(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_setRallyUnit"); } 
return bridgePINVOKE.Unit_setRallyUnit(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_setRallyUnit: ",e);}
throw e;
   }     
}
}


public bool Unit_repair(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_repair"); } 
return bridgePINVOKE.Unit_repair(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_repair: ",e);}
throw e;
   }     
}
}


public bool Unit_returnCargo(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_returnCargo"); } 
return bridgePINVOKE.Unit_returnCargo(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_returnCargo: ",e);}
throw e;
   }     
}
}


public bool Unit_morph(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_morph"); } 
return bridgePINVOKE.Unit_morph(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_morph: ",e);}
throw e;
   }     
}
}


public bool Unit_burrow(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_burrow"); } 
return bridgePINVOKE.Unit_burrow(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_burrow: ",e);}
throw e;
   }     
}
}


public bool Unit_unburrow(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_unburrow"); } 
return bridgePINVOKE.Unit_unburrow(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_unburrow: ",e);}
throw e;
   }     
}
}


public bool Unit_siege(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_siege"); } 
return bridgePINVOKE.Unit_siege(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_siege: ",e);}
throw e;
   }     
}
}


public bool Unit_unsiege(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_unsiege"); } 
return bridgePINVOKE.Unit_unsiege(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_unsiege: ",e);}
throw e;
   }     
}
}


public bool Unit_cloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cloak"); } 
return bridgePINVOKE.Unit_cloak(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cloak: ",e);}
throw e;
   }     
}
}


public bool Unit_decloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_decloak"); } 
return bridgePINVOKE.Unit_decloak(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_decloak: ",e);}
throw e;
   }     
}
}


public bool Unit_lift(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_lift"); } 
return bridgePINVOKE.Unit_lift(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_lift: ",e);}
throw e;
   }     
}
}


public bool Unit_land(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_land"); } 
return bridgePINVOKE.Unit_land(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_land: ",e);}
throw e;
   }     
}
}


public bool Unit_load(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_load"); } 
return bridgePINVOKE.Unit_load(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_load: ",e);}
throw e;
   }     
}
}


public bool Unit_unload(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_unload"); } 
return bridgePINVOKE.Unit_unload(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_unload: ",e);}
throw e;
   }     
}
}


public bool Unit_unloadAll__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_unloadAll__SWIG_0"); } 
return bridgePINVOKE.Unit_unloadAll__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_unloadAll__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Unit_unloadAll__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_unloadAll__SWIG_1"); } 
return bridgePINVOKE.Unit_unloadAll__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_unloadAll__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelConstruction(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelConstruction"); } 
return bridgePINVOKE.Unit_cancelConstruction(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelConstruction: ",e);}
throw e;
   }     
}
}


public bool Unit_haltConstruction(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_haltConstruction"); } 
return bridgePINVOKE.Unit_haltConstruction(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_haltConstruction: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelMorph(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelMorph"); } 
return bridgePINVOKE.Unit_cancelMorph(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelMorph: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelTrain__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelTrain__SWIG_0"); } 
return bridgePINVOKE.Unit_cancelTrain__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelTrain__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelTrain__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelTrain__SWIG_1"); } 
return bridgePINVOKE.Unit_cancelTrain__SWIG_1(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelTrain__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelAddon"); } 
return bridgePINVOKE.Unit_cancelAddon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelAddon: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelResearch(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelResearch"); } 
return bridgePINVOKE.Unit_cancelResearch(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelResearch: ",e);}
throw e;
   }     
}
}


public bool Unit_cancelUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_cancelUpgrade"); } 
return bridgePINVOKE.Unit_cancelUpgrade(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_cancelUpgrade: ",e);}
throw e;
   }     
}
}


public bool Unit_useTech__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_useTech__SWIG_0"); } 
return bridgePINVOKE.Unit_useTech__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_useTech__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool Unit_useTech__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_useTech__SWIG_1"); } 
return bridgePINVOKE.Unit_useTech__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_useTech__SWIG_1: ",e);}
throw e;
   }     
}
}


public bool Unit_useTech__SWIG_2(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Unit_useTech__SWIG_2"); } 
return bridgePINVOKE.Unit_useTech__SWIG_2(new HandleRef(null,jarg1), new HandleRef(null,jarg2), new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Unit_useTech__SWIG_2: ",e);}
throw e;
   }     
}
}


public void delete_Unit(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Unit"); } 
bridgePINVOKE.delete_Unit(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Unit: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSizeType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSizeType__SWIG_0"); } 
return bridgePINVOKE.new_UnitSizeType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSizeType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSizeType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSizeType__SWIG_1"); } 
return bridgePINVOKE.new_UnitSizeType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSizeType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSizeType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSizeType__SWIG_2"); } 
return bridgePINVOKE.new_UnitSizeType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSizeType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_opAssign"); } 
return bridgePINVOKE.UnitSizeType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_opAssign: ",e);}
throw e;
   }     
}
}


public bool UnitSizeType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_opEquals"); } 
return bridgePINVOKE.UnitSizeType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_opEquals: ",e);}
throw e;
   }     
}
}


public bool UnitSizeType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_opNotEquals"); } 
return bridgePINVOKE.UnitSizeType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool UnitSizeType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_opLessThan"); } 
return bridgePINVOKE.UnitSizeType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_opLessThan: ",e);}
throw e;
   }     
}
}


public int UnitSizeType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_getID"); } 
return bridgePINVOKE.UnitSizeType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_getID: ",e);}
throw e;
   }     
}
}


public string UnitSizeType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeType_getName"); } 
return bridgePINVOKE.UnitSizeType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeType_getName: ",e);}
throw e;
   }     
}
}


public void delete_UnitSizeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitSizeType"); } 
bridgePINVOKE.delete_UnitSizeType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitSizeType: ",e);}
throw e;
   }     
}
}


public IntPtr getUnitSizeType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getUnitSizeType"); } 
return bridgePINVOKE.getUnitSizeType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getUnitSizeType: ",e);}
throw e;
   }     
}
}


public IntPtr allUnitSizeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allUnitSizeTypes"); } 
return bridgePINVOKE.allUnitSizeTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allUnitSizeTypes: ",e);}
throw e;
   }     
}
}


public void initUnitSizeTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initUnitSizeTypes"); } 
bridgePINVOKE.initUnitSizeTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initUnitSizeTypes: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeIndependent_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeIndependent_get"); } 
return bridgePINVOKE.UnitSizeTypeIndependent_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeIndependent_get: ",e);}
throw e;
   }     
}
}


public IntPtr Small_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Small_get"); } 
return bridgePINVOKE.Small_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Small_get: ",e);}
throw e;
   }     
}
}


public IntPtr Medium_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Medium_get"); } 
return bridgePINVOKE.Medium_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Medium_get: ",e);}
throw e;
   }     
}
}


public IntPtr Large_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Large_get"); } 
return bridgePINVOKE.Large_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Large_get: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeNone_get"); } 
return bridgePINVOKE.UnitSizeTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeUnknown_get"); } 
return bridgePINVOKE.UnitSizeTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitType__SWIG_0"); } 
return bridgePINVOKE.new_UnitType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitType__SWIG_1"); } 
return bridgePINVOKE.new_UnitType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitType__SWIG_2"); } 
return bridgePINVOKE.new_UnitType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_opAssign"); } 
return bridgePINVOKE.UnitType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_opAssign: ",e);}
throw e;
   }     
}
}


public bool UnitType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_opEquals"); } 
return bridgePINVOKE.UnitType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_opEquals: ",e);}
throw e;
   }     
}
}


public bool UnitType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_opNotEquals"); } 
return bridgePINVOKE.UnitType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool UnitType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_opLessThan"); } 
return bridgePINVOKE.UnitType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_opLessThan: ",e);}
throw e;
   }     
}
}


public int UnitType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_getID"); } 
return bridgePINVOKE.UnitType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_getID: ",e);}
throw e;
   }     
}
}


public string UnitType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_getName"); } 
return bridgePINVOKE.UnitType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_getName: ",e);}
throw e;
   }     
}
}


public string UnitType_getSubLabel(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_getSubLabel"); } 
return bridgePINVOKE.UnitType_getSubLabel(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_getSubLabel: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_getRace(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_getRace"); } 
return bridgePINVOKE.UnitType_getRace(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_getRace: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_whatBuilds(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_whatBuilds"); } 
return bridgePINVOKE.UnitType_whatBuilds(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_whatBuilds: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_requiredUnits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_requiredUnits"); } 
return bridgePINVOKE.UnitType_requiredUnits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_requiredUnits: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_requiredTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_requiredTech"); } 
return bridgePINVOKE.UnitType_requiredTech(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_requiredTech: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_abilities(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_abilities"); } 
return bridgePINVOKE.UnitType_abilities(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_abilities: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_upgrades(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_upgrades"); } 
return bridgePINVOKE.UnitType_upgrades(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_upgrades: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_armorUpgrade(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_armorUpgrade"); } 
return bridgePINVOKE.UnitType_armorUpgrade(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_armorUpgrade: ",e);}
throw e;
   }     
}
}


public int UnitType_maxHitPoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_maxHitPoints"); } 
return bridgePINVOKE.UnitType_maxHitPoints(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_maxHitPoints: ",e);}
throw e;
   }     
}
}


public int UnitType_maxShields(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_maxShields"); } 
return bridgePINVOKE.UnitType_maxShields(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_maxShields: ",e);}
throw e;
   }     
}
}


public int UnitType_maxEnergy(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_maxEnergy"); } 
return bridgePINVOKE.UnitType_maxEnergy(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_maxEnergy: ",e);}
throw e;
   }     
}
}


public int UnitType_armor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_armor"); } 
return bridgePINVOKE.UnitType_armor(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_armor: ",e);}
throw e;
   }     
}
}


public int UnitType_mineralPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_mineralPrice"); } 
return bridgePINVOKE.UnitType_mineralPrice(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_mineralPrice: ",e);}
throw e;
   }     
}
}


public int UnitType_gasPrice(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_gasPrice"); } 
return bridgePINVOKE.UnitType_gasPrice(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_gasPrice: ",e);}
throw e;
   }     
}
}


public int UnitType_buildTime(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_buildTime"); } 
return bridgePINVOKE.UnitType_buildTime(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_buildTime: ",e);}
throw e;
   }     
}
}


public int UnitType_supplyRequired(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_supplyRequired"); } 
return bridgePINVOKE.UnitType_supplyRequired(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_supplyRequired: ",e);}
throw e;
   }     
}
}


public int UnitType_supplyProvided(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_supplyProvided"); } 
return bridgePINVOKE.UnitType_supplyProvided(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_supplyProvided: ",e);}
throw e;
   }     
}
}


public int UnitType_spaceRequired(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_spaceRequired"); } 
return bridgePINVOKE.UnitType_spaceRequired(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_spaceRequired: ",e);}
throw e;
   }     
}
}


public int UnitType_spaceProvided(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_spaceProvided"); } 
return bridgePINVOKE.UnitType_spaceProvided(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_spaceProvided: ",e);}
throw e;
   }     
}
}


public int UnitType_buildScore(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_buildScore"); } 
return bridgePINVOKE.UnitType_buildScore(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_buildScore: ",e);}
throw e;
   }     
}
}


public int UnitType_destroyScore(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_destroyScore"); } 
return bridgePINVOKE.UnitType_destroyScore(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_destroyScore: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_size"); } 
return bridgePINVOKE.UnitType_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_size: ",e);}
throw e;
   }     
}
}


public int UnitType_tileWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_tileWidth"); } 
return bridgePINVOKE.UnitType_tileWidth(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_tileWidth: ",e);}
throw e;
   }     
}
}


public int UnitType_tileHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_tileHeight"); } 
return bridgePINVOKE.UnitType_tileHeight(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_tileHeight: ",e);}
throw e;
   }     
}
}


public int UnitType_dimensionLeft(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_dimensionLeft"); } 
return bridgePINVOKE.UnitType_dimensionLeft(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_dimensionLeft: ",e);}
throw e;
   }     
}
}


public int UnitType_dimensionUp(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_dimensionUp"); } 
return bridgePINVOKE.UnitType_dimensionUp(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_dimensionUp: ",e);}
throw e;
   }     
}
}


public int UnitType_dimensionRight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_dimensionRight"); } 
return bridgePINVOKE.UnitType_dimensionRight(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_dimensionRight: ",e);}
throw e;
   }     
}
}


public int UnitType_dimensionDown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_dimensionDown"); } 
return bridgePINVOKE.UnitType_dimensionDown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_dimensionDown: ",e);}
throw e;
   }     
}
}


public int UnitType_seekRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_seekRange"); } 
return bridgePINVOKE.UnitType_seekRange(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_seekRange: ",e);}
throw e;
   }     
}
}


public int UnitType_sightRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_sightRange"); } 
return bridgePINVOKE.UnitType_sightRange(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_sightRange: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_groundWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_groundWeapon"); } 
return bridgePINVOKE.UnitType_groundWeapon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_groundWeapon: ",e);}
throw e;
   }     
}
}


public int UnitType_maxGroundHits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_maxGroundHits"); } 
return bridgePINVOKE.UnitType_maxGroundHits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_maxGroundHits: ",e);}
throw e;
   }     
}
}


public IntPtr UnitType_airWeapon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_airWeapon"); } 
return bridgePINVOKE.UnitType_airWeapon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_airWeapon: ",e);}
throw e;
   }     
}
}


public int UnitType_maxAirHits(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_maxAirHits"); } 
return bridgePINVOKE.UnitType_maxAirHits(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_maxAirHits: ",e);}
throw e;
   }     
}
}


public double UnitType_topSpeed(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_topSpeed"); } 
return bridgePINVOKE.UnitType_topSpeed(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_topSpeed: ",e);}
throw e;
   }     
}
}


public int UnitType_acceleration(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_acceleration"); } 
return bridgePINVOKE.UnitType_acceleration(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_acceleration: ",e);}
throw e;
   }     
}
}


public int UnitType_haltDistance(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_haltDistance"); } 
return bridgePINVOKE.UnitType_haltDistance(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_haltDistance: ",e);}
throw e;
   }     
}
}


public int UnitType_turnRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_turnRadius"); } 
return bridgePINVOKE.UnitType_turnRadius(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_turnRadius: ",e);}
throw e;
   }     
}
}


public bool UnitType_canProduce(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_canProduce"); } 
return bridgePINVOKE.UnitType_canProduce(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_canProduce: ",e);}
throw e;
   }     
}
}


public bool UnitType_canAttack(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_canAttack"); } 
return bridgePINVOKE.UnitType_canAttack(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_canAttack: ",e);}
throw e;
   }     
}
}


public bool UnitType_canMove(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_canMove"); } 
return bridgePINVOKE.UnitType_canMove(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_canMove: ",e);}
throw e;
   }     
}
}


public bool UnitType_isFlyer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isFlyer"); } 
return bridgePINVOKE.UnitType_isFlyer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isFlyer: ",e);}
throw e;
   }     
}
}


public bool UnitType_regeneratesHP(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_regeneratesHP"); } 
return bridgePINVOKE.UnitType_regeneratesHP(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_regeneratesHP: ",e);}
throw e;
   }     
}
}


public bool UnitType_isSpellcaster(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isSpellcaster"); } 
return bridgePINVOKE.UnitType_isSpellcaster(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isSpellcaster: ",e);}
throw e;
   }     
}
}


public bool UnitType_hasPermanentCloak(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_hasPermanentCloak"); } 
return bridgePINVOKE.UnitType_hasPermanentCloak(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_hasPermanentCloak: ",e);}
throw e;
   }     
}
}


public bool UnitType_isInvincible(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isInvincible"); } 
return bridgePINVOKE.UnitType_isInvincible(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isInvincible: ",e);}
throw e;
   }     
}
}


public bool UnitType_isOrganic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isOrganic"); } 
return bridgePINVOKE.UnitType_isOrganic(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isOrganic: ",e);}
throw e;
   }     
}
}


public bool UnitType_isMechanical(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isMechanical"); } 
return bridgePINVOKE.UnitType_isMechanical(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isMechanical: ",e);}
throw e;
   }     
}
}


public bool UnitType_isRobotic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isRobotic"); } 
return bridgePINVOKE.UnitType_isRobotic(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isRobotic: ",e);}
throw e;
   }     
}
}


public bool UnitType_isDetector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isDetector"); } 
return bridgePINVOKE.UnitType_isDetector(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isDetector: ",e);}
throw e;
   }     
}
}


public bool UnitType_isResourceContainer(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isResourceContainer"); } 
return bridgePINVOKE.UnitType_isResourceContainer(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isResourceContainer: ",e);}
throw e;
   }     
}
}


public bool UnitType_isResourceDepot(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isResourceDepot"); } 
return bridgePINVOKE.UnitType_isResourceDepot(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isResourceDepot: ",e);}
throw e;
   }     
}
}


public bool UnitType_isRefinery(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isRefinery"); } 
return bridgePINVOKE.UnitType_isRefinery(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isRefinery: ",e);}
throw e;
   }     
}
}


public bool UnitType_isWorker(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isWorker"); } 
return bridgePINVOKE.UnitType_isWorker(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isWorker: ",e);}
throw e;
   }     
}
}


public bool UnitType_requiresPsi(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_requiresPsi"); } 
return bridgePINVOKE.UnitType_requiresPsi(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_requiresPsi: ",e);}
throw e;
   }     
}
}


public bool UnitType_requiresCreep(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_requiresCreep"); } 
return bridgePINVOKE.UnitType_requiresCreep(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_requiresCreep: ",e);}
throw e;
   }     
}
}


public bool UnitType_isTwoUnitsInOneEgg(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isTwoUnitsInOneEgg"); } 
return bridgePINVOKE.UnitType_isTwoUnitsInOneEgg(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isTwoUnitsInOneEgg: ",e);}
throw e;
   }     
}
}


public bool UnitType_isBurrowable(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isBurrowable"); } 
return bridgePINVOKE.UnitType_isBurrowable(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isBurrowable: ",e);}
throw e;
   }     
}
}


public bool UnitType_isCloakable(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isCloakable"); } 
return bridgePINVOKE.UnitType_isCloakable(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isCloakable: ",e);}
throw e;
   }     
}
}


public bool UnitType_isBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isBuilding"); } 
return bridgePINVOKE.UnitType_isBuilding(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isBuilding: ",e);}
throw e;
   }     
}
}


public bool UnitType_isAddon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isAddon"); } 
return bridgePINVOKE.UnitType_isAddon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isAddon: ",e);}
throw e;
   }     
}
}


public bool UnitType_isFlyingBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isFlyingBuilding"); } 
return bridgePINVOKE.UnitType_isFlyingBuilding(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isFlyingBuilding: ",e);}
throw e;
   }     
}
}


public bool UnitType_isNeutral(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitType_isNeutral"); } 
return bridgePINVOKE.UnitType_isNeutral(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitType_isNeutral: ",e);}
throw e;
   }     
}
}


public void delete_UnitType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitType"); } 
bridgePINVOKE.delete_UnitType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitType: ",e);}
throw e;
   }     
}
}


public IntPtr getUnitType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getUnitType"); } 
return bridgePINVOKE.getUnitType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getUnitType: ",e);}
throw e;
   }     
}
}


public IntPtr allUnitTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allUnitTypes"); } 
return bridgePINVOKE.allUnitTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allUnitTypes: ",e);}
throw e;
   }     
}
}


public void initUnitTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initUnitTypes"); } 
bridgePINVOKE.initUnitTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initUnitTypes: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Marine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Marine_get"); } 
return bridgePINVOKE.Terran_Marine_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Marine_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Ghost_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Ghost_get"); } 
return bridgePINVOKE.Terran_Ghost_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Ghost_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Vulture_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Vulture_get"); } 
return bridgePINVOKE.Terran_Vulture_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Vulture_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Goliath_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Goliath_get"); } 
return bridgePINVOKE.Terran_Goliath_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Goliath_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Siege_Tank_Tank_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Siege_Tank_Tank_Mode_get"); } 
return bridgePINVOKE.Terran_Siege_Tank_Tank_Mode_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Siege_Tank_Tank_Mode_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_SCV_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_SCV_get"); } 
return bridgePINVOKE.Terran_SCV_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_SCV_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Wraith_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Wraith_get"); } 
return bridgePINVOKE.Terran_Wraith_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Wraith_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Science_Vessel_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Science_Vessel_get"); } 
return bridgePINVOKE.Terran_Science_Vessel_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Science_Vessel_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Dropship_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Dropship_get"); } 
return bridgePINVOKE.Terran_Dropship_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Dropship_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Battlecruiser_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Battlecruiser_get"); } 
return bridgePINVOKE.Terran_Battlecruiser_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Battlecruiser_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Vulture_Spider_Mine_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Vulture_Spider_Mine_get"); } 
return bridgePINVOKE.Terran_Vulture_Spider_Mine_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Vulture_Spider_Mine_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Nuclear_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Nuclear_Missile_get"); } 
return bridgePINVOKE.Terran_Nuclear_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Nuclear_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Siege_Tank_Siege_Mode_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Siege_Tank_Siege_Mode_get"); } 
return bridgePINVOKE.Terran_Siege_Tank_Siege_Mode_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Siege_Tank_Siege_Mode_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Firebat_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Firebat_get"); } 
return bridgePINVOKE.Terran_Firebat_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Firebat_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spell_Scanner_Sweep_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spell_Scanner_Sweep_get"); } 
return bridgePINVOKE.Spell_Scanner_Sweep_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spell_Scanner_Sweep_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Medic_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Medic_get"); } 
return bridgePINVOKE.Terran_Medic_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Medic_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Larva_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Larva_get"); } 
return bridgePINVOKE.Zerg_Larva_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Larva_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Egg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Egg_get"); } 
return bridgePINVOKE.Zerg_Egg_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Egg_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Zergling_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Zergling_get"); } 
return bridgePINVOKE.Zerg_Zergling_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Zergling_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Hydralisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Hydralisk_get"); } 
return bridgePINVOKE.Zerg_Hydralisk_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Hydralisk_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Ultralisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Ultralisk_get"); } 
return bridgePINVOKE.Zerg_Ultralisk_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Ultralisk_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Broodling_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Broodling_get"); } 
return bridgePINVOKE.Zerg_Broodling_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Broodling_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Drone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Drone_get"); } 
return bridgePINVOKE.Zerg_Drone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Drone_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Overlord_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Overlord_get"); } 
return bridgePINVOKE.Zerg_Overlord_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Overlord_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Mutalisk_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Mutalisk_get"); } 
return bridgePINVOKE.Zerg_Mutalisk_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Mutalisk_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Guardian_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Guardian_get"); } 
return bridgePINVOKE.Zerg_Guardian_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Guardian_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Queen_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Queen_get"); } 
return bridgePINVOKE.Zerg_Queen_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Queen_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Defiler_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Defiler_get"); } 
return bridgePINVOKE.Zerg_Defiler_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Defiler_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Scourge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Scourge_get"); } 
return bridgePINVOKE.Zerg_Scourge_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Scourge_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Infested_Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Infested_Terran_get"); } 
return bridgePINVOKE.Zerg_Infested_Terran_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Infested_Terran_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Valkyrie_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Valkyrie_get"); } 
return bridgePINVOKE.Terran_Valkyrie_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Valkyrie_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Cocoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Cocoon_get"); } 
return bridgePINVOKE.Zerg_Cocoon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Cocoon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Corsair_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Corsair_get"); } 
return bridgePINVOKE.Protoss_Corsair_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Corsair_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Dark_Templar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Dark_Templar_get"); } 
return bridgePINVOKE.Protoss_Dark_Templar_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Dark_Templar_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Devourer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Devourer_get"); } 
return bridgePINVOKE.Zerg_Devourer_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Devourer_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Dark_Archon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Dark_Archon_get"); } 
return bridgePINVOKE.Protoss_Dark_Archon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Dark_Archon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Probe_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Probe_get"); } 
return bridgePINVOKE.Protoss_Probe_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Probe_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Zealot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Zealot_get"); } 
return bridgePINVOKE.Protoss_Zealot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Zealot_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Dragoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Dragoon_get"); } 
return bridgePINVOKE.Protoss_Dragoon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Dragoon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_High_Templar_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_High_Templar_get"); } 
return bridgePINVOKE.Protoss_High_Templar_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_High_Templar_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Archon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Archon_get"); } 
return bridgePINVOKE.Protoss_Archon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Archon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Shuttle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Shuttle_get"); } 
return bridgePINVOKE.Protoss_Shuttle_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Shuttle_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Scout_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Scout_get"); } 
return bridgePINVOKE.Protoss_Scout_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Scout_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Arbiter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Arbiter_get"); } 
return bridgePINVOKE.Protoss_Arbiter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Arbiter_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Carrier_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Carrier_get"); } 
return bridgePINVOKE.Protoss_Carrier_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Carrier_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Interceptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Interceptor_get"); } 
return bridgePINVOKE.Protoss_Interceptor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Interceptor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Reaver_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Reaver_get"); } 
return bridgePINVOKE.Protoss_Reaver_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Reaver_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Observer_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Observer_get"); } 
return bridgePINVOKE.Protoss_Observer_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Observer_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Scarab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Scarab_get"); } 
return bridgePINVOKE.Protoss_Scarab_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Scarab_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Rhynadon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Rhynadon_get"); } 
return bridgePINVOKE.Critter_Rhynadon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Rhynadon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Bengalaas_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Bengalaas_get"); } 
return bridgePINVOKE.Critter_Bengalaas_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Bengalaas_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Scantid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Scantid_get"); } 
return bridgePINVOKE.Critter_Scantid_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Scantid_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Kakaru_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Kakaru_get"); } 
return bridgePINVOKE.Critter_Kakaru_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Kakaru_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Ragnasaur_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Ragnasaur_get"); } 
return bridgePINVOKE.Critter_Ragnasaur_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Ragnasaur_get: ",e);}
throw e;
   }     
}
}


public IntPtr Critter_Ursadon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Critter_Ursadon_get"); } 
return bridgePINVOKE.Critter_Ursadon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Critter_Ursadon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Lurker_Egg_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Lurker_Egg_get"); } 
return bridgePINVOKE.Zerg_Lurker_Egg_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Lurker_Egg_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Lurker_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Lurker_get"); } 
return bridgePINVOKE.Zerg_Lurker_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Lurker_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spell_Disruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spell_Disruption_Web_get"); } 
return bridgePINVOKE.Spell_Disruption_Web_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spell_Disruption_Web_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Command_Center_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Command_Center_get"); } 
return bridgePINVOKE.Terran_Command_Center_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Command_Center_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Comsat_Station_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Comsat_Station_get"); } 
return bridgePINVOKE.Terran_Comsat_Station_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Comsat_Station_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Nuclear_Silo_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Nuclear_Silo_get"); } 
return bridgePINVOKE.Terran_Nuclear_Silo_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Nuclear_Silo_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Supply_Depot_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Supply_Depot_get"); } 
return bridgePINVOKE.Terran_Supply_Depot_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Supply_Depot_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Refinery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Refinery_get"); } 
return bridgePINVOKE.Terran_Refinery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Refinery_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Barracks_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Barracks_get"); } 
return bridgePINVOKE.Terran_Barracks_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Barracks_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Academy_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Academy_get"); } 
return bridgePINVOKE.Terran_Academy_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Academy_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Factory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Factory_get"); } 
return bridgePINVOKE.Terran_Factory_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Factory_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Starport_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Starport_get"); } 
return bridgePINVOKE.Terran_Starport_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Starport_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Control_Tower_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Control_Tower_get"); } 
return bridgePINVOKE.Terran_Control_Tower_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Control_Tower_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Science_Facility_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Science_Facility_get"); } 
return bridgePINVOKE.Terran_Science_Facility_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Science_Facility_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Covert_Ops_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Covert_Ops_get"); } 
return bridgePINVOKE.Terran_Covert_Ops_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Covert_Ops_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Physics_Lab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Physics_Lab_get"); } 
return bridgePINVOKE.Terran_Physics_Lab_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Physics_Lab_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Machine_Shop_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Machine_Shop_get"); } 
return bridgePINVOKE.Terran_Machine_Shop_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Machine_Shop_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Engineering_Bay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Engineering_Bay_get"); } 
return bridgePINVOKE.Terran_Engineering_Bay_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Engineering_Bay_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Armory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Armory_get"); } 
return bridgePINVOKE.Terran_Armory_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Armory_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Missile_Turret_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Missile_Turret_get"); } 
return bridgePINVOKE.Terran_Missile_Turret_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Missile_Turret_get: ",e);}
throw e;
   }     
}
}


public IntPtr Terran_Bunker_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Terran_Bunker_get"); } 
return bridgePINVOKE.Terran_Bunker_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Terran_Bunker_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Crashed_Norad_II_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Crashed_Norad_II_get"); } 
return bridgePINVOKE.Special_Crashed_Norad_II_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Crashed_Norad_II_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Ion_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Ion_Cannon_get"); } 
return bridgePINVOKE.Special_Ion_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Ion_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Infested_Command_Center_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Infested_Command_Center_get"); } 
return bridgePINVOKE.Zerg_Infested_Command_Center_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Infested_Command_Center_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Hatchery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Hatchery_get"); } 
return bridgePINVOKE.Zerg_Hatchery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Hatchery_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Lair_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Lair_get"); } 
return bridgePINVOKE.Zerg_Lair_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Lair_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Hive_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Hive_get"); } 
return bridgePINVOKE.Zerg_Hive_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Hive_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Nydus_Canal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Nydus_Canal_get"); } 
return bridgePINVOKE.Zerg_Nydus_Canal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Nydus_Canal_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Hydralisk_Den_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Hydralisk_Den_get"); } 
return bridgePINVOKE.Zerg_Hydralisk_Den_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Hydralisk_Den_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Defiler_Mound_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Defiler_Mound_get"); } 
return bridgePINVOKE.Zerg_Defiler_Mound_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Defiler_Mound_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Greater_Spire_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Greater_Spire_get"); } 
return bridgePINVOKE.Zerg_Greater_Spire_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Greater_Spire_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Queens_Nest_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Queens_Nest_get"); } 
return bridgePINVOKE.Zerg_Queens_Nest_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Queens_Nest_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Evolution_Chamber_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Evolution_Chamber_get"); } 
return bridgePINVOKE.Zerg_Evolution_Chamber_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Evolution_Chamber_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Ultralisk_Cavern_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Ultralisk_Cavern_get"); } 
return bridgePINVOKE.Zerg_Ultralisk_Cavern_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Ultralisk_Cavern_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Spire_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Spire_get"); } 
return bridgePINVOKE.Zerg_Spire_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Spire_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Spawning_Pool_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Spawning_Pool_get"); } 
return bridgePINVOKE.Zerg_Spawning_Pool_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Spawning_Pool_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Creep_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Creep_Colony_get"); } 
return bridgePINVOKE.Zerg_Creep_Colony_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Creep_Colony_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Spore_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Spore_Colony_get"); } 
return bridgePINVOKE.Zerg_Spore_Colony_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Spore_Colony_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Sunken_Colony_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Sunken_Colony_get"); } 
return bridgePINVOKE.Zerg_Sunken_Colony_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Sunken_Colony_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Overmind_With_Shell_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Overmind_With_Shell_get"); } 
return bridgePINVOKE.Special_Overmind_With_Shell_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Overmind_With_Shell_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Overmind_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Overmind_get"); } 
return bridgePINVOKE.Special_Overmind_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Overmind_get: ",e);}
throw e;
   }     
}
}


public IntPtr Zerg_Extractor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Zerg_Extractor_get"); } 
return bridgePINVOKE.Zerg_Extractor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Zerg_Extractor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Mature_Chrysalis_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Mature_Chrysalis_get"); } 
return bridgePINVOKE.Special_Mature_Chrysalis_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Mature_Chrysalis_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Cerebrate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Cerebrate_get"); } 
return bridgePINVOKE.Special_Cerebrate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Cerebrate_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Cerebrate_Daggoth_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Cerebrate_Daggoth_get"); } 
return bridgePINVOKE.Special_Cerebrate_Daggoth_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Cerebrate_Daggoth_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Nexus_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Nexus_get"); } 
return bridgePINVOKE.Protoss_Nexus_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Nexus_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Robotics_Facility_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Robotics_Facility_get"); } 
return bridgePINVOKE.Protoss_Robotics_Facility_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Robotics_Facility_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Pylon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Pylon_get"); } 
return bridgePINVOKE.Protoss_Pylon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Pylon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Assimilator_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Assimilator_get"); } 
return bridgePINVOKE.Protoss_Assimilator_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Assimilator_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Observatory_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Observatory_get"); } 
return bridgePINVOKE.Protoss_Observatory_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Observatory_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Gateway_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Gateway_get"); } 
return bridgePINVOKE.Protoss_Gateway_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Gateway_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Photon_Cannon_get"); } 
return bridgePINVOKE.Protoss_Photon_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Photon_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Citadel_of_Adun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Citadel_of_Adun_get"); } 
return bridgePINVOKE.Protoss_Citadel_of_Adun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Citadel_of_Adun_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Cybernetics_Core_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Cybernetics_Core_get"); } 
return bridgePINVOKE.Protoss_Cybernetics_Core_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Cybernetics_Core_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Templar_Archives_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Templar_Archives_get"); } 
return bridgePINVOKE.Protoss_Templar_Archives_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Templar_Archives_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Forge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Forge_get"); } 
return bridgePINVOKE.Protoss_Forge_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Forge_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Stargate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Stargate_get"); } 
return bridgePINVOKE.Protoss_Stargate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Stargate_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Stasis_Cell_Prison_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Stasis_Cell_Prison_get"); } 
return bridgePINVOKE.Special_Stasis_Cell_Prison_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Stasis_Cell_Prison_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Fleet_Beacon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Fleet_Beacon_get"); } 
return bridgePINVOKE.Protoss_Fleet_Beacon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Fleet_Beacon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Arbiter_Tribunal_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Arbiter_Tribunal_get"); } 
return bridgePINVOKE.Protoss_Arbiter_Tribunal_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Arbiter_Tribunal_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Robotics_Support_Bay_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Robotics_Support_Bay_get"); } 
return bridgePINVOKE.Protoss_Robotics_Support_Bay_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Robotics_Support_Bay_get: ",e);}
throw e;
   }     
}
}


public IntPtr Protoss_Shield_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Protoss_Shield_Battery_get"); } 
return bridgePINVOKE.Protoss_Shield_Battery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Protoss_Shield_Battery_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Khaydarin_Crystal_Form_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Khaydarin_Crystal_Form_get"); } 
return bridgePINVOKE.Special_Khaydarin_Crystal_Form_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Khaydarin_Crystal_Form_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Protoss_Temple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Protoss_Temple_get"); } 
return bridgePINVOKE.Special_Protoss_Temple_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Protoss_Temple_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_XelNaga_Temple_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_XelNaga_Temple_get"); } 
return bridgePINVOKE.Special_XelNaga_Temple_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_XelNaga_Temple_get: ",e);}
throw e;
   }     
}
}


public IntPtr Resource_Mineral_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Resource_Mineral_Field_get"); } 
return bridgePINVOKE.Resource_Mineral_Field_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Resource_Mineral_Field_get: ",e);}
throw e;
   }     
}
}


public IntPtr Resource_Vespene_Geyser_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Resource_Vespene_Geyser_get"); } 
return bridgePINVOKE.Resource_Vespene_Geyser_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Resource_Vespene_Geyser_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Warp_Gate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Warp_Gate_get"); } 
return bridgePINVOKE.Special_Warp_Gate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Warp_Gate_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Psi_Disrupter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Psi_Disrupter_get"); } 
return bridgePINVOKE.Special_Psi_Disrupter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Psi_Disrupter_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Power_Generator_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Power_Generator_get"); } 
return bridgePINVOKE.Special_Power_Generator_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Power_Generator_get: ",e);}
throw e;
   }     
}
}


public IntPtr Special_Overmind_Cocoon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Special_Overmind_Cocoon_get"); } 
return bridgePINVOKE.Special_Overmind_Cocoon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Special_Overmind_Cocoon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spell_Dark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spell_Dark_Swarm_get"); } 
return bridgePINVOKE.Spell_Dark_Swarm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spell_Dark_Swarm_get: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeNone_get"); } 
return bridgePINVOKE.UnitTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeUnknown_get"); } 
return bridgePINVOKE.UnitTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr new_WeaponType__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_WeaponType__SWIG_0"); } 
return bridgePINVOKE.new_WeaponType__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_WeaponType__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_WeaponType__SWIG_1(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_WeaponType__SWIG_1"); } 
return bridgePINVOKE.new_WeaponType__SWIG_1(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_WeaponType__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_WeaponType__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_WeaponType__SWIG_2"); } 
return bridgePINVOKE.new_WeaponType__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_WeaponType__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_opAssign(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_opAssign"); } 
return bridgePINVOKE.WeaponType_opAssign(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_opAssign: ",e);}
throw e;
   }     
}
}


public bool WeaponType_opEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_opEquals"); } 
return bridgePINVOKE.WeaponType_opEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_opEquals: ",e);}
throw e;
   }     
}
}


public bool WeaponType_opNotEquals(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_opNotEquals"); } 
return bridgePINVOKE.WeaponType_opNotEquals(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_opNotEquals: ",e);}
throw e;
   }     
}
}


public bool WeaponType_opLessThan(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_opLessThan"); } 
return bridgePINVOKE.WeaponType_opLessThan(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_opLessThan: ",e);}
throw e;
   }     
}
}


public int WeaponType_getID(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_getID"); } 
return bridgePINVOKE.WeaponType_getID(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_getID: ",e);}
throw e;
   }     
}
}


public string WeaponType_getName(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_getName"); } 
return bridgePINVOKE.WeaponType_getName(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_getName: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_getTech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_getTech"); } 
return bridgePINVOKE.WeaponType_getTech(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_getTech: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_whatUses(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_whatUses"); } 
return bridgePINVOKE.WeaponType_whatUses(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_whatUses: ",e);}
throw e;
   }     
}
}


public int WeaponType_damageAmount(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_damageAmount"); } 
return bridgePINVOKE.WeaponType_damageAmount(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_damageAmount: ",e);}
throw e;
   }     
}
}


public int WeaponType_damageBonus(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_damageBonus"); } 
return bridgePINVOKE.WeaponType_damageBonus(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_damageBonus: ",e);}
throw e;
   }     
}
}


public int WeaponType_damageCooldown(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_damageCooldown"); } 
return bridgePINVOKE.WeaponType_damageCooldown(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_damageCooldown: ",e);}
throw e;
   }     
}
}


public int WeaponType_damageFactor(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_damageFactor"); } 
return bridgePINVOKE.WeaponType_damageFactor(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_damageFactor: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_upgradeType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_upgradeType"); } 
return bridgePINVOKE.WeaponType_upgradeType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_upgradeType: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_damageType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_damageType"); } 
return bridgePINVOKE.WeaponType_damageType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_damageType: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponType_explosionType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_explosionType"); } 
return bridgePINVOKE.WeaponType_explosionType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_explosionType: ",e);}
throw e;
   }     
}
}


public int WeaponType_minRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_minRange"); } 
return bridgePINVOKE.WeaponType_minRange(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_minRange: ",e);}
throw e;
   }     
}
}


public int WeaponType_maxRange(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_maxRange"); } 
return bridgePINVOKE.WeaponType_maxRange(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_maxRange: ",e);}
throw e;
   }     
}
}


public int WeaponType_innerSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_innerSplashRadius"); } 
return bridgePINVOKE.WeaponType_innerSplashRadius(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_innerSplashRadius: ",e);}
throw e;
   }     
}
}


public int WeaponType_medianSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_medianSplashRadius"); } 
return bridgePINVOKE.WeaponType_medianSplashRadius(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_medianSplashRadius: ",e);}
throw e;
   }     
}
}


public int WeaponType_outerSplashRadius(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_outerSplashRadius"); } 
return bridgePINVOKE.WeaponType_outerSplashRadius(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_outerSplashRadius: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsAir(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsAir"); } 
return bridgePINVOKE.WeaponType_targetsAir(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsAir: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsGround(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsGround"); } 
return bridgePINVOKE.WeaponType_targetsGround(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsGround: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsMechanical(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsMechanical"); } 
return bridgePINVOKE.WeaponType_targetsMechanical(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsMechanical: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsOrganic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsOrganic"); } 
return bridgePINVOKE.WeaponType_targetsOrganic(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsOrganic: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsNonBuilding(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsNonBuilding"); } 
return bridgePINVOKE.WeaponType_targetsNonBuilding(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsNonBuilding: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsNonRobotic(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsNonRobotic"); } 
return bridgePINVOKE.WeaponType_targetsNonRobotic(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsNonRobotic: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsTerrain(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsTerrain"); } 
return bridgePINVOKE.WeaponType_targetsTerrain(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsTerrain: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsOrgOrMech(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsOrgOrMech"); } 
return bridgePINVOKE.WeaponType_targetsOrgOrMech(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsOrgOrMech: ",e);}
throw e;
   }     
}
}


public bool WeaponType_targetsOwn(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponType_targetsOwn"); } 
return bridgePINVOKE.WeaponType_targetsOwn(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponType_targetsOwn: ",e);}
throw e;
   }     
}
}


public void delete_WeaponType(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_WeaponType"); } 
bridgePINVOKE.delete_WeaponType(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_WeaponType: ",e);}
throw e;
   }     
}
}


public IntPtr getWeaponType(string jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getWeaponType"); } 
return bridgePINVOKE.getWeaponType(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getWeaponType: ",e);}
throw e;
   }     
}
}


public IntPtr allWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - allWeaponTypes"); } 
return bridgePINVOKE.allWeaponTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in allWeaponTypes: ",e);}
throw e;
   }     
}
}


public IntPtr normalWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - normalWeaponTypes"); } 
return bridgePINVOKE.normalWeaponTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in normalWeaponTypes: ",e);}
throw e;
   }     
}
}


public IntPtr specialWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - specialWeaponTypes"); } 
return bridgePINVOKE.specialWeaponTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in specialWeaponTypes: ",e);}
throw e;
   }     
}
}


public void initWeaponTypes( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - initWeaponTypes"); } 
bridgePINVOKE.initWeaponTypes();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in initWeaponTypes: ",e);}
throw e;
   }     
}
}


public IntPtr Gauss_Rifle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Gauss_Rifle_get"); } 
return bridgePINVOKE.Gauss_Rifle_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Gauss_Rifle_get: ",e);}
throw e;
   }     
}
}


public IntPtr C_10_Canister_Rifle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - C_10_Canister_Rifle_get"); } 
return bridgePINVOKE.C_10_Canister_Rifle_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in C_10_Canister_Rifle_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeFragmentation_Grenade_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeFragmentation_Grenade_get"); } 
return bridgePINVOKE.WeaponTypeFragmentation_Grenade_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeFragmentation_Grenade_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSpider_Mines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSpider_Mines_get"); } 
return bridgePINVOKE.WeaponTypeSpider_Mines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSpider_Mines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Twin_Autocannons_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Twin_Autocannons_get"); } 
return bridgePINVOKE.Twin_Autocannons_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Twin_Autocannons_get: ",e);}
throw e;
   }     
}
}


public IntPtr Hellfire_Missile_Pack_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Hellfire_Missile_Pack_get"); } 
return bridgePINVOKE.Hellfire_Missile_Pack_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Hellfire_Missile_Pack_get: ",e);}
throw e;
   }     
}
}


public IntPtr Arclite_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Arclite_Cannon_get"); } 
return bridgePINVOKE.Arclite_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Arclite_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Fusion_Cutter_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Fusion_Cutter_get"); } 
return bridgePINVOKE.Fusion_Cutter_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Fusion_Cutter_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeGemini_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeGemini_Missiles_get"); } 
return bridgePINVOKE.WeaponTypeGemini_Missiles_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeGemini_Missiles_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeBurst_Lasers_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeBurst_Lasers_get"); } 
return bridgePINVOKE.WeaponTypeBurst_Lasers_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeBurst_Lasers_get: ",e);}
throw e;
   }     
}
}


public IntPtr ATS_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ATS_Laser_Battery_get"); } 
return bridgePINVOKE.ATS_Laser_Battery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ATS_Laser_Battery_get: ",e);}
throw e;
   }     
}
}


public IntPtr ATA_Laser_Battery_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ATA_Laser_Battery_get"); } 
return bridgePINVOKE.ATA_Laser_Battery_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ATA_Laser_Battery_get: ",e);}
throw e;
   }     
}
}


public IntPtr Flame_Thrower_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Flame_Thrower_get"); } 
return bridgePINVOKE.Flame_Thrower_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Flame_Thrower_get: ",e);}
throw e;
   }     
}
}


public IntPtr Arclite_Shock_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Arclite_Shock_Cannon_get"); } 
return bridgePINVOKE.Arclite_Shock_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Arclite_Shock_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeLongbolt_Missile_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeLongbolt_Missile_get"); } 
return bridgePINVOKE.WeaponTypeLongbolt_Missile_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeLongbolt_Missile_get: ",e);}
throw e;
   }     
}
}


public IntPtr Claws_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Claws_get"); } 
return bridgePINVOKE.Claws_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Claws_get: ",e);}
throw e;
   }     
}
}


public IntPtr Needle_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Needle_Spines_get"); } 
return bridgePINVOKE.Needle_Spines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Needle_Spines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Kaiser_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Kaiser_Blades_get"); } 
return bridgePINVOKE.Kaiser_Blades_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Kaiser_Blades_get: ",e);}
throw e;
   }     
}
}


public IntPtr Toxic_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Toxic_Spores_get"); } 
return bridgePINVOKE.Toxic_Spores_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Toxic_Spores_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spines_get"); } 
return bridgePINVOKE.Spines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spines_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeAcid_Spore_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeAcid_Spore_get"); } 
return bridgePINVOKE.WeaponTypeAcid_Spore_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeAcid_Spore_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeGlave_Wurm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeGlave_Wurm_get"); } 
return bridgePINVOKE.WeaponTypeGlave_Wurm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeGlave_Wurm_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSeeker_Spores_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSeeker_Spores_get"); } 
return bridgePINVOKE.WeaponTypeSeeker_Spores_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSeeker_Spores_get: ",e);}
throw e;
   }     
}
}


public IntPtr Subterranean_Tentacle_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Subterranean_Tentacle_get"); } 
return bridgePINVOKE.Subterranean_Tentacle_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Subterranean_Tentacle_get: ",e);}
throw e;
   }     
}
}


public IntPtr Suicide_Infested_Terran_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Suicide_Infested_Terran_get"); } 
return bridgePINVOKE.Suicide_Infested_Terran_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Suicide_Infested_Terran_get: ",e);}
throw e;
   }     
}
}


public IntPtr Suicide_Scourge_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Suicide_Scourge_get"); } 
return bridgePINVOKE.Suicide_Scourge_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Suicide_Scourge_get: ",e);}
throw e;
   }     
}
}


public IntPtr Particle_Beam_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Particle_Beam_get"); } 
return bridgePINVOKE.Particle_Beam_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Particle_Beam_get: ",e);}
throw e;
   }     
}
}


public IntPtr Psi_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Psi_Blades_get"); } 
return bridgePINVOKE.Psi_Blades_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Psi_Blades_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypePhase_Disruptor_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypePhase_Disruptor_get"); } 
return bridgePINVOKE.WeaponTypePhase_Disruptor_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypePhase_Disruptor_get: ",e);}
throw e;
   }     
}
}


public IntPtr Psionic_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Psionic_Shockwave_get"); } 
return bridgePINVOKE.Psionic_Shockwave_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Psionic_Shockwave_get: ",e);}
throw e;
   }     
}
}


public IntPtr Dual_Photon_Blasters_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Dual_Photon_Blasters_get"); } 
return bridgePINVOKE.Dual_Photon_Blasters_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Dual_Photon_Blasters_get: ",e);}
throw e;
   }     
}
}


public IntPtr Anti_Matter_Missiles_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Anti_Matter_Missiles_get"); } 
return bridgePINVOKE.Anti_Matter_Missiles_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Anti_Matter_Missiles_get: ",e);}
throw e;
   }     
}
}


public IntPtr Phase_Disruptor_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Phase_Disruptor_Cannon_get"); } 
return bridgePINVOKE.Phase_Disruptor_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Phase_Disruptor_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypePulse_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypePulse_Cannon_get"); } 
return bridgePINVOKE.WeaponTypePulse_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypePulse_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr STS_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - STS_Photon_Cannon_get"); } 
return bridgePINVOKE.STS_Photon_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in STS_Photon_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr STA_Photon_Cannon_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - STA_Photon_Cannon_get"); } 
return bridgePINVOKE.STA_Photon_Cannon_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in STA_Photon_Cannon_get: ",e);}
throw e;
   }     
}
}


public IntPtr Scarab_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Scarab_get"); } 
return bridgePINVOKE.Scarab_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Scarab_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeNeutron_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeNeutron_Flare_get"); } 
return bridgePINVOKE.WeaponTypeNeutron_Flare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeNeutron_Flare_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeHalo_Rockets_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeHalo_Rockets_get"); } 
return bridgePINVOKE.WeaponTypeHalo_Rockets_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeHalo_Rockets_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeCorrosive_Acid_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeCorrosive_Acid_get"); } 
return bridgePINVOKE.WeaponTypeCorrosive_Acid_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeCorrosive_Acid_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSubterranean_Spines_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSubterranean_Spines_get"); } 
return bridgePINVOKE.WeaponTypeSubterranean_Spines_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSubterranean_Spines_get: ",e);}
throw e;
   }     
}
}


public IntPtr Warp_Blades_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Warp_Blades_get"); } 
return bridgePINVOKE.Warp_Blades_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Warp_Blades_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeYamato_Gun_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeYamato_Gun_get"); } 
return bridgePINVOKE.WeaponTypeYamato_Gun_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeYamato_Gun_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeNuclear_Strike_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeNuclear_Strike_get"); } 
return bridgePINVOKE.WeaponTypeNuclear_Strike_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeNuclear_Strike_get: ",e);}
throw e;
   }     
}
}


public IntPtr Lockdown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Lockdown_get"); } 
return bridgePINVOKE.Lockdown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Lockdown_get: ",e);}
throw e;
   }     
}
}


public IntPtr EMP_Shockwave_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - EMP_Shockwave_get"); } 
return bridgePINVOKE.EMP_Shockwave_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in EMP_Shockwave_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeIrradiate_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeIrradiate_get"); } 
return bridgePINVOKE.WeaponTypeIrradiate_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeIrradiate_get: ",e);}
throw e;
   }     
}
}


public IntPtr Parasite_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Parasite_get"); } 
return bridgePINVOKE.Parasite_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Parasite_get: ",e);}
throw e;
   }     
}
}


public IntPtr Spawn_Broodlings_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Spawn_Broodlings_get"); } 
return bridgePINVOKE.Spawn_Broodlings_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Spawn_Broodlings_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeEnsnare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeEnsnare_get"); } 
return bridgePINVOKE.WeaponTypeEnsnare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeEnsnare_get: ",e);}
throw e;
   }     
}
}


public IntPtr Dark_Swarm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Dark_Swarm_get"); } 
return bridgePINVOKE.Dark_Swarm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Dark_Swarm_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypePlague_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypePlague_get"); } 
return bridgePINVOKE.WeaponTypePlague_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypePlague_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeConsume_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeConsume_get"); } 
return bridgePINVOKE.WeaponTypeConsume_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeConsume_get: ",e);}
throw e;
   }     
}
}


public IntPtr Stasis_Field_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Stasis_Field_get"); } 
return bridgePINVOKE.Stasis_Field_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Stasis_Field_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypePsionic_Storm_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypePsionic_Storm_get"); } 
return bridgePINVOKE.WeaponTypePsionic_Storm_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypePsionic_Storm_get: ",e);}
throw e;
   }     
}
}


public IntPtr Disruption_Web_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Disruption_Web_get"); } 
return bridgePINVOKE.Disruption_Web_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Disruption_Web_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeRestoration_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeRestoration_get"); } 
return bridgePINVOKE.WeaponTypeRestoration_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeRestoration_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeMind_Control_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeMind_Control_get"); } 
return bridgePINVOKE.WeaponTypeMind_Control_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeMind_Control_get: ",e);}
throw e;
   }     
}
}


public IntPtr Feedback_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Feedback_get"); } 
return bridgePINVOKE.Feedback_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Feedback_get: ",e);}
throw e;
   }     
}
}


public IntPtr Optical_Flare_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Optical_Flare_get"); } 
return bridgePINVOKE.Optical_Flare_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Optical_Flare_get: ",e);}
throw e;
   }     
}
}


public IntPtr Maelstrom_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Maelstrom_get"); } 
return bridgePINVOKE.Maelstrom_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Maelstrom_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeNone_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeNone_get"); } 
return bridgePINVOKE.WeaponTypeNone_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeNone_get: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeUnknown_get( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeUnknown_get"); } 
return bridgePINVOKE.WeaponTypeUnknown_get();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeUnknown_get: ",e);}
throw e;
   }     
}
}


public IntPtr monobridgeutil_getLastUnitParam( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - monobridgeutil_getLastUnitParam"); } 
return bridgePINVOKE.monobridgeutil_getLastUnitParam();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in monobridgeutil_getLastUnitParam: ",e);}
throw e;
   }     
}
}


public IntPtr new_monobridgeutil( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_monobridgeutil"); } 
return bridgePINVOKE.new_monobridgeutil();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_monobridgeutil: ",e);}
throw e;
   }     
}
}


public void delete_monobridgeutil(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_monobridgeutil"); } 
bridgePINVOKE.delete_monobridgeutil(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_monobridgeutil: ",e);}
throw e;
   }     
}
}


public IntPtr new_RectangleArrayDouble__SWIG_0(uint jarg1, uint jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RectangleArrayDouble__SWIG_0"); } 
return bridgePINVOKE.new_RectangleArrayDouble__SWIG_0(jarg1, jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RectangleArrayDouble__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_RectangleArrayDouble__SWIG_1(uint jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RectangleArrayDouble__SWIG_1"); } 
return bridgePINVOKE.new_RectangleArrayDouble__SWIG_1(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RectangleArrayDouble__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_RectangleArrayDouble__SWIG_2(uint jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RectangleArrayDouble__SWIG_2"); } 
return bridgePINVOKE.new_RectangleArrayDouble__SWIG_2(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RectangleArrayDouble__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr new_RectangleArrayDouble__SWIG_3( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RectangleArrayDouble__SWIG_3"); } 
return bridgePINVOKE.new_RectangleArrayDouble__SWIG_3();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RectangleArrayDouble__SWIG_3: ",e);}
throw e;
   }     
}
}


public IntPtr new_RectangleArrayDouble__SWIG_4(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RectangleArrayDouble__SWIG_4"); } 
return bridgePINVOKE.new_RectangleArrayDouble__SWIG_4(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RectangleArrayDouble__SWIG_4: ",e);}
throw e;
   }     
}
}


public void delete_RectangleArrayDouble(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_RectangleArrayDouble"); } 
bridgePINVOKE.delete_RectangleArrayDouble(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_RectangleArrayDouble: ",e);}
throw e;
   }     
}
}


public uint RectangleArrayDouble_getWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_getWidth"); } 
return bridgePINVOKE.RectangleArrayDouble_getWidth(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_getWidth: ",e);}
throw e;
   }     
}
}


public uint RectangleArrayDouble_getHeight(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_getHeight"); } 
return bridgePINVOKE.RectangleArrayDouble_getHeight(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_getHeight: ",e);}
throw e;
   }     
}
}


public IntPtr RectangleArrayDouble_getItem(IntPtr jarg1, uint jarg2, uint jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_getItem"); } 
return bridgePINVOKE.RectangleArrayDouble_getItem(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_getItem: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_setItem(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_setItem"); } 
bridgePINVOKE.RectangleArrayDouble_setItem(new HandleRef(null,jarg1), jarg2, jarg3, new HandleRef(null,jarg4));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_setItem: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_resize(IntPtr jarg1, uint jarg2, uint jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_resize"); } 
bridgePINVOKE.RectangleArrayDouble_resize(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_resize: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_printToFile(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_printToFile"); } 
bridgePINVOKE.RectangleArrayDouble_printToFile(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_printToFile: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_saveToFile(IntPtr jarg1, string jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_saveToFile"); } 
bridgePINVOKE.RectangleArrayDouble_saveToFile(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_saveToFile: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_setTo(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_setTo"); } 
bridgePINVOKE.RectangleArrayDouble_setTo(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_setTo: ",e);}
throw e;
   }     
}
}


public void RectangleArrayDouble_setBorderTo(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RectangleArrayDouble_setBorderTo"); } 
bridgePINVOKE.RectangleArrayDouble_setBorderTo(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RectangleArrayDouble_setBorderTo: ",e);}
throw e;
   }     
}
}


public void readMap( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - readMap"); } 
bridgePINVOKE.readMap();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in readMap: ",e);}
throw e;
   }     
}
}


public void analyze( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - analyze"); } 
bridgePINVOKE.analyze();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in analyze: ",e);}
throw e;
   }     
}
}


public IntPtr getRegions( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getRegions"); } 
return bridgePINVOKE.getRegions();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getRegions: ",e);}
throw e;
   }     
}
}


public IntPtr getChokepoints( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getChokepoints"); } 
return bridgePINVOKE.getChokepoints();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getChokepoints: ",e);}
throw e;
   }     
}
}


public IntPtr getBaseLocations( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getBaseLocations"); } 
return bridgePINVOKE.getBaseLocations();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getBaseLocations: ",e);}
throw e;
   }     
}
}


public IntPtr getStartLocations( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getStartLocations"); } 
return bridgePINVOKE.getStartLocations();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getStartLocations: ",e);}
throw e;
   }     
}
}


public IntPtr getUnwalkablePolygons( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getUnwalkablePolygons"); } 
return bridgePINVOKE.getUnwalkablePolygons();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getUnwalkablePolygons: ",e);}
throw e;
   }     
}
}


public IntPtr getStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getStartLocation"); } 
return bridgePINVOKE.getStartLocation(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getStartLocation: ",e);}
throw e;
   }     
}
}


public IntPtr getRegion__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getRegion__SWIG_0"); } 
return bridgePINVOKE.getRegion__SWIG_0(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getRegion__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr getRegion__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getRegion__SWIG_1"); } 
return bridgePINVOKE.getRegion__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getRegion__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestChokepoint__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestChokepoint__SWIG_0"); } 
return bridgePINVOKE.getNearestChokepoint__SWIG_0(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestChokepoint__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestChokepoint__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestChokepoint__SWIG_1"); } 
return bridgePINVOKE.getNearestChokepoint__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestChokepoint__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestBaseLocation__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestBaseLocation__SWIG_0"); } 
return bridgePINVOKE.getNearestBaseLocation__SWIG_0(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestBaseLocation__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestBaseLocation__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestBaseLocation__SWIG_1"); } 
return bridgePINVOKE.getNearestBaseLocation__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestBaseLocation__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestUnwalkablePolygon__SWIG_0(int jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestUnwalkablePolygon__SWIG_0"); } 
return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_0(jarg1, jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestUnwalkablePolygon__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestUnwalkablePolygon__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestUnwalkablePolygon__SWIG_1"); } 
return bridgePINVOKE.getNearestUnwalkablePolygon__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestUnwalkablePolygon__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestUnwalkablePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestUnwalkablePosition"); } 
return bridgePINVOKE.getNearestUnwalkablePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestUnwalkablePosition: ",e);}
throw e;
   }     
}
}


public bool isConnected__SWIG_0(int jarg1, int jarg2, int jarg3, int jarg4) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - isConnected__SWIG_0"); } 
return bridgePINVOKE.isConnected__SWIG_0(jarg1, jarg2, jarg3, jarg4);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in isConnected__SWIG_0: ",e);}
throw e;
   }     
}
}


public bool isConnected__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - isConnected__SWIG_1"); } 
return bridgePINVOKE.isConnected__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in isConnected__SWIG_1: ",e);}
throw e;
   }     
}
}


public double getGroundDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getGroundDistance"); } 
return bridgePINVOKE.getGroundDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getGroundDistance: ",e);}
throw e;
   }     
}
}


public IntPtr getNearestTilePosition(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getNearestTilePosition"); } 
return bridgePINVOKE.getNearestTilePosition(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getNearestTilePosition: ",e);}
throw e;
   }     
}
}


public IntPtr getGroundDistances(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getGroundDistances"); } 
return bridgePINVOKE.getGroundDistances(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getGroundDistances: ",e);}
throw e;
   }     
}
}


public void getGroundDistanceMap(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getGroundDistanceMap"); } 
bridgePINVOKE.getGroundDistanceMap(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getGroundDistanceMap: ",e);}
throw e;
   }     
}
}


public IntPtr getShortestPath__SWIG_0(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getShortestPath__SWIG_0"); } 
return bridgePINVOKE.getShortestPath__SWIG_0(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getShortestPath__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr getShortestPath__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - getShortestPath__SWIG_1"); } 
return bridgePINVOKE.getShortestPath__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in getShortestPath__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getPosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getPosition"); } 
return bridgePINVOKE.BaseLocation_getPosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getPosition: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getTilePosition(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getTilePosition"); } 
return bridgePINVOKE.BaseLocation_getTilePosition(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getTilePosition: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getRegion(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getRegion"); } 
return bridgePINVOKE.BaseLocation_getRegion(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getRegion: ",e);}
throw e;
   }     
}
}


public int BaseLocation_minerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_minerals"); } 
return bridgePINVOKE.BaseLocation_minerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_minerals: ",e);}
throw e;
   }     
}
}


public int BaseLocation_gas(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_gas"); } 
return bridgePINVOKE.BaseLocation_gas(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_gas: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getMinerals"); } 
return bridgePINVOKE.BaseLocation_getMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getMinerals: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getStaticMinerals(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getStaticMinerals"); } 
return bridgePINVOKE.BaseLocation_getStaticMinerals(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getStaticMinerals: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocation_getGeysers(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getGeysers"); } 
return bridgePINVOKE.BaseLocation_getGeysers(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getGeysers: ",e);}
throw e;
   }     
}
}


public double BaseLocation_getGroundDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getGroundDistance"); } 
return bridgePINVOKE.BaseLocation_getGroundDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getGroundDistance: ",e);}
throw e;
   }     
}
}


public double BaseLocation_getAirDistance(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_getAirDistance"); } 
return bridgePINVOKE.BaseLocation_getAirDistance(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_getAirDistance: ",e);}
throw e;
   }     
}
}


public bool BaseLocation_isIsland(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_isIsland"); } 
return bridgePINVOKE.BaseLocation_isIsland(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_isIsland: ",e);}
throw e;
   }     
}
}


public bool BaseLocation_isMineralOnly(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_isMineralOnly"); } 
return bridgePINVOKE.BaseLocation_isMineralOnly(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_isMineralOnly: ",e);}
throw e;
   }     
}
}


public bool BaseLocation_isStartLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocation_isStartLocation"); } 
return bridgePINVOKE.BaseLocation_isStartLocation(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocation_isStartLocation: ",e);}
throw e;
   }     
}
}


public void delete_BaseLocation(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_BaseLocation"); } 
bridgePINVOKE.delete_BaseLocation(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_BaseLocation: ",e);}
throw e;
   }     
}
}


public IntPtr Chokepoint_getRegions(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Chokepoint_getRegions"); } 
return bridgePINVOKE.Chokepoint_getRegions(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Chokepoint_getRegions: ",e);}
throw e;
   }     
}
}


public IntPtr Chokepoint_getSides(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Chokepoint_getSides"); } 
return bridgePINVOKE.Chokepoint_getSides(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Chokepoint_getSides: ",e);}
throw e;
   }     
}
}


public IntPtr Chokepoint_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Chokepoint_getCenter"); } 
return bridgePINVOKE.Chokepoint_getCenter(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Chokepoint_getCenter: ",e);}
throw e;
   }     
}
}


public double Chokepoint_getWidth(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Chokepoint_getWidth"); } 
return bridgePINVOKE.Chokepoint_getWidth(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Chokepoint_getWidth: ",e);}
throw e;
   }     
}
}


public void delete_Chokepoint(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Chokepoint"); } 
bridgePINVOKE.delete_Chokepoint(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Chokepoint: ",e);}
throw e;
   }     
}
}


public void PositionVector_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Clear"); } 
bridgePINVOKE.PositionVector_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Clear: ",e);}
throw e;
   }     
}
}


public void PositionVector_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Add"); } 
bridgePINVOKE.PositionVector_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Add: ",e);}
throw e;
   }     
}
}


public uint PositionVector_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_size"); } 
return bridgePINVOKE.PositionVector_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_size: ",e);}
throw e;
   }     
}
}


public uint PositionVector_capacity(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_capacity"); } 
return bridgePINVOKE.PositionVector_capacity(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_capacity: ",e);}
throw e;
   }     
}
}


public void PositionVector_reserve(IntPtr jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_reserve"); } 
bridgePINVOKE.PositionVector_reserve(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_reserve: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionVector__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionVector__SWIG_0"); } 
return bridgePINVOKE.new_PositionVector__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionVector__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionVector__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionVector__SWIG_1"); } 
return bridgePINVOKE.new_PositionVector__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionVector__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionVector__SWIG_2(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionVector__SWIG_2"); } 
return bridgePINVOKE.new_PositionVector__SWIG_2(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionVector__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr PositionVector_getitemcopy(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_getitemcopy"); } 
return bridgePINVOKE.PositionVector_getitemcopy(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_getitemcopy: ",e);}
throw e;
   }     
}
}


public IntPtr PositionVector_getitem(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_getitem"); } 
return bridgePINVOKE.PositionVector_getitem(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_getitem: ",e);}
throw e;
   }     
}
}


public void PositionVector_setitem(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_setitem"); } 
bridgePINVOKE.PositionVector_setitem(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_setitem: ",e);}
throw e;
   }     
}
}


public void PositionVector_AddRange(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_AddRange"); } 
bridgePINVOKE.PositionVector_AddRange(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_AddRange: ",e);}
throw e;
   }     
}
}


public IntPtr PositionVector_GetRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_GetRange"); } 
return bridgePINVOKE.PositionVector_GetRange(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_GetRange: ",e);}
throw e;
   }     
}
}


public void PositionVector_Insert(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Insert"); } 
bridgePINVOKE.PositionVector_Insert(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Insert: ",e);}
throw e;
   }     
}
}


public void PositionVector_InsertRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_InsertRange"); } 
bridgePINVOKE.PositionVector_InsertRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_InsertRange: ",e);}
throw e;
   }     
}
}


public void PositionVector_RemoveAt(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_RemoveAt"); } 
bridgePINVOKE.PositionVector_RemoveAt(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_RemoveAt: ",e);}
throw e;
   }     
}
}


public void PositionVector_RemoveRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_RemoveRange"); } 
bridgePINVOKE.PositionVector_RemoveRange(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_RemoveRange: ",e);}
throw e;
   }     
}
}


public IntPtr PositionVector_Repeat(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Repeat"); } 
return bridgePINVOKE.PositionVector_Repeat(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Repeat: ",e);}
throw e;
   }     
}
}


public void PositionVector_Reverse__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Reverse__SWIG_0"); } 
bridgePINVOKE.PositionVector_Reverse__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Reverse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void PositionVector_Reverse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_Reverse__SWIG_1"); } 
bridgePINVOKE.PositionVector_Reverse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_Reverse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void PositionVector_SetRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionVector_SetRange"); } 
bridgePINVOKE.PositionVector_SetRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionVector_SetRange: ",e);}
throw e;
   }     
}
}


public void delete_PositionVector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PositionVector"); } 
bridgePINVOKE.delete_PositionVector(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PositionVector: ",e);}
throw e;
   }     
}
}


public IntPtr new_Polygon( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_Polygon"); } 
return bridgePINVOKE.new_Polygon();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_Polygon: ",e);}
throw e;
   }     
}
}


public double Polygon_getArea(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Polygon_getArea"); } 
return bridgePINVOKE.Polygon_getArea(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Polygon_getArea: ",e);}
throw e;
   }     
}
}


public double Polygon_getPerimeter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Polygon_getPerimeter"); } 
return bridgePINVOKE.Polygon_getPerimeter(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Polygon_getPerimeter: ",e);}
throw e;
   }     
}
}


public IntPtr Polygon_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Polygon_getCenter"); } 
return bridgePINVOKE.Polygon_getCenter(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Polygon_getCenter: ",e);}
throw e;
   }     
}
}


public bool Polygon_isInside(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Polygon_isInside"); } 
return bridgePINVOKE.Polygon_isInside(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Polygon_isInside: ",e);}
throw e;
   }     
}
}


public IntPtr Polygon_getNearestPoint(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Polygon_getNearestPoint"); } 
return bridgePINVOKE.Polygon_getNearestPoint(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Polygon_getNearestPoint: ",e);}
throw e;
   }     
}
}


public void delete_Polygon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Polygon"); } 
bridgePINVOKE.delete_Polygon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Polygon: ",e);}
throw e;
   }     
}
}


public IntPtr Region_getPolygon(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_getPolygon"); } 
return bridgePINVOKE.Region_getPolygon(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_getPolygon: ",e);}
throw e;
   }     
}
}


public IntPtr Region_getCenter(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_getCenter"); } 
return bridgePINVOKE.Region_getCenter(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_getCenter: ",e);}
throw e;
   }     
}
}


public IntPtr Region_getChokepoints(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_getChokepoints"); } 
return bridgePINVOKE.Region_getChokepoints(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_getChokepoints: ",e);}
throw e;
   }     
}
}


public IntPtr Region_getBaseLocations(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_getBaseLocations"); } 
return bridgePINVOKE.Region_getBaseLocations(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_getBaseLocations: ",e);}
throw e;
   }     
}
}


public bool Region_isReachable(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_isReachable"); } 
return bridgePINVOKE.Region_isReachable(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_isReachable: ",e);}
throw e;
   }     
}
}


public IntPtr Region_getReachableRegions(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - Region_getReachableRegions"); } 
return bridgePINVOKE.Region_getReachableRegions(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in Region_getReachableRegions: ",e);}
throw e;
   }     
}
}


public void delete_Region(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_Region"); } 
bridgePINVOKE.delete_Region(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_Region: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSet__SWIG_0"); } 
return bridgePINVOKE.new_UnitSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSet__SWIG_1"); } 
return bridgePINVOKE.new_UnitSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UnitSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_size"); } 
return bridgePINVOKE.UnitSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_size: ",e);}
throw e;
   }     
}
}


public bool UnitSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_empty"); } 
return bridgePINVOKE.UnitSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_empty: ",e);}
throw e;
   }     
}
}


public void UnitSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_Clear"); } 
bridgePINVOKE.UnitSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_getitem"); } 
return bridgePINVOKE.UnitSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UnitSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_ContainsKey"); } 
return bridgePINVOKE.UnitSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UnitSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_Add"); } 
bridgePINVOKE.UnitSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_Add: ",e);}
throw e;
   }     
}
}


public bool UnitSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_Remove"); } 
return bridgePINVOKE.UnitSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_create_iterator_begin"); } 
return bridgePINVOKE.UnitSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSet_get_next_key"); } 
return bridgePINVOKE.UnitSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitSet"); } 
bridgePINVOKE.delete_UnitSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_AttackTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AttackTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_AttackTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AttackTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_AttackTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_AttackTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_AttackTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_AttackTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint AttackTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_size"); } 
return bridgePINVOKE.AttackTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool AttackTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_empty"); } 
return bridgePINVOKE.AttackTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void AttackTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_Clear"); } 
bridgePINVOKE.AttackTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_getitem"); } 
return bridgePINVOKE.AttackTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool AttackTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_ContainsKey"); } 
return bridgePINVOKE.AttackTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void AttackTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_Add"); } 
bridgePINVOKE.AttackTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool AttackTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_Remove"); } 
return bridgePINVOKE.AttackTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.AttackTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr AttackTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - AttackTypeSet_get_next_key"); } 
return bridgePINVOKE.AttackTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in AttackTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_AttackTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_AttackTypeSet"); } 
bridgePINVOKE.delete_AttackTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_AttackTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_DamageTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_DamageTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_DamageTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_DamageTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_DamageTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_DamageTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_DamageTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_DamageTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint DamageTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_size"); } 
return bridgePINVOKE.DamageTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool DamageTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_empty"); } 
return bridgePINVOKE.DamageTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void DamageTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_Clear"); } 
bridgePINVOKE.DamageTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_getitem"); } 
return bridgePINVOKE.DamageTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool DamageTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_ContainsKey"); } 
return bridgePINVOKE.DamageTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void DamageTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_Add"); } 
bridgePINVOKE.DamageTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool DamageTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_Remove"); } 
return bridgePINVOKE.DamageTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.DamageTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr DamageTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - DamageTypeSet_get_next_key"); } 
return bridgePINVOKE.DamageTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in DamageTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_DamageTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_DamageTypeSet"); } 
bridgePINVOKE.delete_DamageTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_DamageTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_ErrorSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ErrorSet__SWIG_0"); } 
return bridgePINVOKE.new_ErrorSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ErrorSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_ErrorSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ErrorSet__SWIG_1"); } 
return bridgePINVOKE.new_ErrorSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ErrorSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint ErrorSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_size"); } 
return bridgePINVOKE.ErrorSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_size: ",e);}
throw e;
   }     
}
}


public bool ErrorSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_empty"); } 
return bridgePINVOKE.ErrorSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_empty: ",e);}
throw e;
   }     
}
}


public void ErrorSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_Clear"); } 
bridgePINVOKE.ErrorSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr ErrorSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_getitem"); } 
return bridgePINVOKE.ErrorSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_getitem: ",e);}
throw e;
   }     
}
}


public bool ErrorSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_ContainsKey"); } 
return bridgePINVOKE.ErrorSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void ErrorSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_Add"); } 
bridgePINVOKE.ErrorSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_Add: ",e);}
throw e;
   }     
}
}


public bool ErrorSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_Remove"); } 
return bridgePINVOKE.ErrorSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr ErrorSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_create_iterator_begin"); } 
return bridgePINVOKE.ErrorSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr ErrorSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ErrorSet_get_next_key"); } 
return bridgePINVOKE.ErrorSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ErrorSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_ErrorSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_ErrorSet"); } 
bridgePINVOKE.delete_ErrorSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_ErrorSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_ExplosionTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ExplosionTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_ExplosionTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ExplosionTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_ExplosionTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ExplosionTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_ExplosionTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ExplosionTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint ExplosionTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_size"); } 
return bridgePINVOKE.ExplosionTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool ExplosionTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_empty"); } 
return bridgePINVOKE.ExplosionTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void ExplosionTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_Clear"); } 
bridgePINVOKE.ExplosionTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_getitem"); } 
return bridgePINVOKE.ExplosionTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool ExplosionTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_ContainsKey"); } 
return bridgePINVOKE.ExplosionTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void ExplosionTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_Add"); } 
bridgePINVOKE.ExplosionTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool ExplosionTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_Remove"); } 
return bridgePINVOKE.ExplosionTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.ExplosionTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr ExplosionTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ExplosionTypeSet_get_next_key"); } 
return bridgePINVOKE.ExplosionTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ExplosionTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_ExplosionTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_ExplosionTypeSet"); } 
bridgePINVOKE.delete_ExplosionTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_ExplosionTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_ForcePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ForcePtrSet__SWIG_0"); } 
return bridgePINVOKE.new_ForcePtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ForcePtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_ForcePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ForcePtrSet__SWIG_1"); } 
return bridgePINVOKE.new_ForcePtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ForcePtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint ForcePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_size"); } 
return bridgePINVOKE.ForcePtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_size: ",e);}
throw e;
   }     
}
}


public bool ForcePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_empty"); } 
return bridgePINVOKE.ForcePtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_empty: ",e);}
throw e;
   }     
}
}


public void ForcePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_Clear"); } 
bridgePINVOKE.ForcePtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr ForcePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_getitem"); } 
return bridgePINVOKE.ForcePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool ForcePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_ContainsKey"); } 
return bridgePINVOKE.ForcePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void ForcePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_Add"); } 
bridgePINVOKE.ForcePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool ForcePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_Remove"); } 
return bridgePINVOKE.ForcePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr ForcePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_create_iterator_begin"); } 
return bridgePINVOKE.ForcePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr ForcePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ForcePtrSet_get_next_key"); } 
return bridgePINVOKE.ForcePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ForcePtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_ForcePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_ForcePtrSet"); } 
bridgePINVOKE.delete_ForcePtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_ForcePtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_OrderSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_OrderSet__SWIG_0"); } 
return bridgePINVOKE.new_OrderSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_OrderSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_OrderSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_OrderSet__SWIG_1"); } 
return bridgePINVOKE.new_OrderSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_OrderSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint OrderSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_size"); } 
return bridgePINVOKE.OrderSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_size: ",e);}
throw e;
   }     
}
}


public bool OrderSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_empty"); } 
return bridgePINVOKE.OrderSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_empty: ",e);}
throw e;
   }     
}
}


public void OrderSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_Clear"); } 
bridgePINVOKE.OrderSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr OrderSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_getitem"); } 
return bridgePINVOKE.OrderSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_getitem: ",e);}
throw e;
   }     
}
}


public bool OrderSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_ContainsKey"); } 
return bridgePINVOKE.OrderSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void OrderSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_Add"); } 
bridgePINVOKE.OrderSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_Add: ",e);}
throw e;
   }     
}
}


public bool OrderSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_Remove"); } 
return bridgePINVOKE.OrderSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr OrderSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_create_iterator_begin"); } 
return bridgePINVOKE.OrderSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr OrderSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - OrderSet_get_next_key"); } 
return bridgePINVOKE.OrderSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in OrderSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_OrderSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_OrderSet"); } 
bridgePINVOKE.delete_OrderSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_OrderSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerPtrSet__SWIG_0"); } 
return bridgePINVOKE.new_PlayerPtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerPtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerPtrSet__SWIG_1"); } 
return bridgePINVOKE.new_PlayerPtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerPtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint PlayerPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_size"); } 
return bridgePINVOKE.PlayerPtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_size: ",e);}
throw e;
   }     
}
}


public bool PlayerPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_empty"); } 
return bridgePINVOKE.PlayerPtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_empty: ",e);}
throw e;
   }     
}
}


public void PlayerPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_Clear"); } 
bridgePINVOKE.PlayerPtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_getitem"); } 
return bridgePINVOKE.PlayerPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool PlayerPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_ContainsKey"); } 
return bridgePINVOKE.PlayerPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void PlayerPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_Add"); } 
bridgePINVOKE.PlayerPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool PlayerPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_Remove"); } 
return bridgePINVOKE.PlayerPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_create_iterator_begin"); } 
return bridgePINVOKE.PlayerPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerPtrSet_get_next_key"); } 
return bridgePINVOKE.PlayerPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerPtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_PlayerPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PlayerPtrSet"); } 
bridgePINVOKE.delete_PlayerPtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PlayerPtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_PlayerTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PlayerTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PlayerTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_PlayerTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PlayerTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint PlayerTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_size"); } 
return bridgePINVOKE.PlayerTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool PlayerTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_empty"); } 
return bridgePINVOKE.PlayerTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void PlayerTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_Clear"); } 
bridgePINVOKE.PlayerTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_getitem"); } 
return bridgePINVOKE.PlayerTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool PlayerTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_ContainsKey"); } 
return bridgePINVOKE.PlayerTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void PlayerTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_Add"); } 
bridgePINVOKE.PlayerTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool PlayerTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_Remove"); } 
return bridgePINVOKE.PlayerTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.PlayerTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr PlayerTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PlayerTypeSet_get_next_key"); } 
return bridgePINVOKE.PlayerTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PlayerTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_PlayerTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PlayerTypeSet"); } 
bridgePINVOKE.delete_PlayerTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PlayerTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_RaceSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RaceSet__SWIG_0"); } 
return bridgePINVOKE.new_RaceSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RaceSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_RaceSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RaceSet__SWIG_1"); } 
return bridgePINVOKE.new_RaceSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RaceSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint RaceSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_size"); } 
return bridgePINVOKE.RaceSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_size: ",e);}
throw e;
   }     
}
}


public bool RaceSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_empty"); } 
return bridgePINVOKE.RaceSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_empty: ",e);}
throw e;
   }     
}
}


public void RaceSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_Clear"); } 
bridgePINVOKE.RaceSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr RaceSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_getitem"); } 
return bridgePINVOKE.RaceSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_getitem: ",e);}
throw e;
   }     
}
}


public bool RaceSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_ContainsKey"); } 
return bridgePINVOKE.RaceSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void RaceSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_Add"); } 
bridgePINVOKE.RaceSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_Add: ",e);}
throw e;
   }     
}
}


public bool RaceSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_Remove"); } 
return bridgePINVOKE.RaceSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr RaceSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_create_iterator_begin"); } 
return bridgePINVOKE.RaceSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr RaceSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RaceSet_get_next_key"); } 
return bridgePINVOKE.RaceSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RaceSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_RaceSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_RaceSet"); } 
bridgePINVOKE.delete_RaceSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_RaceSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechTypePtrSet__SWIG_0"); } 
return bridgePINVOKE.new_TechTypePtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechTypePtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechTypePtrSet__SWIG_1"); } 
return bridgePINVOKE.new_TechTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechTypePtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint TechTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_size"); } 
return bridgePINVOKE.TechTypePtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_size: ",e);}
throw e;
   }     
}
}


public bool TechTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_empty"); } 
return bridgePINVOKE.TechTypePtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_empty: ",e);}
throw e;
   }     
}
}


public void TechTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_Clear"); } 
bridgePINVOKE.TechTypePtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_getitem"); } 
return bridgePINVOKE.TechTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool TechTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_ContainsKey"); } 
return bridgePINVOKE.TechTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void TechTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_Add"); } 
bridgePINVOKE.TechTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool TechTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_Remove"); } 
return bridgePINVOKE.TechTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_create_iterator_begin"); } 
return bridgePINVOKE.TechTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypePtrSet_get_next_key"); } 
return bridgePINVOKE.TechTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypePtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_TechTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TechTypePtrSet"); } 
bridgePINVOKE.delete_TechTypePtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TechTypePtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_TechTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TechTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TechTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_TechTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TechTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint TechTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_size"); } 
return bridgePINVOKE.TechTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool TechTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_empty"); } 
return bridgePINVOKE.TechTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void TechTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_Clear"); } 
bridgePINVOKE.TechTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_getitem"); } 
return bridgePINVOKE.TechTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool TechTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_ContainsKey"); } 
return bridgePINVOKE.TechTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void TechTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_Add"); } 
bridgePINVOKE.TechTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool TechTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_Remove"); } 
return bridgePINVOKE.TechTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.TechTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr TechTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TechTypeSet_get_next_key"); } 
return bridgePINVOKE.TechTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TechTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_TechTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TechTypeSet"); } 
bridgePINVOKE.delete_TechTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TechTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSizeTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSizeTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSizeTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitSizeTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitSizeTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_UnitSizeTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitSizeTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UnitSizeTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_size"); } 
return bridgePINVOKE.UnitSizeTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool UnitSizeTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_empty"); } 
return bridgePINVOKE.UnitSizeTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void UnitSizeTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_Clear"); } 
bridgePINVOKE.UnitSizeTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_getitem"); } 
return bridgePINVOKE.UnitSizeTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UnitSizeTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_ContainsKey"); } 
return bridgePINVOKE.UnitSizeTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UnitSizeTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_Add"); } 
bridgePINVOKE.UnitSizeTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool UnitSizeTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_Remove"); } 
return bridgePINVOKE.UnitSizeTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.UnitSizeTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitSizeTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitSizeTypeSet_get_next_key"); } 
return bridgePINVOKE.UnitSizeTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitSizeTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitSizeTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitSizeTypeSet"); } 
bridgePINVOKE.delete_UnitSizeTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitSizeTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrSet__SWIG_0"); } 
return bridgePINVOKE.new_UnitTypePtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrSet__SWIG_1"); } 
return bridgePINVOKE.new_UnitTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UnitTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_size"); } 
return bridgePINVOKE.UnitTypePtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_size: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_empty"); } 
return bridgePINVOKE.UnitTypePtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_empty: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_Clear"); } 
bridgePINVOKE.UnitTypePtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_getitem"); } 
return bridgePINVOKE.UnitTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_ContainsKey"); } 
return bridgePINVOKE.UnitTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_Add"); } 
bridgePINVOKE.UnitTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_Remove"); } 
return bridgePINVOKE.UnitTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_create_iterator_begin"); } 
return bridgePINVOKE.UnitTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrSet_get_next_key"); } 
return bridgePINVOKE.UnitTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitTypePtrSet"); } 
bridgePINVOKE.delete_UnitTypePtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitTypePtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_UnitTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_UnitTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UnitTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_size"); } 
return bridgePINVOKE.UnitTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool UnitTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_empty"); } 
return bridgePINVOKE.UnitTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void UnitTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_Clear"); } 
bridgePINVOKE.UnitTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_getitem"); } 
return bridgePINVOKE.UnitTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UnitTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_ContainsKey"); } 
return bridgePINVOKE.UnitTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UnitTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_Add"); } 
bridgePINVOKE.UnitTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool UnitTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_Remove"); } 
return bridgePINVOKE.UnitTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.UnitTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeSet_get_next_key"); } 
return bridgePINVOKE.UnitTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitTypeSet"); } 
bridgePINVOKE.delete_UnitTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeTypePtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeTypePtrSet__SWIG_0"); } 
return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeTypePtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeTypePtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeTypePtrSet__SWIG_1"); } 
return bridgePINVOKE.new_UpgradeTypePtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeTypePtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UpgradeTypePtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_size"); } 
return bridgePINVOKE.UpgradeTypePtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_size: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypePtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_empty"); } 
return bridgePINVOKE.UpgradeTypePtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_empty: ",e);}
throw e;
   }     
}
}


public void UpgradeTypePtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_Clear"); } 
bridgePINVOKE.UpgradeTypePtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypePtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_getitem"); } 
return bridgePINVOKE.UpgradeTypePtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypePtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_ContainsKey"); } 
return bridgePINVOKE.UpgradeTypePtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UpgradeTypePtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_Add"); } 
bridgePINVOKE.UpgradeTypePtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypePtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_Remove"); } 
return bridgePINVOKE.UpgradeTypePtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypePtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_create_iterator_begin"); } 
return bridgePINVOKE.UpgradeTypePtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypePtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypePtrSet_get_next_key"); } 
return bridgePINVOKE.UpgradeTypePtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypePtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UpgradeTypePtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UpgradeTypePtrSet"); } 
bridgePINVOKE.delete_UpgradeTypePtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UpgradeTypePtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_UpgradeTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UpgradeTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UpgradeTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_UpgradeTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UpgradeTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UpgradeTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_size"); } 
return bridgePINVOKE.UpgradeTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_empty"); } 
return bridgePINVOKE.UpgradeTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void UpgradeTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_Clear"); } 
bridgePINVOKE.UpgradeTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_getitem"); } 
return bridgePINVOKE.UpgradeTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_ContainsKey"); } 
return bridgePINVOKE.UpgradeTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UpgradeTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_Add"); } 
bridgePINVOKE.UpgradeTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool UpgradeTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_Remove"); } 
return bridgePINVOKE.UpgradeTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.UpgradeTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UpgradeTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UpgradeTypeSet_get_next_key"); } 
return bridgePINVOKE.UpgradeTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UpgradeTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UpgradeTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UpgradeTypeSet"); } 
bridgePINVOKE.delete_UpgradeTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UpgradeTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_WeaponTypeSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_WeaponTypeSet__SWIG_0"); } 
return bridgePINVOKE.new_WeaponTypeSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_WeaponTypeSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_WeaponTypeSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_WeaponTypeSet__SWIG_1"); } 
return bridgePINVOKE.new_WeaponTypeSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_WeaponTypeSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint WeaponTypeSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_size"); } 
return bridgePINVOKE.WeaponTypeSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_size: ",e);}
throw e;
   }     
}
}


public bool WeaponTypeSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_empty"); } 
return bridgePINVOKE.WeaponTypeSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_empty: ",e);}
throw e;
   }     
}
}


public void WeaponTypeSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_Clear"); } 
bridgePINVOKE.WeaponTypeSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_getitem"); } 
return bridgePINVOKE.WeaponTypeSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_getitem: ",e);}
throw e;
   }     
}
}


public bool WeaponTypeSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_ContainsKey"); } 
return bridgePINVOKE.WeaponTypeSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void WeaponTypeSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_Add"); } 
bridgePINVOKE.WeaponTypeSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_Add: ",e);}
throw e;
   }     
}
}


public bool WeaponTypeSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_Remove"); } 
return bridgePINVOKE.WeaponTypeSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_create_iterator_begin"); } 
return bridgePINVOKE.WeaponTypeSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr WeaponTypeSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - WeaponTypeSet_get_next_key"); } 
return bridgePINVOKE.WeaponTypeSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in WeaponTypeSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_WeaponTypeSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_WeaponTypeSet"); } 
bridgePINVOKE.delete_WeaponTypeSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_WeaponTypeSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionPair__SWIG_0"); } 
return bridgePINVOKE.new_PositionPair__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionPair__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionPair__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionPair__SWIG_1"); } 
return bridgePINVOKE.new_PositionPair__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionPair__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_PositionPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PositionPair__SWIG_2"); } 
return bridgePINVOKE.new_PositionPair__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PositionPair__SWIG_2: ",e);}
throw e;
   }     
}
}


public void PositionPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionPair_first_set"); } 
bridgePINVOKE.PositionPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionPair_first_set: ",e);}
throw e;
   }     
}
}


public IntPtr PositionPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionPair_first_get"); } 
return bridgePINVOKE.PositionPair_first_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionPair_first_get: ",e);}
throw e;
   }     
}
}


public void PositionPair_second_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionPair_second_set"); } 
bridgePINVOKE.PositionPair_second_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionPair_second_set: ",e);}
throw e;
   }     
}
}


public IntPtr PositionPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PositionPair_second_get"); } 
return bridgePINVOKE.PositionPair_second_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PositionPair_second_get: ",e);}
throw e;
   }     
}
}


public void delete_PositionPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PositionPair"); } 
bridgePINVOKE.delete_PositionPair(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PositionPair: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrIntPair__SWIG_0"); } 
return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrIntPair__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_1(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrIntPair__SWIG_1"); } 
return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_1(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrIntPair__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrIntPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrIntPair__SWIG_2"); } 
return bridgePINVOKE.new_UnitTypePtrIntPair__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrIntPair__SWIG_2: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrIntPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntPair_first_set"); } 
bridgePINVOKE.UnitTypePtrIntPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntPair_first_set: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrIntPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntPair_first_get"); } 
return bridgePINVOKE.UnitTypePtrIntPair_first_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntPair_first_get: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrIntPair_second_set(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntPair_second_set"); } 
bridgePINVOKE.UnitTypePtrIntPair_second_set(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntPair_second_set: ",e);}
throw e;
   }     
}
}


public int UnitTypePtrIntPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntPair_second_get"); } 
return bridgePINVOKE.UnitTypePtrIntPair_second_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntPair_second_get: ",e);}
throw e;
   }     
}
}


public void delete_UnitTypePtrIntPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitTypePtrIntPair"); } 
bridgePINVOKE.delete_UnitTypePtrIntPair(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitTypePtrIntPair: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionSet__SWIG_0"); } 
return bridgePINVOKE.new_TilePositionSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionSet__SWIG_1"); } 
return bridgePINVOKE.new_TilePositionSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint TilePositionSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_size"); } 
return bridgePINVOKE.TilePositionSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_size: ",e);}
throw e;
   }     
}
}


public bool TilePositionSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_empty"); } 
return bridgePINVOKE.TilePositionSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_empty: ",e);}
throw e;
   }     
}
}


public void TilePositionSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_Clear"); } 
bridgePINVOKE.TilePositionSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_getitem"); } 
return bridgePINVOKE.TilePositionSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_getitem: ",e);}
throw e;
   }     
}
}


public bool TilePositionSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_ContainsKey"); } 
return bridgePINVOKE.TilePositionSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void TilePositionSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_Add"); } 
bridgePINVOKE.TilePositionSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_Add: ",e);}
throw e;
   }     
}
}


public bool TilePositionSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_Remove"); } 
return bridgePINVOKE.TilePositionSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_create_iterator_begin"); } 
return bridgePINVOKE.TilePositionSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionSet_get_next_key"); } 
return bridgePINVOKE.TilePositionSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_TilePositionSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TilePositionSet"); } 
bridgePINVOKE.delete_TilePositionSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TilePositionSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionDoubleMap__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionDoubleMap__SWIG_0"); } 
return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionDoubleMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionDoubleMap__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionDoubleMap__SWIG_1"); } 
return bridgePINVOKE.new_TilePositionDoubleMap__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionDoubleMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint TilePositionDoubleMap_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_size"); } 
return bridgePINVOKE.TilePositionDoubleMap_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_size: ",e);}
throw e;
   }     
}
}


public bool TilePositionDoubleMap_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_empty"); } 
return bridgePINVOKE.TilePositionDoubleMap_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_empty: ",e);}
throw e;
   }     
}
}


public void TilePositionDoubleMap_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_Clear"); } 
bridgePINVOKE.TilePositionDoubleMap_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_Clear: ",e);}
throw e;
   }     
}
}


public double TilePositionDoubleMap_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_getitem"); } 
return bridgePINVOKE.TilePositionDoubleMap_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_getitem: ",e);}
throw e;
   }     
}
}


public void TilePositionDoubleMap_setitem(IntPtr jarg1, IntPtr jarg2, double jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_setitem"); } 
bridgePINVOKE.TilePositionDoubleMap_setitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_setitem: ",e);}
throw e;
   }     
}
}


public bool TilePositionDoubleMap_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_ContainsKey"); } 
return bridgePINVOKE.TilePositionDoubleMap_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_ContainsKey: ",e);}
throw e;
   }     
}
}


public void TilePositionDoubleMap_Add(IntPtr jarg1, IntPtr jarg2, double jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_Add"); } 
bridgePINVOKE.TilePositionDoubleMap_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_Add: ",e);}
throw e;
   }     
}
}


public bool TilePositionDoubleMap_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_Remove"); } 
return bridgePINVOKE.TilePositionDoubleMap_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionDoubleMap_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_create_iterator_begin"); } 
return bridgePINVOKE.TilePositionDoubleMap_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionDoubleMap_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoubleMap_get_next_key"); } 
return bridgePINVOKE.TilePositionDoubleMap_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoubleMap_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_TilePositionDoubleMap(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TilePositionDoubleMap"); } 
bridgePINVOKE.delete_TilePositionDoubleMap(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TilePositionDoubleMap: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionDoublePair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionDoublePair__SWIG_0"); } 
return bridgePINVOKE.new_TilePositionDoublePair__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionDoublePair__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionDoublePair__SWIG_1(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionDoublePair__SWIG_1"); } 
return bridgePINVOKE.new_TilePositionDoublePair__SWIG_1(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionDoublePair__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionDoublePair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionDoublePair__SWIG_2"); } 
return bridgePINVOKE.new_TilePositionDoublePair__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionDoublePair__SWIG_2: ",e);}
throw e;
   }     
}
}


public void TilePositionDoublePair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoublePair_first_set"); } 
bridgePINVOKE.TilePositionDoublePair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoublePair_first_set: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionDoublePair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoublePair_first_get"); } 
return bridgePINVOKE.TilePositionDoublePair_first_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoublePair_first_get: ",e);}
throw e;
   }     
}
}


public void TilePositionDoublePair_second_set(IntPtr jarg1, double jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoublePair_second_set"); } 
bridgePINVOKE.TilePositionDoublePair_second_set(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoublePair_second_set: ",e);}
throw e;
   }     
}
}


public double TilePositionDoublePair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionDoublePair_second_get"); } 
return bridgePINVOKE.TilePositionDoublePair_second_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionDoublePair_second_get: ",e);}
throw e;
   }     
}
}


public void delete_TilePositionDoublePair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TilePositionDoublePair"); } 
bridgePINVOKE.delete_TilePositionDoublePair(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TilePositionDoublePair: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Clear"); } 
bridgePINVOKE.TilePositionVector_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Clear: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Add"); } 
bridgePINVOKE.TilePositionVector_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Add: ",e);}
throw e;
   }     
}
}


public uint TilePositionVector_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_size"); } 
return bridgePINVOKE.TilePositionVector_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_size: ",e);}
throw e;
   }     
}
}


public uint TilePositionVector_capacity(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_capacity"); } 
return bridgePINVOKE.TilePositionVector_capacity(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_capacity: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_reserve(IntPtr jarg1, uint jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_reserve"); } 
bridgePINVOKE.TilePositionVector_reserve(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_reserve: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionVector__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionVector__SWIG_0"); } 
return bridgePINVOKE.new_TilePositionVector__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionVector__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionVector__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionVector__SWIG_1"); } 
return bridgePINVOKE.new_TilePositionVector__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionVector__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_TilePositionVector__SWIG_2(int jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_TilePositionVector__SWIG_2"); } 
return bridgePINVOKE.new_TilePositionVector__SWIG_2(jarg1);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_TilePositionVector__SWIG_2: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionVector_getitemcopy(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_getitemcopy"); } 
return bridgePINVOKE.TilePositionVector_getitemcopy(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_getitemcopy: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionVector_getitem(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_getitem"); } 
return bridgePINVOKE.TilePositionVector_getitem(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_getitem: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_setitem(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_setitem"); } 
bridgePINVOKE.TilePositionVector_setitem(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_setitem: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_AddRange(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_AddRange"); } 
bridgePINVOKE.TilePositionVector_AddRange(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_AddRange: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionVector_GetRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_GetRange"); } 
return bridgePINVOKE.TilePositionVector_GetRange(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_GetRange: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_Insert(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Insert"); } 
bridgePINVOKE.TilePositionVector_Insert(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Insert: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_InsertRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_InsertRange"); } 
bridgePINVOKE.TilePositionVector_InsertRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_InsertRange: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_RemoveAt(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_RemoveAt"); } 
bridgePINVOKE.TilePositionVector_RemoveAt(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_RemoveAt: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_RemoveRange(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_RemoveRange"); } 
bridgePINVOKE.TilePositionVector_RemoveRange(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_RemoveRange: ",e);}
throw e;
   }     
}
}


public IntPtr TilePositionVector_Repeat(IntPtr jarg1, int jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Repeat"); } 
return bridgePINVOKE.TilePositionVector_Repeat(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Repeat: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_Reverse__SWIG_0(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Reverse__SWIG_0"); } 
bridgePINVOKE.TilePositionVector_Reverse__SWIG_0(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Reverse__SWIG_0: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_Reverse__SWIG_1(IntPtr jarg1, int jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_Reverse__SWIG_1"); } 
bridgePINVOKE.TilePositionVector_Reverse__SWIG_1(new HandleRef(null,jarg1), jarg2, jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_Reverse__SWIG_1: ",e);}
throw e;
   }     
}
}


public void TilePositionVector_SetRange(IntPtr jarg1, int jarg2, IntPtr jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - TilePositionVector_SetRange"); } 
bridgePINVOKE.TilePositionVector_SetRange(new HandleRef(null,jarg1), jarg2, new HandleRef(null,jarg3));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in TilePositionVector_SetRange: ",e);}
throw e;
   }     
}
}


public void delete_TilePositionVector(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_TilePositionVector"); } 
bridgePINVOKE.delete_TilePositionVector(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_TilePositionVector: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrIntMap__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrIntMap__SWIG_0"); } 
return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrIntMap__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypePtrIntMap__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypePtrIntMap__SWIG_1"); } 
return bridgePINVOKE.new_UnitTypePtrIntMap__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypePtrIntMap__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint UnitTypePtrIntMap_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_size"); } 
return bridgePINVOKE.UnitTypePtrIntMap_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_size: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrIntMap_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_empty"); } 
return bridgePINVOKE.UnitTypePtrIntMap_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_empty: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrIntMap_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_Clear"); } 
bridgePINVOKE.UnitTypePtrIntMap_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_Clear: ",e);}
throw e;
   }     
}
}


public int UnitTypePtrIntMap_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_getitem"); } 
return bridgePINVOKE.UnitTypePtrIntMap_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_getitem: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrIntMap_setitem(IntPtr jarg1, IntPtr jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_setitem"); } 
bridgePINVOKE.UnitTypePtrIntMap_setitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_setitem: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrIntMap_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_ContainsKey"); } 
return bridgePINVOKE.UnitTypePtrIntMap_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_ContainsKey: ",e);}
throw e;
   }     
}
}


public void UnitTypePtrIntMap_Add(IntPtr jarg1, IntPtr jarg2, int jarg3) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_Add"); } 
bridgePINVOKE.UnitTypePtrIntMap_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2), jarg3);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_Add: ",e);}
throw e;
   }     
}
}


public bool UnitTypePtrIntMap_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_Remove"); } 
return bridgePINVOKE.UnitTypePtrIntMap_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrIntMap_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_create_iterator_begin"); } 
return bridgePINVOKE.UnitTypePtrIntMap_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypePtrIntMap_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypePtrIntMap_get_next_key"); } 
return bridgePINVOKE.UnitTypePtrIntMap_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypePtrIntMap_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitTypePtrIntMap(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitTypePtrIntMap"); } 
bridgePINVOKE.delete_UnitTypePtrIntMap(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitTypePtrIntMap: ",e);}
throw e;
   }     
}
}


public void UnitPtrList_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_Clear"); } 
bridgePINVOKE.UnitPtrList_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_Clear: ",e);}
throw e;
   }     
}
}


public void UnitPtrList_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_Add"); } 
bridgePINVOKE.UnitPtrList_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_Add: ",e);}
throw e;
   }     
}
}


public uint UnitPtrList_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_size"); } 
return bridgePINVOKE.UnitPtrList_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_size: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitPtrList__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitPtrList__SWIG_0"); } 
return bridgePINVOKE.new_UnitPtrList__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitPtrList__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitPtrList__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitPtrList__SWIG_1"); } 
return bridgePINVOKE.new_UnitPtrList__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitPtrList__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr UnitPtrList_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_create_iterator_begin"); } 
return bridgePINVOKE.UnitPtrList_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitPtrList_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_get_next_key"); } 
return bridgePINVOKE.UnitPtrList_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_get_next_key: ",e);}
throw e;
   }     
}
}


public bool UnitPtrList_Contains(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_Contains"); } 
return bridgePINVOKE.UnitPtrList_Contains(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_Contains: ",e);}
throw e;
   }     
}
}


public bool UnitPtrList_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitPtrList_Remove"); } 
return bridgePINVOKE.UnitPtrList_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitPtrList_Remove: ",e);}
throw e;
   }     
}
}


public void delete_UnitPtrList(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitPtrList"); } 
bridgePINVOKE.delete_UnitPtrList(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitPtrList: ",e);}
throw e;
   }     
}
}


public void UnitTypeList_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeList_Clear"); } 
bridgePINVOKE.UnitTypeList_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeList_Clear: ",e);}
throw e;
   }     
}
}


public void UnitTypeList_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeList_Add"); } 
bridgePINVOKE.UnitTypeList_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeList_Add: ",e);}
throw e;
   }     
}
}


public uint UnitTypeList_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeList_size"); } 
return bridgePINVOKE.UnitTypeList_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeList_size: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypeList__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypeList__SWIG_0"); } 
return bridgePINVOKE.new_UnitTypeList__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypeList__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_UnitTypeList__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_UnitTypeList__SWIG_1"); } 
return bridgePINVOKE.new_UnitTypeList__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_UnitTypeList__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeList_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeList_create_iterator_begin"); } 
return bridgePINVOKE.UnitTypeList_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeList_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr UnitTypeList_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - UnitTypeList_get_next_key"); } 
return bridgePINVOKE.UnitTypeList_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in UnitTypeList_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_UnitTypeList(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_UnitTypeList"); } 
bridgePINVOKE.delete_UnitTypeList(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_UnitTypeList: ",e);}
throw e;
   }     
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RegionPtrRegionPtrPair__SWIG_0"); } 
return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RegionPtrRegionPtrPair__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_1(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RegionPtrRegionPtrPair__SWIG_1"); } 
return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_1(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RegionPtrRegionPtrPair__SWIG_1: ",e);}
throw e;
   }     
}
}


public IntPtr new_RegionPtrRegionPtrPair__SWIG_2(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RegionPtrRegionPtrPair__SWIG_2"); } 
return bridgePINVOKE.new_RegionPtrRegionPtrPair__SWIG_2(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RegionPtrRegionPtrPair__SWIG_2: ",e);}
throw e;
   }     
}
}


public void RegionPtrRegionPtrPair_first_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrRegionPtrPair_first_set"); } 
bridgePINVOKE.RegionPtrRegionPtrPair_first_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrRegionPtrPair_first_set: ",e);}
throw e;
   }     
}
}


public IntPtr RegionPtrRegionPtrPair_first_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrRegionPtrPair_first_get"); } 
return bridgePINVOKE.RegionPtrRegionPtrPair_first_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrRegionPtrPair_first_get: ",e);}
throw e;
   }     
}
}


public void RegionPtrRegionPtrPair_second_set(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrRegionPtrPair_second_set"); } 
bridgePINVOKE.RegionPtrRegionPtrPair_second_set(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrRegionPtrPair_second_set: ",e);}
throw e;
   }     
}
}


public IntPtr RegionPtrRegionPtrPair_second_get(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrRegionPtrPair_second_get"); } 
return bridgePINVOKE.RegionPtrRegionPtrPair_second_get(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrRegionPtrPair_second_get: ",e);}
throw e;
   }     
}
}


public void delete_RegionPtrRegionPtrPair(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_RegionPtrRegionPtrPair"); } 
bridgePINVOKE.delete_RegionPtrRegionPtrPair(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_RegionPtrRegionPtrPair: ",e);}
throw e;
   }     
}
}


public IntPtr new_BaseLocationPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_BaseLocationPtrSet__SWIG_0"); } 
return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_BaseLocationPtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_BaseLocationPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_BaseLocationPtrSet__SWIG_1"); } 
return bridgePINVOKE.new_BaseLocationPtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_BaseLocationPtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint BaseLocationPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_size"); } 
return bridgePINVOKE.BaseLocationPtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_size: ",e);}
throw e;
   }     
}
}


public bool BaseLocationPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_empty"); } 
return bridgePINVOKE.BaseLocationPtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_empty: ",e);}
throw e;
   }     
}
}


public void BaseLocationPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_Clear"); } 
bridgePINVOKE.BaseLocationPtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocationPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_getitem"); } 
return bridgePINVOKE.BaseLocationPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool BaseLocationPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_ContainsKey"); } 
return bridgePINVOKE.BaseLocationPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void BaseLocationPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_Add"); } 
bridgePINVOKE.BaseLocationPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool BaseLocationPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_Remove"); } 
return bridgePINVOKE.BaseLocationPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocationPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_create_iterator_begin"); } 
return bridgePINVOKE.BaseLocationPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr BaseLocationPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - BaseLocationPtrSet_get_next_key"); } 
return bridgePINVOKE.BaseLocationPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in BaseLocationPtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_BaseLocationPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_BaseLocationPtrSet"); } 
bridgePINVOKE.delete_BaseLocationPtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_BaseLocationPtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_ChokepointPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ChokepointPtrSet__SWIG_0"); } 
return bridgePINVOKE.new_ChokepointPtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ChokepointPtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_ChokepointPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_ChokepointPtrSet__SWIG_1"); } 
return bridgePINVOKE.new_ChokepointPtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_ChokepointPtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint ChokepointPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_size"); } 
return bridgePINVOKE.ChokepointPtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_size: ",e);}
throw e;
   }     
}
}


public bool ChokepointPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_empty"); } 
return bridgePINVOKE.ChokepointPtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_empty: ",e);}
throw e;
   }     
}
}


public void ChokepointPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_Clear"); } 
bridgePINVOKE.ChokepointPtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr ChokepointPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_getitem"); } 
return bridgePINVOKE.ChokepointPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool ChokepointPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_ContainsKey"); } 
return bridgePINVOKE.ChokepointPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void ChokepointPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_Add"); } 
bridgePINVOKE.ChokepointPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool ChokepointPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_Remove"); } 
return bridgePINVOKE.ChokepointPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr ChokepointPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_create_iterator_begin"); } 
return bridgePINVOKE.ChokepointPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr ChokepointPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - ChokepointPtrSet_get_next_key"); } 
return bridgePINVOKE.ChokepointPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in ChokepointPtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_ChokepointPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_ChokepointPtrSet"); } 
bridgePINVOKE.delete_ChokepointPtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_ChokepointPtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_PolygonPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PolygonPtrSet__SWIG_0"); } 
return bridgePINVOKE.new_PolygonPtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PolygonPtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_PolygonPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_PolygonPtrSet__SWIG_1"); } 
return bridgePINVOKE.new_PolygonPtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_PolygonPtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint PolygonPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_size"); } 
return bridgePINVOKE.PolygonPtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_size: ",e);}
throw e;
   }     
}
}


public bool PolygonPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_empty"); } 
return bridgePINVOKE.PolygonPtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_empty: ",e);}
throw e;
   }     
}
}


public void PolygonPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_Clear"); } 
bridgePINVOKE.PolygonPtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr PolygonPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_getitem"); } 
return bridgePINVOKE.PolygonPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool PolygonPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_ContainsKey"); } 
return bridgePINVOKE.PolygonPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void PolygonPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_Add"); } 
bridgePINVOKE.PolygonPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool PolygonPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_Remove"); } 
return bridgePINVOKE.PolygonPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr PolygonPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_create_iterator_begin"); } 
return bridgePINVOKE.PolygonPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr PolygonPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonPtrSet_get_next_key"); } 
return bridgePINVOKE.PolygonPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonPtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_PolygonPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_PolygonPtrSet"); } 
bridgePINVOKE.delete_PolygonPtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_PolygonPtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr new_RegionPtrSet__SWIG_0( ) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RegionPtrSet__SWIG_0"); } 
return bridgePINVOKE.new_RegionPtrSet__SWIG_0();
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RegionPtrSet__SWIG_0: ",e);}
throw e;
   }     
}
}


public IntPtr new_RegionPtrSet__SWIG_1(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - new_RegionPtrSet__SWIG_1"); } 
return bridgePINVOKE.new_RegionPtrSet__SWIG_1(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in new_RegionPtrSet__SWIG_1: ",e);}
throw e;
   }     
}
}


public uint RegionPtrSet_size(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_size"); } 
return bridgePINVOKE.RegionPtrSet_size(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_size: ",e);}
throw e;
   }     
}
}


public bool RegionPtrSet_empty(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_empty"); } 
return bridgePINVOKE.RegionPtrSet_empty(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_empty: ",e);}
throw e;
   }     
}
}


public void RegionPtrSet_Clear(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_Clear"); } 
bridgePINVOKE.RegionPtrSet_Clear(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_Clear: ",e);}
throw e;
   }     
}
}


public IntPtr RegionPtrSet_getitem(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_getitem"); } 
return bridgePINVOKE.RegionPtrSet_getitem(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_getitem: ",e);}
throw e;
   }     
}
}


public bool RegionPtrSet_ContainsKey(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_ContainsKey"); } 
return bridgePINVOKE.RegionPtrSet_ContainsKey(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_ContainsKey: ",e);}
throw e;
   }     
}
}


public void RegionPtrSet_Add(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_Add"); } 
bridgePINVOKE.RegionPtrSet_Add(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_Add: ",e);}
throw e;
   }     
}
}


public bool RegionPtrSet_Remove(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_Remove"); } 
return bridgePINVOKE.RegionPtrSet_Remove(new HandleRef(null,jarg1), new HandleRef(null,jarg2));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_Remove: ",e);}
throw e;
   }     
}
}


public IntPtr RegionPtrSet_create_iterator_begin(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_create_iterator_begin"); } 
return bridgePINVOKE.RegionPtrSet_create_iterator_begin(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_create_iterator_begin: ",e);}
throw e;
   }     
}
}


public IntPtr RegionPtrSet_get_next_key(IntPtr jarg1, IntPtr jarg2) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - RegionPtrSet_get_next_key"); } 
return bridgePINVOKE.RegionPtrSet_get_next_key(new HandleRef(null,jarg1), jarg2);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in RegionPtrSet_get_next_key: ",e);}
throw e;
   }     
}
}


public void delete_RegionPtrSet(IntPtr jarg1) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - delete_RegionPtrSet"); } 
bridgePINVOKE.delete_RegionPtrSet(new HandleRef(null,jarg1));
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in delete_RegionPtrSet: ",e);}
throw e;
   }     
}
}


public IntPtr PolygonUpcast(IntPtr objectRef) {
 lock(typeof(bridgePINVOKE)) { 
 try {
     if (errorlog != null) { errorlog.Debug("Calling - PolygonUpcast"); } 
return bridgePINVOKE.PolygonUpcast(objectRef);
} catch (Exception e) {
 if(errorlog != null) { errorlog.Debug("Error in PolygonUpcast: ",e);}
throw e;
   }     
}
}

}
}