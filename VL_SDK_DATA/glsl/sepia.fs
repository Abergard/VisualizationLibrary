/**************************************************************************************/
/*                                                                                    */
/*  Copyright (c) 2005-2010, Michele Bosi.                                            */
/*  All rights reserved.                                                              */
/*                                                                                    */
/*  This file is part of Visualization Library                                        */
/*  http://www.visualizationlibrary.com                                               */
/*                                                                                    */
/*  Released under the OSI approved Simplified BSD License                            */
/*  http://www.opensource.org/licenses/bsd-license.php                                */
/*                                                                                    */
/**************************************************************************************/

void main(void)
{
	float gray = dot( gl_Color.xyz + gl_SecondaryColor, vec3(0.299,0.587,0.114) );
	gl_FragColor = vec4(vec3(1.2,1.0,0.8)*gray, 1.0);
}
