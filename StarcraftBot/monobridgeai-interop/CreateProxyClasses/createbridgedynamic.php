<?php 
	function UsageAndDie() {
		print " Usage: <Input Directory> <Output Directory>";
		die();
	}
	
	if ($argc < 2) {
		UsageAndDie();
	}
	$inputdir = $argv[1];
	$outputdir = $argv[2];
	if (!(file_exists($inputdir) && file_exists($outputdir))) {
		UsageAndDie();
	} 
	$bridgepinvokefile = $inputdir.'\bridgePINVOKE.cs';
	
	if (!file_exists($bridgepinvokefile)) {
		print "No Such file: $bridgepinvokefile\r\n";
		UsageAndDie();
	}

	$f = file_get_contents($bridgepinvokefile);

	//now mod the file to create the new one.
	function convert_method($matches) {
		if ((strpos($matches[2],'SWIG') == 0) && (!(strpos($matches[2],'SWIG') === FALSE))) {
			return "";
		}
		$newm = "public {$matches[1]} {$matches[2]}({$matches[3]}) {\r\n  ";
		if ($matches[1] <> 'void') {
			$newm .= "return ";
		}
		$newm .= "bridgePINVOKE.{$matches[2]}(";
		$args = explode(',',$matches[3]);
		$argcount = 0;
		foreach ($args as $arg) {
			$var = explode(' ',trim($arg));
			if ($argcount > 0) {
				$newm .= ', ';
			}
			$newm .= $var[1];
			$argcount++;
		}
		$newm .= ");\r\n}\r\n";
		return $newm;
	}
	
	
	//find all declarations
	//$f = preg_replace_callback('|public static extern (.*?) (.*?)\((.*?)\);|',convert_method,$f);

	 $methods = array();
	 preg_match_all('|public static extern (.*?) (.*?)\((.*?)\);|',$f,$methods,PREG_SET_ORDER);
	 
	 $newfile = "
namespace BWAPI {

using System;
using System.Runtime.InteropServices;


class bridgePINVOKEProxy {
	public static bridgePINVOKEDynamic remote;
	
	public static void connectProxy() {
		remote = new bridgePINVOKEDynamic();
	}
}



class bridgePINVOKEDynamic: MarshalByRefObject {

	
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

public bridgePINVOKEDynamic() {
	SWIGPendingException = new SWIGPendingExceptionDynamic();
}
";

	foreach ($methods as $method) {
		$newfile .= "\r\n".convert_method($method)."\r\n";
	}
	
	$newfile .= "}\r\n}";
	 
	
	$outfile = $outputdir.'\bridgePINVOKEDynamic.cs';
	file_put_contents($outfile,$newfile);
	
//now iterate through our classes and have them use our proxy class
	
	function file_list($d,$x){ 
       foreach(array_diff(scandir($d),array('.','..')) as $f)if(is_file($d.'/'.$f)&&(($x)?ereg($x.'$',$f):1))$l[]=$f; 
       return $l; 
	} 
	
	function patchfile($file) {
		global $inputdir,$outputdir;
		$f = file_get_contents($inputdir.DIRECTORY_SEPARATOR.$file);
		$f = preg_replace('|bridgePINVOKE\.|','bridgePINVOKEProxy.remote.',$f);
		file_put_contents($outputdir.DIRECTORY_SEPARATOR.$file,$f);
	}
	
	$csfiles = file_list($inputdir,'.cs');
	foreach($csfiles as $csfile) {
		patchfile($csfile);
	}
	print " Done";
?>